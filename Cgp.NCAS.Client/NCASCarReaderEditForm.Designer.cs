namespace Contal.Cgp.NCAS.Client
{
    partial class NCASCarReaderEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label _lName;
        private System.Windows.Forms.TextBox _eName;
        private System.Windows.Forms.Label _lCameraType;
        private System.Windows.Forms.ComboBox _cbCameraType;
        private System.Windows.Forms.Label _lDCU;
        private System.Windows.Forms.TextBox _eDCU;
        private System.Windows.Forms.Label _lCCU;
        private System.Windows.Forms.TextBox _eCCU;
        private System.Windows.Forms.Label _lIpAddress;
        private System.Windows.Forms.TextBox _eIpAddress;
        private System.Windows.Forms.Label _lPort;
        private System.Windows.Forms.NumericUpDown _nudPort;
        private System.Windows.Forms.Label _lUniqueKey;
        private System.Windows.Forms.TextBox _eUniqueKey;
        private System.Windows.Forms.Label _lInterfaceSource;
        private System.Windows.Forms.TextBox _eInterfaceSource;
        private System.Windows.Forms.Label _lPortSsl;
        private System.Windows.Forms.NumericUpDown _nudPortSsl;
        private System.Windows.Forms.Label _lEquipment;
        private System.Windows.Forms.TextBox _eEquipment;
        private System.Windows.Forms.Label _lLocked;
        private System.Windows.Forms.CheckBox _chkLocked;
        private System.Windows.Forms.Label _lLockingClientIp;
        private System.Windows.Forms.TextBox _eLockingClientIp;
        private System.Windows.Forms.Label _lMacAddress;
        private System.Windows.Forms.TextBox _eMacAddress;
        private System.Windows.Forms.Label _lSerial;
        private System.Windows.Forms.TextBox _eSerial;
        private System.Windows.Forms.Label _lModel;
        private System.Windows.Forms.TextBox _eModel;
        private System.Windows.Forms.Label _lType;
        private System.Windows.Forms.TextBox _eType;
        private System.Windows.Forms.Label _lBuild;
        private System.Windows.Forms.TextBox _eBuild;
        private System.Windows.Forms.Label _lDescription;
        private System.Windows.Forms.TextBox _eDescription;
        private System.Windows.Forms.Label _lAlarmArcs;
        private ControlModifyAlarmArcs _cmaaAlarmArcs;
        private System.Windows.Forms.Button _bOk;
        private System.Windows.Forms.Button _bCancel;
        private System.Windows.Forms.TableLayoutPanel _panelBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._panelBack = new System.Windows.Forms.TableLayoutPanel();
            this._lName = new System.Windows.Forms.Label();
            this._eName = new System.Windows.Forms.TextBox();
            this._lCameraType = new System.Windows.Forms.Label();
            this._cbCameraType = new System.Windows.Forms.ComboBox();
            this._lDCU = new System.Windows.Forms.Label();
            this._eDCU = new System.Windows.Forms.TextBox();
            this._lCCU = new System.Windows.Forms.Label();
            this._eCCU = new System.Windows.Forms.TextBox();
            this._lIpAddress = new System.Windows.Forms.Label();
            this._eIpAddress = new System.Windows.Forms.TextBox();
            this._lPort = new System.Windows.Forms.Label();
            this._nudPort = new System.Windows.Forms.NumericUpDown();
            this._lUniqueKey = new System.Windows.Forms.Label();
            this._eUniqueKey = new System.Windows.Forms.TextBox();
            this._lInterfaceSource = new System.Windows.Forms.Label();
            this._eInterfaceSource = new System.Windows.Forms.TextBox();
            this._lPortSsl = new System.Windows.Forms.Label();
            this._nudPortSsl = new System.Windows.Forms.NumericUpDown();
            this._lEquipment = new System.Windows.Forms.Label();
            this._eEquipment = new System.Windows.Forms.TextBox();
            this._lLocked = new System.Windows.Forms.Label();
            this._chkLocked = new System.Windows.Forms.CheckBox();
            this._lLockingClientIp = new System.Windows.Forms.Label();
            this._eLockingClientIp = new System.Windows.Forms.TextBox();
            this._lMacAddress = new System.Windows.Forms.Label();
            this._eMacAddress = new System.Windows.Forms.TextBox();
            this._lSerial = new System.Windows.Forms.Label();
            this._eSerial = new System.Windows.Forms.TextBox();
            this._lModel = new System.Windows.Forms.Label();
            this._eModel = new System.Windows.Forms.TextBox();
            this._lType = new System.Windows.Forms.Label();
            this._eType = new System.Windows.Forms.TextBox();
            this._lBuild = new System.Windows.Forms.Label();
            this._eBuild = new System.Windows.Forms.TextBox();
            this._lDescription = new System.Windows.Forms.Label();
            this._eDescription = new System.Windows.Forms.TextBox();
            this._lAlarmArcs = new System.Windows.Forms.Label();
            this._cmaaAlarmArcs = new Contal.Cgp.NCAS.Client.ControlModifyAlarmArcs();
            this._bOk = new System.Windows.Forms.Button();
            this._bCancel = new System.Windows.Forms.Button();
            this._panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudPortSsl)).BeginInit();
            this.SuspendLayout();
            // 
            // _panelBack
            // 
            this._panelBack.ColumnCount = 2;
            this._panelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._panelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._panelBack.Controls.Add(this._lName, 0, 0);
            this._panelBack.Controls.Add(this._eName, 1, 0);
            this._panelBack.Controls.Add(this._lCameraType, 0, 1);
            this._panelBack.Controls.Add(this._cbCameraType, 1, 1);
            this._panelBack.Controls.Add(this._lDCU, 0, 2);
            this._panelBack.Controls.Add(this._eDCU, 1, 2);
            this._panelBack.Controls.Add(this._lCCU, 0, 3);
            this._panelBack.Controls.Add(this._eCCU, 1, 3);
            this._panelBack.Controls.Add(this._lIpAddress, 0, 4);
            this._panelBack.Controls.Add(this._eIpAddress, 1, 4);
            this._panelBack.Controls.Add(this._lPort, 0, 5);
            this._panelBack.Controls.Add(this._nudPort, 1, 5);
            this._panelBack.Controls.Add(this._lUniqueKey, 0, 6);
            this._panelBack.Controls.Add(this._eUniqueKey, 1, 6);
            this._panelBack.Controls.Add(this._lInterfaceSource, 0, 7);
            this._panelBack.Controls.Add(this._eInterfaceSource, 1, 7);
            this._panelBack.Controls.Add(this._lPortSsl, 0, 8);
            this._panelBack.Controls.Add(this._nudPortSsl, 1, 8);
            this._panelBack.Controls.Add(this._lEquipment, 0, 9);
            this._panelBack.Controls.Add(this._eEquipment, 1, 9);
            this._panelBack.Controls.Add(this._lLocked, 0, 10);
            this._panelBack.Controls.Add(this._chkLocked, 1, 10);
            this._panelBack.Controls.Add(this._lLockingClientIp, 0, 11);
            this._panelBack.Controls.Add(this._eLockingClientIp, 1, 11);
            this._panelBack.Controls.Add(this._lMacAddress, 0, 12);
            this._panelBack.Controls.Add(this._eMacAddress, 1, 12);
            this._panelBack.Controls.Add(this._lSerial, 0, 13);
            this._panelBack.Controls.Add(this._eSerial, 1, 13);
            this._panelBack.Controls.Add(this._lModel, 0, 14);
            this._panelBack.Controls.Add(this._eModel, 1, 14);
            this._panelBack.Controls.Add(this._lType, 0, 15);
            this._panelBack.Controls.Add(this._eType, 1, 15);
            this._panelBack.Controls.Add(this._lBuild, 0, 16);
            this._panelBack.Controls.Add(this._eBuild, 1, 16);
            this._panelBack.Controls.Add(this._lDescription, 0, 17);
            this._panelBack.Controls.Add(this._eDescription, 1, 17);
            this._panelBack.Controls.Add(this._lAlarmArcs, 0, 18);
            this._panelBack.Controls.Add(this._cmaaAlarmArcs, 1, 18); ;
            this._panelBack.Location = new System.Drawing.Point(12, 12);
            this._panelBack.Name = "_panelBack";
            this._panelBack.RowCount = 19;
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._panelBack.Size = new System.Drawing.Size(420, 545);
            this._panelBack.TabIndex = 0;
            // 
            // _lName
            // 
            this._lName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lName.AutoSize = true;
            this._lName.Location = new System.Drawing.Point(3, 6);
            this._lName.Name = "_lName";
            this._lName.Size = new System.Drawing.Size(35, 13);
            this._lName.TabIndex = 0;
            this._lName.Text = "Name";
            // 
            // _eName
            // 
            this._eName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eName.Location = new System.Drawing.Point(129, 3);
            this._eName.Name = "_eName";
            this._eName.Size = new System.Drawing.Size(288, 20);
            this._eName.TabIndex = 1;
            this._eName.TextChanged += new System.EventHandler(this.EditTextChangerOnlyInDatabase);
            // 
            // _lCameraType
            // 
            this._lCameraType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lCameraType.AutoSize = true;
            this._lCameraType.Location = new System.Drawing.Point(3, 31);
            this._lCameraType.Name = "_lCameraType";
            this._lCameraType.Size = new System.Drawing.Size(67, 13);
            this._lCameraType.TabIndex = 2;
            this._lCameraType.Text = "Camera type";
            // 
            // _cbCameraType
            // 
            this._cbCameraType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cbCameraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCameraType.Location = new System.Drawing.Point(129, 28);
            this._cbCameraType.Name = "_cbCameraType";
            this._cbCameraType.Size = new System.Drawing.Size(288, 21);
            this._cbCameraType.TabIndex = 3;
            // 
            // _lDCU
            // 
            this._lDCU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lDCU.AutoSize = true;
            this._lDCU.Location = new System.Drawing.Point(3, 56);
            this._lDCU.Name = "_lDCU";
            this._lDCU.Size = new System.Drawing.Size(31, 13);
            this._lDCU.TabIndex = 4;
            this._lDCU.Text = "DCU";
            // 
            // _eDCU
            // 
            this._eDCU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eDCU.Location = new System.Drawing.Point(129, 53);
            this._eDCU.Name = "_eDCU";
            this._eDCU.Size = new System.Drawing.Size(288, 20);
            this._eDCU.TabIndex = 5;
            // 
            // _lCCU
            // 
            this._lCCU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lCCU.AutoSize = true;
            this._lCCU.Location = new System.Drawing.Point(3, 81);
            this._lCCU.Name = "_lCCU";
            this._lCCU.Size = new System.Drawing.Size(31, 13);
            this._lCCU.TabIndex = 6;
            this._lCCU.Text = "CCU";
            // 
            // _eCCU
            // 
            this._eCCU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eCCU.Location = new System.Drawing.Point(129, 78);
            this._eCCU.Name = "_eCCU";
            this._eCCU.Size = new System.Drawing.Size(288, 20);
            this._eCCU.TabIndex = 7;
            // 
            // _lIpAddress
            // 
            this._lIpAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lIpAddress.AutoSize = true;
            this._lIpAddress.Location = new System.Drawing.Point(3, 106);
            this._lIpAddress.Name = "_lIpAddress";
            this._lIpAddress.Size = new System.Drawing.Size(58, 13);
            this._lIpAddress.TabIndex = 8;
            this._lIpAddress.Text = "Ip address";
            // 
            // _eIpAddress
            // 
            this._eIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eIpAddress.Location = new System.Drawing.Point(129, 103);
            this._eIpAddress.Name = "_eIpAddress";
            this._eIpAddress.Size = new System.Drawing.Size(288, 20);
            this._eIpAddress.TabIndex = 9;
            // 
            // _lPort
            // 
            this._lPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lPort.AutoSize = true;
            this._lPort.Location = new System.Drawing.Point(3, 131);
            this._lPort.Name = "_lPort";
            this._lPort.Size = new System.Drawing.Size(26, 13);
            this._lPort.TabIndex = 10;
            this._lPort.Text = "Port";
            // 
            // _nudPort
            // 
            this._nudPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._nudPort.Location = new System.Drawing.Point(129, 128);
            this._nudPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            this._nudPort.Name = "_nudPort";
            this._nudPort.Size = new System.Drawing.Size(288, 20);
            this._nudPort.TabIndex = 11;
            //
            // _lUniqueKey
            //
            this._lUniqueKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lUniqueKey.AutoSize = true;
            this._lUniqueKey.Location = new System.Drawing.Point(3, 156);
            this._lUniqueKey.Name = "_lUniqueKey";
            this._lUniqueKey.Size = new System.Drawing.Size(63, 13);
            this._lUniqueKey.TabIndex = 12;
            this._lUniqueKey.Text = "Unique key";
            //
            // _eUniqueKey
            //
            this._eUniqueKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eUniqueKey.Location = new System.Drawing.Point(129, 153);
            this._eUniqueKey.Name = "_eUniqueKey";
            this._eUniqueKey.Size = new System.Drawing.Size(288, 20);
            this._eUniqueKey.TabIndex = 13;
            //
            // _lInterfaceSource
            //
            this._lInterfaceSource.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lInterfaceSource.AutoSize = true;
            this._lInterfaceSource.Location = new System.Drawing.Point(3, 181);
            this._lInterfaceSource.Name = "_lInterfaceSource";
            this._lInterfaceSource.Size = new System.Drawing.Size(85, 13);
            this._lInterfaceSource.TabIndex = 14;
            this._lInterfaceSource.Text = "Interface source";
            //
            // _eInterfaceSource
            //
            this._eInterfaceSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eInterfaceSource.Location = new System.Drawing.Point(129, 178);
            this._eInterfaceSource.Name = "_eInterfaceSource";
            this._eInterfaceSource.Size = new System.Drawing.Size(288, 20);
            this._eInterfaceSource.TabIndex = 15;
            //
            // _lPortSsl
            //
            this._lPortSsl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lPortSsl.AutoSize = true;
            this._lPortSsl.Location = new System.Drawing.Point(3, 206);
            this._lPortSsl.Name = "_lPortSsl";
            this._lPortSsl.Size = new System.Drawing.Size(47, 13);
            this._lPortSsl.TabIndex = 16;
            this._lPortSsl.Text = "Port SSL";
            //
            // _nudPortSsl
            //
            this._nudPortSsl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._nudPortSsl.Location = new System.Drawing.Point(129, 203);
            this._nudPortSsl.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            this._nudPortSsl.Name = "_nudPortSsl";
            this._nudPortSsl.Size = new System.Drawing.Size(288, 20);
            this._nudPortSsl.TabIndex = 17;
            //
            // _lEquipment
            //
            this._lEquipment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lEquipment.AutoSize = true;
            this._lEquipment.Location = new System.Drawing.Point(3, 231);
            this._lEquipment.Name = "_lEquipment";
            this._lEquipment.Size = new System.Drawing.Size(58, 13);
            this._lEquipment.TabIndex = 18;
            this._lEquipment.Text = "Equipment";
            //
            // _eEquipment
            //
            this._eEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eEquipment.Location = new System.Drawing.Point(129, 228);
            this._eEquipment.Name = "_eEquipment";
            this._eEquipment.Size = new System.Drawing.Size(288, 20);
            this._eEquipment.TabIndex = 19;
            //
            // _lLocked
            //
            this._lLocked.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lLocked.AutoSize = true;
            this._lLocked.Location = new System.Drawing.Point(3, 256);
            this._lLocked.Name = "_lLocked";
            this._lLocked.Size = new System.Drawing.Size(43, 13);
            this._lLocked.TabIndex = 20;
            this._lLocked.Text = "Locked";
            //
            // _chkLocked
            //
            this._chkLocked.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._chkLocked.AutoSize = true;
            this._chkLocked.Location = new System.Drawing.Point(129, 256);
            this._chkLocked.Name = "_chkLocked";
            this._chkLocked.Size = new System.Drawing.Size(15, 14);
            this._chkLocked.TabIndex = 21;
            this._chkLocked.UseVisualStyleBackColor = true;
            //
            // _lLockingClientIp
            //
            this._lLockingClientIp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lLockingClientIp.AutoSize = true;
            this._lLockingClientIp.Location = new System.Drawing.Point(3, 281);
            this._lLockingClientIp.Name = "_lLockingClientIp";
            this._lLockingClientIp.Size = new System.Drawing.Size(90, 13);
            this._lLockingClientIp.TabIndex = 22;
            this._lLockingClientIp.Text = "Locking client IP";
            //
            // _eLockingClientIp
            //
            this._eLockingClientIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eLockingClientIp.Location = new System.Drawing.Point(129, 278);
            this._eLockingClientIp.Name = "_eLockingClientIp";
            this._eLockingClientIp.Size = new System.Drawing.Size(288, 20);
            this._eLockingClientIp.TabIndex = 23;
            //
            // _lMacAddress
            //
            this._lMacAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lMacAddress.AutoSize = true;
            this._lMacAddress.Location = new System.Drawing.Point(3, 306);
            this._lMacAddress.Name = "_lMacAddress";
            this._lMacAddress.Size = new System.Drawing.Size(69, 13);
            this._lMacAddress.TabIndex = 24;
            this._lMacAddress.Text = "Mac address";
            //
            // _eMacAddress
            //
            this._eMacAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eMacAddress.Location = new System.Drawing.Point(129, 303);
            this._eMacAddress.Name = "_eMacAddress";
            this._eMacAddress.Size = new System.Drawing.Size(288, 20);
            this._eMacAddress.TabIndex = 25;
            //
            // _lSerial
            //
            this._lSerial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lSerial.AutoSize = true;
            this._lSerial.Location = new System.Drawing.Point(3, 331);
            this._lSerial.Name = "_lSerial";
            this._lSerial.Size = new System.Drawing.Size(34, 13);
            this._lSerial.TabIndex = 26;
            this._lSerial.Text = "Serial";
            //
            // _eSerial
            //
            this._eSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eSerial.Location = new System.Drawing.Point(129, 328);
            this._eSerial.Name = "_eSerial";
            this._eSerial.Size = new System.Drawing.Size(288, 20);
            this._eSerial.TabIndex = 27;
            //
            // _lModel
            //
            this._lModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lModel.AutoSize = true;
            this._lModel.Location = new System.Drawing.Point(3, 356);
            this._lModel.Name = "_lModel";
            this._lModel.Size = new System.Drawing.Size(36, 13);
            this._lModel.TabIndex = 28;
            this._lModel.Text = "Model";
            //
            // _eModel
            //
            this._eModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eModel.Location = new System.Drawing.Point(129, 353);
            this._eModel.Name = "_eModel";
            this._eModel.Size = new System.Drawing.Size(288, 20);
            this._eModel.TabIndex = 29;
            //
            // _lType
            //
            this._lType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lType.AutoSize = true;
            this._lType.Location = new System.Drawing.Point(3, 381);
            this._lType.Name = "_lType";
            this._lType.Size = new System.Drawing.Size(31, 13);
            this._lType.TabIndex = 30;
            this._lType.Text = "Type";
            //
            // _eType
            //
            this._eType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eType.Location = new System.Drawing.Point(129, 378);
            this._eType.Name = "_eType";
            this._eType.Size = new System.Drawing.Size(288, 20);
            this._eType.TabIndex = 31;
            //
            // _lBuild
            //
            this._lBuild.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lBuild.AutoSize = true;
            this._lBuild.Location = new System.Drawing.Point(3, 406);
            this._lBuild.Name = "_lBuild";
            this._lBuild.Size = new System.Drawing.Size(31, 13);
            this._lBuild.TabIndex = 32;
            this._lBuild.Text = "Build";
            //
            // _eBuild
            //
            this._eBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eBuild.Location = new System.Drawing.Point(129, 403);
            this._eBuild.Name = "_eBuild";
            this._eBuild.Size = new System.Drawing.Size(288, 20);
            this._eBuild.TabIndex = 33;
            //
            // 
            // _lDescription
            // 
            this._lDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lDescription.AutoSize = true;
            this._lDescription.Location = new System.Drawing.Point(3, 431);
            this._lDescription.Name = "_lDescription";
            this._lDescription.Size = new System.Drawing.Size(60, 13);
            this._lDescription.TabIndex = 34;
            this._lDescription.Text = "Description";
            // 
            // _eDescription
            // 
            this._eDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eDescription.Location = new System.Drawing.Point(129, 428);
            this._eDescription.Multiline = true;
            this._eDescription.Name = "_eDescription";
            this._eDescription.Size = new System.Drawing.Size(288, 54);
            this._eDescription.TabIndex = 35;
            // 
            // _lAlarmArcs
            // 
            this._lAlarmArcs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lAlarmArcs.AutoSize = true;
            this._lAlarmArcs.Location = new System.Drawing.Point(3, 493);
            this._lAlarmArcs.Name = "_lAlarmArcs";
            this._lAlarmArcs.Size = new System.Drawing.Size(58, 13);
            this._lAlarmArcs.TabIndex = 36;
            this._lAlarmArcs.Text = "Alarm arcs";
            // 
            // _cmaaAlarmArcs
            // 
            this._cmaaAlarmArcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cmaaAlarmArcs.Location = new System.Drawing.Point(129, 488);
            this._cmaaAlarmArcs.Name = "_cmaaAlarmArcs";
            this._cmaaAlarmArcs.Size = new System.Drawing.Size(288, 54);
            this._cmaaAlarmArcs.TabIndex = 37;
            // 
            // _bOk
            // 
            this._bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bOk.Location = new System.Drawing.Point(276, 563);
            this._bOk.Name = "_bOk";
            this._bOk.Size = new System.Drawing.Size(75, 23);
            this._bOk.TabIndex = 1;
            this._bOk.Text = "OK";
            this._bOk.UseVisualStyleBackColor = true;
            this._bOk.Click += new System.EventHandler(this._bOk_Click);
            // 
            // _bCancel
            // 
            this._bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bCancel.Location = new System.Drawing.Point(357, 563);
            this._bCancel.Name = "_bCancel";
            this._bCancel.Size = new System.Drawing.Size(75, 23);
            this._bCancel.TabIndex = 2;
            this._bCancel.Text = "Cancel";
            this._bCancel.UseVisualStyleBackColor = true;
            this._bCancel.Click += new System.EventHandler(this._bCancel_Click);
            // 
            // NCASCarReaderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 598);
            this.Controls.Add(this._bCancel);
            this.Controls.Add(this._bOk);
            this.Controls.Add(this._panelBack);
            this.Name = "NCASCarReaderEditForm";
            this.Text = "NCASCarReaderEditForm";
            this._panelBack.ResumeLayout(false);
            this._panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudPortSsl)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
