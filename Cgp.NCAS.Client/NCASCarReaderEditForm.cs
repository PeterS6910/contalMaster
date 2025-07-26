using System;
using System.Windows.Forms;
using Contal.Cgp.Client;
using Contal.Cgp.Client.PluginSupport;
using Contal.Cgp.NCAS.Server.Beans;
using Contal.IwQuick;
using Contal.IwQuick.UI;

namespace Contal.Cgp.NCAS.Client
{
    public sealed partial class NCASCarReaderEditForm :
#if DESIGNER
        Form
#else
        ACgpPluginEditForm<NCASClient, CarReader>
#endif
    {
        public NCASCarReaderEditForm(CarReader carReader, ShowOptionsEditForm showOption, PluginMainForm<NCASClient> myTableForm)
            : base(carReader, showOption, CgpClientMainForm.Singleton, myTableForm, NCASClient.LocalizationHelper)
        {
            InitializeComponent();
            _cmaaAlarmArcs.Plugin = Plugin;
            SetReferenceEditColors();
        }

        protected override void BeforeInsert() { }
        protected override void BeforeEdit() { }

        public override void ReloadEditingObject(out bool allowEdit)
        {
            Exception error;
            var obj = Plugin.MainServerProvider.CarReaders.GetObjectForEdit(_editingObject.IdCarReader, out error);
            if (error != null)
            {
                if (error is AccessDeniedException)
                {
                    allowEdit = false;
                    obj = Plugin.MainServerProvider.CarReaders.GetObjectById(_editingObject.IdCarReader);
                }
                else
                {
                    throw error;
                }
                DisableForm();
            }
            else
            {
                allowEdit = true;
            }
            _editingObject = obj;
        }

        public override void ReloadEditingObjectWithEditedData()
        {
            Exception error;
            Plugin.MainServerProvider.CarReaders.RenewObjectForEdit(_editingObject.IdCarReader, out error);
            if (error != null)
                throw error;
        }

        protected override void SetValuesInsert()
        {
            SetValuesEdit();
        }

        protected override void SetValuesEdit()
        {
            _eName.Text = _editingObject.Name;
            _cbCameraType.DataSource = Enum.GetValues(typeof(CarReaderType));
            _cbCameraType.SelectedItem = _editingObject.CameraType;
            _eIpAddress.Text = _editingObject.IpAddress;
            _nudPort.Value = _editingObject.Port;
            _eDescription.Text = _editingObject.Description;
        }

        protected override bool CheckValues()
        {
            if (string.IsNullOrEmpty(_eName.Text))
            {
                ControlNotification.Singleton.Error(NotificationPriority.JustOne, _eName,
                    GetString("ErrorEntryCarReaderName"), CgpClient.Singleton.ClientControlNotificationSettings);
                _eName.Focus();
                return false;
            }
            return true;
        }

        protected override bool GetValues()
        {
            _editingObject.Name = _eName.Text;
            if (_cbCameraType.SelectedItem != null)
                _editingObject.CameraType = (CarReaderType)_cbCameraType.SelectedItem;
            _editingObject.IpAddress = _eIpAddress.Text;
            _editingObject.Port = (int)_nudPort.Value;
            _editingObject.Description = _eDescription.Text;
            return true;
        }

        protected override bool SaveToDatabaseInsert()
        {
            Exception error;
            var ret = Plugin.MainServerProvider.CarReaders.Insert(ref _editingObject, out error);
            if (!ret && error != null)
                throw error;
            return ret;
        }

        protected override bool SaveToDatabaseEdit()
        {
            Exception error;
            var ret = Plugin.MainServerProvider.CarReaders.Update(_editingObject, out error);
            if (!ret && error != null)
                throw error;
            return ret;
        }

        protected override bool SaveToDatabaseEditOnlyInDatabase()
        {
            Exception error;
            var ret = Plugin.MainServerProvider.CarReaders.UpdateOnlyInDatabase(_editingObject, out error);
            if (!ret && error != null)
                throw error;
            return ret;
        }

        protected override void EditEnd()
        {
            if (Plugin.MainServerProvider?.CarReaders != null)
                Plugin.MainServerProvider.CarReaders.EditEnd(_editingObject);
        }

        private void _bOk_Click(object sender, EventArgs e) { Ok_Click(); }
        private void _bCancel_Click(object sender, EventArgs e) { Cancel_Click(); }
    }
}
