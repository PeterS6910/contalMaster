using Contal.Cgp.Client;
using Contal.Cgp.Client.PluginSupport;
using Contal.Cgp.Components;
using Contal.Cgp.NCAS.Server.Beans;
using Contal.Cgp.NCAS.Server.Beans.Shorts;
using Contal.IwQuick;
using Contal.IwQuick.Sys;
using Contal.IwQuick.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Contal.Cgp.NCAS.Client
{
    public partial class NCASCarReadersForm :
#if DESIGNER
        Form
#else
        ACgpPluginTableForm<NCASClient, CarReader, CarReaderShort>
#endif
    {
        private static volatile NCASCarReadersForm _singleton;
        private static readonly object SyncRoot = new object();

        public static NCASCarReadersForm Singleton
        {
            get
            {
                if (_singleton == null)
                    lock (SyncRoot)
                        if (_singleton == null)
                        {
                            _singleton = new NCASCarReadersForm
                            {
                                MdiParent = CgpClientMainForm.Singleton
                            };
                        }
                return _singleton;
            }
        }

        private readonly CgpDataGridView _cdgvData = new CgpDataGridView();

        public NCASCarReadersForm()
            : base(
                CgpClientMainForm.Singleton,
                NCASClient.Singleton,
                NCASClient.LocalizationHelper)
        {
            FormImage = ResourceGlobal.carReader;
            InitializeComponent();
            InitializeCustomComponent();
            InitCgpDataGridView();
            Name = "NCASCarReadersForm";
            Icon = ResourceGlobal.IconCarReader;
        }

        private void InitializeCustomComponent()
        {
            SuspendLayout();
            _cdgvData.Dock = DockStyle.Fill;
            Controls.Add(_cdgvData);
            Text = "NCASCarReadersForm";
            ResumeLayout(false);
        }

        private void InitCgpDataGridView()
        {
            _cdgvData.LocalizationHelper = NCASClient.LocalizationHelper;
            _cdgvData.ImageList = ((ICgpVisualPlugin)NCASClient.Singleton).GetPluginObjectsImages();
            _cdgvData.CgpDataGridEvents = this;
        }

        protected override ICollection<CarReaderShort> GetData()
        {
            // Data retrieval not implemented yet
            Exception error;
            var list = Plugin.MainServerProvider.CarReaders.ShortSelectByCriteria(
                FilterSettings,
                out error);

            if (error != null)
                throw error;

            return list;
        }

        protected override void ModifyGridView(BindingSource bindingSource)
        {
            _cdgvData.ModifyGridView(
                bindingSource,
                CarReaderShort.COLUMN_SYMBOL,
                CarReaderShort.COLUMN_NAME,
                CarReaderShort.COLUMN_IP_ADDRESS,
                CarReaderShort.COLUMN_PORT,
                CarReaderShort.COLUMN_DESCRIPTION);
        }

        protected override void RemoveGridView()
        {
            _cdgvData.RemoveDataSource();
        }

        protected override ACgpPluginEditForm<NCASClient, CarReader> CreateEditForm(CarReader obj, ShowOptionsEditForm showOption)
        {
            return new NCASCarReaderEditForm(obj, showOption, this);
        }

        protected override CarReader GetObjectForEdit(CarReaderShort listObj, out bool editEnabled)
        {
            return Plugin.MainServerProvider.CarReaders.GetObjectForEditById(listObj.IdCarReader, out editEnabled);
        }

        protected override CarReader GetFromShort(CarReaderShort listObj)
        {
            return null;
        }

        protected override bool Compare(CarReader obj1, CarReader obj2)
        {
            return obj1.Compare(obj2);
        }

        protected override bool CombareByGuid(CarReader obj, Guid id)
        {
            return obj.IdCarReader == id;
        }

        protected override void DeleteObj(CarReader obj)
        {
            Exception error;
            if (!Plugin.MainServerProvider.CarReaders.Delete(obj, out error))
                throw error;
        }

        protected override void SetFilterSettings()
        {
        }

        protected override void ClearFilterEdits()
        {
        }

        public override bool HasAccessView()
        {
            try
            {
                if (CgpClient.Singleton.IsLoggedIn)
                    return Plugin.MainServerProvider.CarReaders.HasAccessView();
            }
            catch (Exception error)
            {
                HandledExceptionAdapter.Examine(error);
            }

            return false;
        }

        public override bool HasAccessView(CarReader obj)
        {
            try
            {
                if (CgpClient.Singleton.IsLoggedIn)
                    return Plugin.MainServerProvider.CarReaders.HasAccessViewForObject(obj);
            }
            catch (Exception error)
            {
                HandledExceptionAdapter.Examine(error);
            }

            return false;
        }

        public override bool HasAccessInsert()
        {
            try
            {
                if (CgpClient.Singleton.IsLoggedIn)
                    return Plugin.MainServerProvider.CarReaders.HasAccessInsert();
            }
            catch (Exception error)
            {
                HandledExceptionAdapter.Examine(error);
            }
            return false;
        }

        protected override void RegisterEvents()
        {
        }

        protected override void UnregisterEvents()
        {
        }
    }
}
