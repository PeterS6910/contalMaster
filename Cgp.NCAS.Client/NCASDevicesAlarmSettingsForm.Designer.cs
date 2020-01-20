namespace Contal.Cgp.NCAS.Client
{
    partial class NCASDevicesAlarmSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCASDevicesAlarmSettingsForm));
            this._bSave = new System.Windows.Forms.Button();
            this._bClose = new System.Windows.Forms.Button();
            this._tcDevicesAlarmSetting = new System.Windows.Forms.TabControl();
            this._tpAlarmAreaAlarms = new System.Windows.Forms.TabPage();
            this._accordionAlarmAreaAlarms = new Contal.IwQuick.PlatformPC.UI.Accordion.Accordion();
            this._chbAlarmAreaReportingToCRs = new System.Windows.Forms.CheckBox();
            this._tpCcuAlarms = new System.Windows.Forms.TabPage();
            this._cbOpenAllCcuAlarms = new System.Windows.Forms.CheckBox();
            this._accordionCcuAlarms = new Contal.IwQuick.PlatformPC.UI.Accordion.Accordion();
            this._tpDcuAlarms = new System.Windows.Forms.TabPage();
            this._cbOpenAllDcuAlarms = new System.Windows.Forms.CheckBox();
            this._accordionDcuAlarms = new Contal.IwQuick.PlatformPC.UI.Accordion.Accordion();
            this._tpDoorEnvironmentAlarms = new System.Windows.Forms.TabPage();
            this._cbOpenAllDsmAlarms = new System.Windows.Forms.CheckBox();
            this._accordionDsmAlarms = new Contal.IwQuick.PlatformPC.UI.Accordion.Accordion();
            this._tpCrAlarms = new System.Windows.Forms.TabPage();
            this._gbSlForEnterToMenu = new System.Windows.Forms.GroupBox();
            this._lGin2 = new System.Windows.Forms.Label();
            this._lSecurityDailyPlanTimeZone = new System.Windows.Forms.Label();
            this._eGinForEnterToMenu = new System.Windows.Forms.TextBox();
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu = new Contal.IwQuick.UI.TextBoxMenu();
            this._tsiModify = new System.Windows.Forms.ToolStripMenuItem();
            this._tsiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this._tsiCreateSecTimeZone = new System.Windows.Forms.ToolStripMenuItem();
            this._tsiCreateSecDailyPlan = new System.Windows.Forms.ToolStripMenuItem();
            this._cbSlForEnterToMenu = new System.Windows.Forms.ComboBox();
            this._lSecurityLevel = new System.Windows.Forms.Label();
            this._cbOpenAllCrAlarms = new System.Windows.Forms.CheckBox();
            this._accordionCrAlarms = new Contal.IwQuick.PlatformPC.UI.Accordion.Accordion();
            this._tpInvalidPinGinRetriesLimits = new System.Windows.Forms.TabPage();
            this._gbInvalidGinRetriesLimit = new System.Windows.Forms.GroupBox();
            this._lInvalidGinRetriesLimitReachedTimeout = new System.Windows.Forms.Label();
            this._eInvalidGinRetriesLimitReachedTimeout = new System.Windows.Forms.NumericUpDown();
            this._lInvalidGinRetriesCount = new System.Windows.Forms.Label();
            this._eInvalidGinRetriesCount = new System.Windows.Forms.NumericUpDown();
            this._chbInvalidGinRetriesLimitEnabled = new System.Windows.Forms.CheckBox();
            this._gbInvalidPinRetriesLimit = new System.Windows.Forms.GroupBox();
            this._lInvalidPinRetriesLimitReachedTimeout = new System.Windows.Forms.Label();
            this._eInvalidPinRetriesLimitReachedTimeout = new System.Windows.Forms.NumericUpDown();
            this._lInvalidPinRetriesCount = new System.Windows.Forms.Label();
            this._eInvalidPinRetriesCount = new System.Windows.Forms.NumericUpDown();
            this._chbInvalidPinRetriesLimitEnabled = new System.Windows.Forms.CheckBox();
            this._tpPersons = new System.Windows.Forms.TabPage();
            this.buttonPersonsUnselectAll = new System.Windows.Forms.Button();
            this.buttonPersonsSelectAll = new System.Windows.Forms.Button();
            this._bApply = new System.Windows.Forms.Button();
            this.checkedListBoxPersons = new System.Windows.Forms.CheckedListBox();
            this._tcDevicesAlarmSetting.SuspendLayout();
            this._tpAlarmAreaAlarms.SuspendLayout();
            this._tpCcuAlarms.SuspendLayout();
            this._tpDcuAlarms.SuspendLayout();
            this._tpDoorEnvironmentAlarms.SuspendLayout();
            this._tpCrAlarms.SuspendLayout();
            this._gbSlForEnterToMenu.SuspendLayout();
            this._tpInvalidPinGinRetriesLimits.SuspendLayout();
            this._gbInvalidGinRetriesLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._eInvalidGinRetriesLimitReachedTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._eInvalidGinRetriesCount)).BeginInit();
            this._gbInvalidPinRetriesLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._eInvalidPinRetriesLimitReachedTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._eInvalidPinRetriesCount)).BeginInit();
            this._tpPersons.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bSave
            // 
            this._bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bSave.Location = new System.Drawing.Point(771, 386);
            this._bSave.Name = "_bSave";
            this._bSave.Size = new System.Drawing.Size(75, 23);
            this._bSave.TabIndex = 101;
            this._bSave.Text = "Save";
            this._bSave.UseVisualStyleBackColor = true;
            this._bSave.Click += new System.EventHandler(this._bSave_Click);
            // 
            // _bClose
            // 
            this._bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bClose.Location = new System.Drawing.Point(852, 386);
            this._bClose.Name = "_bClose";
            this._bClose.Size = new System.Drawing.Size(75, 23);
            this._bClose.TabIndex = 102;
            this._bClose.Text = "Close";
            this._bClose.UseVisualStyleBackColor = true;
            this._bClose.Click += new System.EventHandler(this._bClose_Click);
            // 
            // _tcDevicesAlarmSetting
            // 
            this._tcDevicesAlarmSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tcDevicesAlarmSetting.Controls.Add(this._tpAlarmAreaAlarms);
            this._tcDevicesAlarmSetting.Controls.Add(this._tpCcuAlarms);
            this._tcDevicesAlarmSetting.Controls.Add(this._tpDcuAlarms);
            this._tcDevicesAlarmSetting.Controls.Add(this._tpDoorEnvironmentAlarms);
            this._tcDevicesAlarmSetting.Controls.Add(this._tpCrAlarms);
            this._tcDevicesAlarmSetting.Controls.Add(this._tpInvalidPinGinRetriesLimits);
            this._tcDevicesAlarmSetting.Controls.Add(this._tpPersons);
            this._tcDevicesAlarmSetting.Location = new System.Drawing.Point(12, 12);
            this._tcDevicesAlarmSetting.Name = "_tcDevicesAlarmSetting";
            this._tcDevicesAlarmSetting.SelectedIndex = 0;
            this._tcDevicesAlarmSetting.Size = new System.Drawing.Size(915, 368);
            this._tcDevicesAlarmSetting.TabIndex = 0;
            // 
            // _tpAlarmAreaAlarms
            // 
            this._tpAlarmAreaAlarms.AutoScroll = true;
            this._tpAlarmAreaAlarms.AutoScrollMinSize = new System.Drawing.Size(907, 0);
            this._tpAlarmAreaAlarms.Controls.Add(this._accordionAlarmAreaAlarms);
            this._tpAlarmAreaAlarms.Controls.Add(this._chbAlarmAreaReportingToCRs);
            this._tpAlarmAreaAlarms.Location = new System.Drawing.Point(4, 22);
            this._tpAlarmAreaAlarms.Name = "_tpAlarmAreaAlarms";
            this._tpAlarmAreaAlarms.Size = new System.Drawing.Size(907, 342);
            this._tpAlarmAreaAlarms.TabIndex = 3;
            this._tpAlarmAreaAlarms.Text = "Alarm area alarms";
            // 
            // _accordionAlarmAreaAlarms
            // 
            this._accordionAlarmAreaAlarms.AddResizeBars = true;
            this._accordionAlarmAreaAlarms.AllowMouseResize = true;
            this._accordionAlarmAreaAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._accordionAlarmAreaAlarms.AnimateCloseEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Hide;
            this._accordionAlarmAreaAlarms.AnimateCloseMillis = 150;
            this._accordionAlarmAreaAlarms.AnimateOpenEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Show;
            this._accordionAlarmAreaAlarms.AnimateOpenMillis = 150;
            this._accordionAlarmAreaAlarms.AutoFixDockStyle = false;
            this._accordionAlarmAreaAlarms.AutoScroll = true;
            this._accordionAlarmAreaAlarms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._accordionAlarmAreaAlarms.CheckBoxFactory = null;
            this._accordionAlarmAreaAlarms.CheckBoxMargin = new System.Windows.Forms.Padding(0);
            this._accordionAlarmAreaAlarms.ContentBackColor = null;
            this._accordionAlarmAreaAlarms.ContentMargin = null;
            this._accordionAlarmAreaAlarms.ContentPadding = new System.Windows.Forms.Padding(5);
            this._accordionAlarmAreaAlarms.ControlBackColor = null;
            this._accordionAlarmAreaAlarms.ControlMinimumHeightIsItsPreferredHeight = false;
            this._accordionAlarmAreaAlarms.ControlMinimumWidthIsItsPreferredWidth = false;
            this._accordionAlarmAreaAlarms.DownArrow = null;
            this._accordionAlarmAreaAlarms.FillHeight = true;
            this._accordionAlarmAreaAlarms.FillLastOpened = false;
            this._accordionAlarmAreaAlarms.FillModeGrowOnly = false;
            this._accordionAlarmAreaAlarms.FillResetOnCollapse = false;
            this._accordionAlarmAreaAlarms.FillWidth = true;
            this._accordionAlarmAreaAlarms.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this._accordionAlarmAreaAlarms.GrabRequiresPositiveFillWeight = true;
            this._accordionAlarmAreaAlarms.GrabWidth = 6;
            this._accordionAlarmAreaAlarms.GrowAndShrink = true;
            this._accordionAlarmAreaAlarms.Insets = new System.Windows.Forms.Padding(0);
            this._accordionAlarmAreaAlarms.Location = new System.Drawing.Point(4, 27);
            this._accordionAlarmAreaAlarms.Name = "_accordionAlarmAreaAlarms";
            this._accordionAlarmAreaAlarms.OpenOnAdd = false;
            this._accordionAlarmAreaAlarms.OpenOneOnly = false;
            this._accordionAlarmAreaAlarms.ResizeBarFactory = null;
            this._accordionAlarmAreaAlarms.ResizeBarsAlign = 0.5D;
            this._accordionAlarmAreaAlarms.ResizeBarsArrowKeyDelta = 10;
            this._accordionAlarmAreaAlarms.ResizeBarsFadeInMillis = 800;
            this._accordionAlarmAreaAlarms.ResizeBarsFadeOutMillis = 800;
            this._accordionAlarmAreaAlarms.ResizeBarsFadeProximity = 24;
            this._accordionAlarmAreaAlarms.ResizeBarsFill = 1D;
            this._accordionAlarmAreaAlarms.ResizeBarsKeepFocusAfterMouseDrag = false;
            this._accordionAlarmAreaAlarms.ResizeBarsKeepFocusIfControlOutOfView = true;
            this._accordionAlarmAreaAlarms.ResizeBarsKeepFocusOnClick = true;
            this._accordionAlarmAreaAlarms.ResizeBarsMargin = null;
            this._accordionAlarmAreaAlarms.ResizeBarsMinimumLength = 50;
            this._accordionAlarmAreaAlarms.ResizeBarsStayInViewOnArrowKey = true;
            this._accordionAlarmAreaAlarms.ResizeBarsStayInViewOnMouseDrag = true;
            this._accordionAlarmAreaAlarms.ResizeBarsStayVisibleIfFocused = true;
            this._accordionAlarmAreaAlarms.ResizeBarsTabStop = true;
            this._accordionAlarmAreaAlarms.ShowPartiallyVisibleResizeBars = false;
            this._accordionAlarmAreaAlarms.ShowToolMenu = true;
            this._accordionAlarmAreaAlarms.ShowToolMenuOnHoverWhenClosed = false;
            this._accordionAlarmAreaAlarms.ShowToolMenuOnRightClick = true;
            this._accordionAlarmAreaAlarms.ShowToolMenuRequiresPositiveFillWeight = false;
            this._accordionAlarmAreaAlarms.Size = new System.Drawing.Size(901, 312);
            this._accordionAlarmAreaAlarms.TabIndex = 9;
            this._accordionAlarmAreaAlarms.UpArrow = null;
            // 
            // _chbAlarmAreaReportingToCRs
            // 
            this._chbAlarmAreaReportingToCRs.AutoSize = true;
            this._chbAlarmAreaReportingToCRs.Checked = true;
            this._chbAlarmAreaReportingToCRs.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chbAlarmAreaReportingToCRs.Location = new System.Drawing.Point(4, 4);
            this._chbAlarmAreaReportingToCRs.Name = "_chbAlarmAreaReportingToCRs";
            this._chbAlarmAreaReportingToCRs.Size = new System.Drawing.Size(265, 17);
            this._chbAlarmAreaReportingToCRs.TabIndex = 0;
            this._chbAlarmAreaReportingToCRs.Text = "Allow alarm area state reporting on it\'s card readers";
            this._chbAlarmAreaReportingToCRs.UseVisualStyleBackColor = true;
            this._chbAlarmAreaReportingToCRs.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // _tpCcuAlarms
            // 
            this._tpCcuAlarms.AutoScroll = true;
            this._tpCcuAlarms.AutoScrollMinSize = new System.Drawing.Size(907, 0);
            this._tpCcuAlarms.BackColor = System.Drawing.SystemColors.Control;
            this._tpCcuAlarms.Controls.Add(this._cbOpenAllCcuAlarms);
            this._tpCcuAlarms.Controls.Add(this._accordionCcuAlarms);
            this._tpCcuAlarms.Location = new System.Drawing.Point(4, 22);
            this._tpCcuAlarms.Name = "_tpCcuAlarms";
            this._tpCcuAlarms.Padding = new System.Windows.Forms.Padding(3);
            this._tpCcuAlarms.Size = new System.Drawing.Size(907, 342);
            this._tpCcuAlarms.TabIndex = 0;
            this._tpCcuAlarms.Text = "CCU alarms";
            // 
            // _cbOpenAllCcuAlarms
            // 
            this._cbOpenAllCcuAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbOpenAllCcuAlarms.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbOpenAllCcuAlarms.Location = new System.Drawing.Point(701, 6);
            this._cbOpenAllCcuAlarms.Name = "_cbOpenAllCcuAlarms";
            this._cbOpenAllCcuAlarms.Size = new System.Drawing.Size(200, 17);
            this._cbOpenAllCcuAlarms.TabIndex = 3;
            this._cbOpenAllCcuAlarms.Text = "Open all";
            this._cbOpenAllCcuAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbOpenAllCcuAlarms.UseVisualStyleBackColor = true;
            this._cbOpenAllCcuAlarms.CheckStateChanged += new System.EventHandler(this._cbOpenAllCcuAlarms_CheckStateChanged);
            // 
            // _accordionCcuAlarms
            // 
            this._accordionCcuAlarms.AddResizeBars = true;
            this._accordionCcuAlarms.AllowMouseResize = true;
            this._accordionCcuAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._accordionCcuAlarms.AnimateCloseEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Hide;
            this._accordionCcuAlarms.AnimateCloseMillis = 150;
            this._accordionCcuAlarms.AnimateOpenEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Show;
            this._accordionCcuAlarms.AnimateOpenMillis = 150;
            this._accordionCcuAlarms.AutoFixDockStyle = false;
            this._accordionCcuAlarms.AutoScroll = true;
            this._accordionCcuAlarms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._accordionCcuAlarms.CheckBoxFactory = null;
            this._accordionCcuAlarms.CheckBoxMargin = new System.Windows.Forms.Padding(0);
            this._accordionCcuAlarms.ContentBackColor = null;
            this._accordionCcuAlarms.ContentMargin = null;
            this._accordionCcuAlarms.ContentPadding = new System.Windows.Forms.Padding(5);
            this._accordionCcuAlarms.ControlBackColor = null;
            this._accordionCcuAlarms.ControlMinimumHeightIsItsPreferredHeight = false;
            this._accordionCcuAlarms.ControlMinimumWidthIsItsPreferredWidth = false;
            this._accordionCcuAlarms.DownArrow = null;
            this._accordionCcuAlarms.FillHeight = true;
            this._accordionCcuAlarms.FillLastOpened = false;
            this._accordionCcuAlarms.FillModeGrowOnly = false;
            this._accordionCcuAlarms.FillResetOnCollapse = false;
            this._accordionCcuAlarms.FillWidth = true;
            this._accordionCcuAlarms.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this._accordionCcuAlarms.GrabRequiresPositiveFillWeight = true;
            this._accordionCcuAlarms.GrabWidth = 6;
            this._accordionCcuAlarms.GrowAndShrink = true;
            this._accordionCcuAlarms.Insets = new System.Windows.Forms.Padding(0);
            this._accordionCcuAlarms.Location = new System.Drawing.Point(3, 29);
            this._accordionCcuAlarms.Name = "_accordionCcuAlarms";
            this._accordionCcuAlarms.OpenOnAdd = false;
            this._accordionCcuAlarms.OpenOneOnly = false;
            this._accordionCcuAlarms.ResizeBarFactory = null;
            this._accordionCcuAlarms.ResizeBarsAlign = 0.5D;
            this._accordionCcuAlarms.ResizeBarsArrowKeyDelta = 10;
            this._accordionCcuAlarms.ResizeBarsFadeInMillis = 800;
            this._accordionCcuAlarms.ResizeBarsFadeOutMillis = 800;
            this._accordionCcuAlarms.ResizeBarsFadeProximity = 24;
            this._accordionCcuAlarms.ResizeBarsFill = 1D;
            this._accordionCcuAlarms.ResizeBarsKeepFocusAfterMouseDrag = false;
            this._accordionCcuAlarms.ResizeBarsKeepFocusIfControlOutOfView = true;
            this._accordionCcuAlarms.ResizeBarsKeepFocusOnClick = true;
            this._accordionCcuAlarms.ResizeBarsMargin = null;
            this._accordionCcuAlarms.ResizeBarsMinimumLength = 50;
            this._accordionCcuAlarms.ResizeBarsStayInViewOnArrowKey = true;
            this._accordionCcuAlarms.ResizeBarsStayInViewOnMouseDrag = true;
            this._accordionCcuAlarms.ResizeBarsStayVisibleIfFocused = true;
            this._accordionCcuAlarms.ResizeBarsTabStop = true;
            this._accordionCcuAlarms.ShowPartiallyVisibleResizeBars = false;
            this._accordionCcuAlarms.ShowToolMenu = true;
            this._accordionCcuAlarms.ShowToolMenuOnHoverWhenClosed = false;
            this._accordionCcuAlarms.ShowToolMenuOnRightClick = true;
            this._accordionCcuAlarms.ShowToolMenuRequiresPositiveFillWeight = false;
            this._accordionCcuAlarms.Size = new System.Drawing.Size(901, 310);
            this._accordionCcuAlarms.TabIndex = 2;
            this._accordionCcuAlarms.UpArrow = null;
            // 
            // _tpDcuAlarms
            // 
            this._tpDcuAlarms.AutoScroll = true;
            this._tpDcuAlarms.AutoScrollMinSize = new System.Drawing.Size(907, 0);
            this._tpDcuAlarms.BackColor = System.Drawing.SystemColors.Control;
            this._tpDcuAlarms.Controls.Add(this._cbOpenAllDcuAlarms);
            this._tpDcuAlarms.Controls.Add(this._accordionDcuAlarms);
            this._tpDcuAlarms.Location = new System.Drawing.Point(4, 22);
            this._tpDcuAlarms.Name = "_tpDcuAlarms";
            this._tpDcuAlarms.Padding = new System.Windows.Forms.Padding(3);
            this._tpDcuAlarms.Size = new System.Drawing.Size(907, 342);
            this._tpDcuAlarms.TabIndex = 1;
            this._tpDcuAlarms.Text = "DCUs alarms";
            // 
            // _cbOpenAllDcuAlarms
            // 
            this._cbOpenAllDcuAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbOpenAllDcuAlarms.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbOpenAllDcuAlarms.Location = new System.Drawing.Point(701, 6);
            this._cbOpenAllDcuAlarms.Name = "_cbOpenAllDcuAlarms";
            this._cbOpenAllDcuAlarms.Size = new System.Drawing.Size(200, 17);
            this._cbOpenAllDcuAlarms.TabIndex = 1;
            this._cbOpenAllDcuAlarms.Text = "Open all";
            this._cbOpenAllDcuAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbOpenAllDcuAlarms.UseVisualStyleBackColor = true;
            this._cbOpenAllDcuAlarms.CheckStateChanged += new System.EventHandler(this._cbOpenAllDcuAlarms_CheckStateChanged);
            // 
            // _accordionDcuAlarms
            // 
            this._accordionDcuAlarms.AddResizeBars = true;
            this._accordionDcuAlarms.AllowMouseResize = true;
            this._accordionDcuAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._accordionDcuAlarms.AnimateCloseEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Hide;
            this._accordionDcuAlarms.AnimateCloseMillis = 150;
            this._accordionDcuAlarms.AnimateOpenEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Show;
            this._accordionDcuAlarms.AnimateOpenMillis = 150;
            this._accordionDcuAlarms.AutoFixDockStyle = false;
            this._accordionDcuAlarms.AutoScroll = true;
            this._accordionDcuAlarms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._accordionDcuAlarms.CheckBoxFactory = null;
            this._accordionDcuAlarms.CheckBoxMargin = new System.Windows.Forms.Padding(0);
            this._accordionDcuAlarms.ContentBackColor = null;
            this._accordionDcuAlarms.ContentMargin = null;
            this._accordionDcuAlarms.ContentPadding = new System.Windows.Forms.Padding(5);
            this._accordionDcuAlarms.ControlBackColor = null;
            this._accordionDcuAlarms.ControlMinimumHeightIsItsPreferredHeight = false;
            this._accordionDcuAlarms.ControlMinimumWidthIsItsPreferredWidth = false;
            this._accordionDcuAlarms.DownArrow = null;
            this._accordionDcuAlarms.FillHeight = true;
            this._accordionDcuAlarms.FillLastOpened = false;
            this._accordionDcuAlarms.FillModeGrowOnly = false;
            this._accordionDcuAlarms.FillResetOnCollapse = false;
            this._accordionDcuAlarms.FillWidth = true;
            this._accordionDcuAlarms.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this._accordionDcuAlarms.GrabRequiresPositiveFillWeight = true;
            this._accordionDcuAlarms.GrabWidth = 6;
            this._accordionDcuAlarms.GrowAndShrink = true;
            this._accordionDcuAlarms.Insets = new System.Windows.Forms.Padding(0);
            this._accordionDcuAlarms.Location = new System.Drawing.Point(3, 29);
            this._accordionDcuAlarms.Name = "_accordionDcuAlarms";
            this._accordionDcuAlarms.OpenOnAdd = false;
            this._accordionDcuAlarms.OpenOneOnly = false;
            this._accordionDcuAlarms.ResizeBarFactory = null;
            this._accordionDcuAlarms.ResizeBarsAlign = 0.5D;
            this._accordionDcuAlarms.ResizeBarsArrowKeyDelta = 10;
            this._accordionDcuAlarms.ResizeBarsFadeInMillis = 800;
            this._accordionDcuAlarms.ResizeBarsFadeOutMillis = 800;
            this._accordionDcuAlarms.ResizeBarsFadeProximity = 24;
            this._accordionDcuAlarms.ResizeBarsFill = 1D;
            this._accordionDcuAlarms.ResizeBarsKeepFocusAfterMouseDrag = false;
            this._accordionDcuAlarms.ResizeBarsKeepFocusIfControlOutOfView = true;
            this._accordionDcuAlarms.ResizeBarsKeepFocusOnClick = true;
            this._accordionDcuAlarms.ResizeBarsMargin = null;
            this._accordionDcuAlarms.ResizeBarsMinimumLength = 50;
            this._accordionDcuAlarms.ResizeBarsStayInViewOnArrowKey = true;
            this._accordionDcuAlarms.ResizeBarsStayInViewOnMouseDrag = true;
            this._accordionDcuAlarms.ResizeBarsStayVisibleIfFocused = true;
            this._accordionDcuAlarms.ResizeBarsTabStop = true;
            this._accordionDcuAlarms.ShowPartiallyVisibleResizeBars = false;
            this._accordionDcuAlarms.ShowToolMenu = true;
            this._accordionDcuAlarms.ShowToolMenuOnHoverWhenClosed = false;
            this._accordionDcuAlarms.ShowToolMenuOnRightClick = true;
            this._accordionDcuAlarms.ShowToolMenuRequiresPositiveFillWeight = false;
            this._accordionDcuAlarms.Size = new System.Drawing.Size(901, 310);
            this._accordionDcuAlarms.TabIndex = 0;
            this._accordionDcuAlarms.UpArrow = null;
            // 
            // _tpDoorEnvironmentAlarms
            // 
            this._tpDoorEnvironmentAlarms.AutoScroll = true;
            this._tpDoorEnvironmentAlarms.AutoScrollMinSize = new System.Drawing.Size(907, 0);
            this._tpDoorEnvironmentAlarms.BackColor = System.Drawing.SystemColors.Control;
            this._tpDoorEnvironmentAlarms.Controls.Add(this._cbOpenAllDsmAlarms);
            this._tpDoorEnvironmentAlarms.Controls.Add(this._accordionDsmAlarms);
            this._tpDoorEnvironmentAlarms.Location = new System.Drawing.Point(4, 22);
            this._tpDoorEnvironmentAlarms.Name = "_tpDoorEnvironmentAlarms";
            this._tpDoorEnvironmentAlarms.Padding = new System.Windows.Forms.Padding(3);
            this._tpDoorEnvironmentAlarms.Size = new System.Drawing.Size(907, 342);
            this._tpDoorEnvironmentAlarms.TabIndex = 4;
            this._tpDoorEnvironmentAlarms.Text = "Door environment alarms";
            // 
            // _cbOpenAllDsmAlarms
            // 
            this._cbOpenAllDsmAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbOpenAllDsmAlarms.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbOpenAllDsmAlarms.Location = new System.Drawing.Point(701, 6);
            this._cbOpenAllDsmAlarms.Name = "_cbOpenAllDsmAlarms";
            this._cbOpenAllDsmAlarms.Size = new System.Drawing.Size(200, 17);
            this._cbOpenAllDsmAlarms.TabIndex = 2;
            this._cbOpenAllDsmAlarms.Text = "Open all";
            this._cbOpenAllDsmAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbOpenAllDsmAlarms.UseVisualStyleBackColor = true;
            this._cbOpenAllDsmAlarms.CheckStateChanged += new System.EventHandler(this._cbOpenAllDsmAlarms_CheckStateChanged);
            // 
            // _accordionDsmAlarms
            // 
            this._accordionDsmAlarms.AddResizeBars = true;
            this._accordionDsmAlarms.AllowMouseResize = true;
            this._accordionDsmAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._accordionDsmAlarms.AnimateCloseEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Hide;
            this._accordionDsmAlarms.AnimateCloseMillis = 150;
            this._accordionDsmAlarms.AnimateOpenEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Show;
            this._accordionDsmAlarms.AnimateOpenMillis = 150;
            this._accordionDsmAlarms.AutoFixDockStyle = false;
            this._accordionDsmAlarms.AutoScroll = true;
            this._accordionDsmAlarms.CheckBoxFactory = null;
            this._accordionDsmAlarms.CheckBoxMargin = new System.Windows.Forms.Padding(0);
            this._accordionDsmAlarms.ContentBackColor = null;
            this._accordionDsmAlarms.ContentMargin = null;
            this._accordionDsmAlarms.ContentPadding = new System.Windows.Forms.Padding(5);
            this._accordionDsmAlarms.ControlBackColor = null;
            this._accordionDsmAlarms.ControlMinimumHeightIsItsPreferredHeight = false;
            this._accordionDsmAlarms.ControlMinimumWidthIsItsPreferredWidth = false;
            this._accordionDsmAlarms.DownArrow = null;
            this._accordionDsmAlarms.FillHeight = true;
            this._accordionDsmAlarms.FillLastOpened = false;
            this._accordionDsmAlarms.FillModeGrowOnly = false;
            this._accordionDsmAlarms.FillResetOnCollapse = false;
            this._accordionDsmAlarms.FillWidth = true;
            this._accordionDsmAlarms.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this._accordionDsmAlarms.GrabRequiresPositiveFillWeight = true;
            this._accordionDsmAlarms.GrabWidth = 6;
            this._accordionDsmAlarms.GrowAndShrink = true;
            this._accordionDsmAlarms.Insets = new System.Windows.Forms.Padding(0);
            this._accordionDsmAlarms.Location = new System.Drawing.Point(3, 29);
            this._accordionDsmAlarms.Name = "_accordionDsmAlarms";
            this._accordionDsmAlarms.OpenOnAdd = false;
            this._accordionDsmAlarms.OpenOneOnly = false;
            this._accordionDsmAlarms.ResizeBarFactory = null;
            this._accordionDsmAlarms.ResizeBarsAlign = 0.5D;
            this._accordionDsmAlarms.ResizeBarsArrowKeyDelta = 10;
            this._accordionDsmAlarms.ResizeBarsFadeInMillis = 800;
            this._accordionDsmAlarms.ResizeBarsFadeOutMillis = 800;
            this._accordionDsmAlarms.ResizeBarsFadeProximity = 24;
            this._accordionDsmAlarms.ResizeBarsFill = 1D;
            this._accordionDsmAlarms.ResizeBarsKeepFocusAfterMouseDrag = false;
            this._accordionDsmAlarms.ResizeBarsKeepFocusIfControlOutOfView = true;
            this._accordionDsmAlarms.ResizeBarsKeepFocusOnClick = true;
            this._accordionDsmAlarms.ResizeBarsMargin = null;
            this._accordionDsmAlarms.ResizeBarsMinimumLength = 50;
            this._accordionDsmAlarms.ResizeBarsStayInViewOnArrowKey = true;
            this._accordionDsmAlarms.ResizeBarsStayInViewOnMouseDrag = true;
            this._accordionDsmAlarms.ResizeBarsStayVisibleIfFocused = true;
            this._accordionDsmAlarms.ResizeBarsTabStop = true;
            this._accordionDsmAlarms.ShowPartiallyVisibleResizeBars = false;
            this._accordionDsmAlarms.ShowToolMenu = true;
            this._accordionDsmAlarms.ShowToolMenuOnHoverWhenClosed = false;
            this._accordionDsmAlarms.ShowToolMenuOnRightClick = true;
            this._accordionDsmAlarms.ShowToolMenuRequiresPositiveFillWeight = false;
            this._accordionDsmAlarms.Size = new System.Drawing.Size(901, 310);
            this._accordionDsmAlarms.TabIndex = 0;
            this._accordionDsmAlarms.UpArrow = null;
            // 
            // _tpCrAlarms
            // 
            this._tpCrAlarms.AutoScroll = true;
            this._tpCrAlarms.AutoScrollMinSize = new System.Drawing.Size(907, 0);
            this._tpCrAlarms.BackColor = System.Drawing.SystemColors.Control;
            this._tpCrAlarms.Controls.Add(this._gbSlForEnterToMenu);
            this._tpCrAlarms.Controls.Add(this._cbOpenAllCrAlarms);
            this._tpCrAlarms.Controls.Add(this._accordionCrAlarms);
            this._tpCrAlarms.Location = new System.Drawing.Point(4, 22);
            this._tpCrAlarms.Name = "_tpCrAlarms";
            this._tpCrAlarms.Padding = new System.Windows.Forms.Padding(3);
            this._tpCrAlarms.Size = new System.Drawing.Size(907, 342);
            this._tpCrAlarms.TabIndex = 2;
            this._tpCrAlarms.Text = "Card readers alarms";
            // 
            // _gbSlForEnterToMenu
            // 
            this._gbSlForEnterToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gbSlForEnterToMenu.Controls.Add(this._lGin2);
            this._gbSlForEnterToMenu.Controls.Add(this._lSecurityDailyPlanTimeZone);
            this._gbSlForEnterToMenu.Controls.Add(this._eGinForEnterToMenu);
            this._gbSlForEnterToMenu.Controls.Add(this._tbmSecurityDailyPlanTimeZoneForEnterToMenu);
            this._gbSlForEnterToMenu.Controls.Add(this._cbSlForEnterToMenu);
            this._gbSlForEnterToMenu.Controls.Add(this._lSecurityLevel);
            this._gbSlForEnterToMenu.Location = new System.Drawing.Point(3, 6);
            this._gbSlForEnterToMenu.Name = "_gbSlForEnterToMenu";
            this._gbSlForEnterToMenu.Size = new System.Drawing.Size(901, 101);
            this._gbSlForEnterToMenu.TabIndex = 17;
            this._gbSlForEnterToMenu.TabStop = false;
            this._gbSlForEnterToMenu.Text = "Security level for enter to menu";
            // 
            // _lGin2
            // 
            this._lGin2.AutoSize = true;
            this._lGin2.Location = new System.Drawing.Point(6, 75);
            this._lGin2.Name = "_lGin2";
            this._lGin2.Size = new System.Drawing.Size(26, 13);
            this._lGin2.TabIndex = 16;
            this._lGin2.Text = "GIN";
            // 
            // _lSecurityDailyPlanTimeZone
            // 
            this._lSecurityDailyPlanTimeZone.AutoSize = true;
            this._lSecurityDailyPlanTimeZone.Location = new System.Drawing.Point(6, 49);
            this._lSecurityDailyPlanTimeZone.Name = "_lSecurityDailyPlanTimeZone";
            this._lSecurityDailyPlanTimeZone.Size = new System.Drawing.Size(140, 13);
            this._lSecurityDailyPlanTimeZone.TabIndex = 15;
            this._lSecurityDailyPlanTimeZone.Text = "Security daily plan time zone";
            // 
            // _eGinForEnterToMenu
            // 
            this._eGinForEnterToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._eGinForEnterToMenu.Location = new System.Drawing.Point(250, 72);
            this._eGinForEnterToMenu.Name = "_eGinForEnterToMenu";
            this._eGinForEnterToMenu.Size = new System.Drawing.Size(250, 20);
            this._eGinForEnterToMenu.TabIndex = 13;
            this._eGinForEnterToMenu.UseSystemPasswordChar = true;
            this._eGinForEnterToMenu.TextChanged += new System.EventHandler(this.ValueChanged);
            this._eGinForEnterToMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // _tbmSecurityDailyPlanTimeZoneForEnterToMenu
            // 
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.AllowDrop = true;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.BackColor = System.Drawing.SystemColors.Control;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.Image = ((System.Drawing.Image)(resources.GetObject("_tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.Image")));
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.Location = new System.Drawing.Point(230, 0);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.Name = "_bMenu";
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.Size = new System.Drawing.Size(20, 20);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.TabIndex = 3;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Button.UseVisualStyleBackColor = false;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonBaseColor = System.Drawing.SystemColors.Control;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonDefaultBehaviour = true;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonHoverColor = System.Drawing.Color.Empty;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonImage = ((System.Drawing.Image)(resources.GetObject("_tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonImage")));
            // 
            // 
            // 
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonPopupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsiModify,
            this._tsiRemove,
            this._tsiCreateSecTimeZone,
            this._tsiCreateSecDailyPlan});
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonPopupMenu.Name = "";
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonPopupMenu.Size = new System.Drawing.Size(187, 92);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonPosition = Contal.IwQuick.UI.MenuPosition.Right;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonShowImage = true;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonSizeHeight = 20;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonSizeWidth = 20;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonText = "";
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.HoverTime = 500;
            // 
            // 
            // 
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.BackColor = System.Drawing.SystemColors.Info;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.ContextMenuStrip = this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonPopupMenu;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.Image = ((System.Drawing.Image)(resources.GetObject("_tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.Image")));
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.Location = new System.Drawing.Point(0, 0);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.Name = "_itbTextBox";
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.NoTextNoImage = true;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.ReadOnly = false;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.Size = new System.Drawing.Size(230, 20);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TabIndex = 4;
            // 
            // 
            // 
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TextBox.BackColor = System.Drawing.SystemColors.Info;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TextBox.Location = new System.Drawing.Point(1, 2);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TextBox.Name = "_tbTextBox";
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TextBox.Size = new System.Drawing.Size(228, 13);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TextBox.TabIndex = 2;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.UseImage = true;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.TextChanged += new System.EventHandler(this.ValueChanged);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ImageTextBox.DoubleClick += new System.EventHandler(this._tbmSecurityDailyPlanTimeZoneForEnterToMenu_DoubleClick);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Location = new System.Drawing.Point(250, 46);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.MaximumSize = new System.Drawing.Size(1200, 55);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.MinimumSize = new System.Drawing.Size(30, 20);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Name = "_tbmSecurityDailyPlanTimeZoneForEnterToMenu";
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.Size = new System.Drawing.Size(250, 20);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.TabIndex = 12;
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.TextImage = ((System.Drawing.Image)(resources.GetObject("_tbmSecurityDailyPlanTimeZoneForEnterToMenu.TextImage")));
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.ButtonPopupMenuItemClick += new Contal.IwQuick.UI.TextBoxMenu.DPopupMenuHandler(this._tbmSecurityDailyPlanTimeZoneForEnterToMenu_ButtonPopupMenuItemClick);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.DragDrop += new System.Windows.Forms.DragEventHandler(this._tbmScurityDailyPlanTimeZoneForEnterToMenu_DragDrop);
            this._tbmSecurityDailyPlanTimeZoneForEnterToMenu.DragOver += new System.Windows.Forms.DragEventHandler(this._tbmScurityDailyPlanTimeZoneForEnterToMenu_DragOver);
            // 
            // _tsiModify
            // 
            this._tsiModify.Name = "_tsiModify";
            this._tsiModify.Size = new System.Drawing.Size(186, 22);
            this._tsiModify.Text = "Modify";
            // 
            // _tsiRemove
            // 
            this._tsiRemove.Name = "_tsiRemove";
            this._tsiRemove.Size = new System.Drawing.Size(186, 22);
            this._tsiRemove.Text = "Remove";
            // 
            // _tsiCreateSecTimeZone
            // 
            this._tsiCreateSecTimeZone.Name = "_tsiCreateSecTimeZone";
            this._tsiCreateSecTimeZone.Size = new System.Drawing.Size(186, 22);
            this._tsiCreateSecTimeZone.Text = "Create sec. time zone";
            // 
            // _tsiCreateSecDailyPlan
            // 
            this._tsiCreateSecDailyPlan.Name = "_tsiCreateSecDailyPlan";
            this._tsiCreateSecDailyPlan.Size = new System.Drawing.Size(186, 22);
            this._tsiCreateSecDailyPlan.Text = "Create sec. daily plan";
            // 
            // _cbSlForEnterToMenu
            // 
            this._cbSlForEnterToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSlForEnterToMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSlForEnterToMenu.FormattingEnabled = true;
            this._cbSlForEnterToMenu.Location = new System.Drawing.Point(250, 19);
            this._cbSlForEnterToMenu.Name = "_cbSlForEnterToMenu";
            this._cbSlForEnterToMenu.Size = new System.Drawing.Size(250, 21);
            this._cbSlForEnterToMenu.TabIndex = 11;
            this._cbSlForEnterToMenu.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // _lSecurityLevel
            // 
            this._lSecurityLevel.AutoSize = true;
            this._lSecurityLevel.Location = new System.Drawing.Point(6, 22);
            this._lSecurityLevel.Name = "_lSecurityLevel";
            this._lSecurityLevel.Size = new System.Drawing.Size(70, 13);
            this._lSecurityLevel.TabIndex = 8;
            this._lSecurityLevel.Text = "Security level";
            // 
            // _cbOpenAllCrAlarms
            // 
            this._cbOpenAllCrAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbOpenAllCrAlarms.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbOpenAllCrAlarms.Location = new System.Drawing.Point(701, 113);
            this._cbOpenAllCrAlarms.Name = "_cbOpenAllCrAlarms";
            this._cbOpenAllCrAlarms.Size = new System.Drawing.Size(200, 17);
            this._cbOpenAllCrAlarms.TabIndex = 3;
            this._cbOpenAllCrAlarms.Text = "Open all";
            this._cbOpenAllCrAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbOpenAllCrAlarms.UseVisualStyleBackColor = true;
            this._cbOpenAllCrAlarms.CheckStateChanged += new System.EventHandler(this._cbOpenAllCrAlarms_CheckStateChanged);
            // 
            // _accordionCrAlarms
            // 
            this._accordionCrAlarms.AddResizeBars = true;
            this._accordionCrAlarms.AllowMouseResize = true;
            this._accordionCrAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._accordionCrAlarms.AnimateCloseEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Hide;
            this._accordionCrAlarms.AnimateCloseMillis = 150;
            this._accordionCrAlarms.AnimateOpenEffect = Contal.IwQuick.PlatformPC.UI.Accordion.AnimateWindowFlags.Show;
            this._accordionCrAlarms.AnimateOpenMillis = 150;
            this._accordionCrAlarms.AutoFixDockStyle = false;
            this._accordionCrAlarms.AutoScroll = true;
            this._accordionCrAlarms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._accordionCrAlarms.CheckBoxFactory = null;
            this._accordionCrAlarms.CheckBoxMargin = new System.Windows.Forms.Padding(0);
            this._accordionCrAlarms.ContentBackColor = null;
            this._accordionCrAlarms.ContentMargin = null;
            this._accordionCrAlarms.ContentPadding = new System.Windows.Forms.Padding(5);
            this._accordionCrAlarms.ControlBackColor = null;
            this._accordionCrAlarms.ControlMinimumHeightIsItsPreferredHeight = false;
            this._accordionCrAlarms.ControlMinimumWidthIsItsPreferredWidth = false;
            this._accordionCrAlarms.DownArrow = null;
            this._accordionCrAlarms.FillHeight = true;
            this._accordionCrAlarms.FillLastOpened = false;
            this._accordionCrAlarms.FillModeGrowOnly = false;
            this._accordionCrAlarms.FillResetOnCollapse = false;
            this._accordionCrAlarms.FillWidth = true;
            this._accordionCrAlarms.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this._accordionCrAlarms.GrabRequiresPositiveFillWeight = true;
            this._accordionCrAlarms.GrabWidth = 6;
            this._accordionCrAlarms.GrowAndShrink = true;
            this._accordionCrAlarms.Insets = new System.Windows.Forms.Padding(0);
            this._accordionCrAlarms.Location = new System.Drawing.Point(3, 136);
            this._accordionCrAlarms.Name = "_accordionCrAlarms";
            this._accordionCrAlarms.OpenOnAdd = false;
            this._accordionCrAlarms.OpenOneOnly = false;
            this._accordionCrAlarms.ResizeBarFactory = null;
            this._accordionCrAlarms.ResizeBarsAlign = 0.5D;
            this._accordionCrAlarms.ResizeBarsArrowKeyDelta = 10;
            this._accordionCrAlarms.ResizeBarsFadeInMillis = 800;
            this._accordionCrAlarms.ResizeBarsFadeOutMillis = 800;
            this._accordionCrAlarms.ResizeBarsFadeProximity = 24;
            this._accordionCrAlarms.ResizeBarsFill = 1D;
            this._accordionCrAlarms.ResizeBarsKeepFocusAfterMouseDrag = false;
            this._accordionCrAlarms.ResizeBarsKeepFocusIfControlOutOfView = true;
            this._accordionCrAlarms.ResizeBarsKeepFocusOnClick = true;
            this._accordionCrAlarms.ResizeBarsMargin = null;
            this._accordionCrAlarms.ResizeBarsMinimumLength = 50;
            this._accordionCrAlarms.ResizeBarsStayInViewOnArrowKey = true;
            this._accordionCrAlarms.ResizeBarsStayInViewOnMouseDrag = true;
            this._accordionCrAlarms.ResizeBarsStayVisibleIfFocused = true;
            this._accordionCrAlarms.ResizeBarsTabStop = true;
            this._accordionCrAlarms.ShowPartiallyVisibleResizeBars = false;
            this._accordionCrAlarms.ShowToolMenu = true;
            this._accordionCrAlarms.ShowToolMenuOnHoverWhenClosed = false;
            this._accordionCrAlarms.ShowToolMenuOnRightClick = true;
            this._accordionCrAlarms.ShowToolMenuRequiresPositiveFillWeight = false;
            this._accordionCrAlarms.Size = new System.Drawing.Size(901, 203);
            this._accordionCrAlarms.TabIndex = 2;
            this._accordionCrAlarms.UpArrow = null;
            // 
            // _tpInvalidPinGinRetriesLimits
            // 
            this._tpInvalidPinGinRetriesLimits.AutoScroll = true;
            this._tpInvalidPinGinRetriesLimits.AutoScrollMinSize = new System.Drawing.Size(357, 0);
            this._tpInvalidPinGinRetriesLimits.BackColor = System.Drawing.SystemColors.Control;
            this._tpInvalidPinGinRetriesLimits.Controls.Add(this._gbInvalidGinRetriesLimit);
            this._tpInvalidPinGinRetriesLimits.Controls.Add(this._gbInvalidPinRetriesLimit);
            this._tpInvalidPinGinRetriesLimits.Location = new System.Drawing.Point(4, 22);
            this._tpInvalidPinGinRetriesLimits.Name = "_tpInvalidPinGinRetriesLimits";
            this._tpInvalidPinGinRetriesLimits.Size = new System.Drawing.Size(907, 342);
            this._tpInvalidPinGinRetriesLimits.TabIndex = 5;
            this._tpInvalidPinGinRetriesLimits.Text = "Invalid PIN\\GIN retries limits";
            // 
            // _gbInvalidGinRetriesLimit
            // 
            this._gbInvalidGinRetriesLimit.Controls.Add(this._lInvalidGinRetriesLimitReachedTimeout);
            this._gbInvalidGinRetriesLimit.Controls.Add(this._eInvalidGinRetriesLimitReachedTimeout);
            this._gbInvalidGinRetriesLimit.Controls.Add(this._lInvalidGinRetriesCount);
            this._gbInvalidGinRetriesLimit.Controls.Add(this._eInvalidGinRetriesCount);
            this._gbInvalidGinRetriesLimit.Controls.Add(this._chbInvalidGinRetriesLimitEnabled);
            this._gbInvalidGinRetriesLimit.Location = new System.Drawing.Point(6, 111);
            this._gbInvalidGinRetriesLimit.Name = "_gbInvalidGinRetriesLimit";
            this._gbInvalidGinRetriesLimit.Size = new System.Drawing.Size(357, 99);
            this._gbInvalidGinRetriesLimit.TabIndex = 1;
            this._gbInvalidGinRetriesLimit.TabStop = false;
            this._gbInvalidGinRetriesLimit.Text = "Ivalid GIN retries limit";
            // 
            // _lInvalidGinRetriesLimitReachedTimeout
            // 
            this._lInvalidGinRetriesLimitReachedTimeout.AutoSize = true;
            this._lInvalidGinRetriesLimitReachedTimeout.Location = new System.Drawing.Point(6, 70);
            this._lInvalidGinRetriesLimitReachedTimeout.Name = "_lInvalidGinRetriesLimitReachedTimeout";
            this._lInvalidGinRetriesLimitReachedTimeout.Size = new System.Drawing.Size(164, 13);
            this._lInvalidGinRetriesLimitReachedTimeout.TabIndex = 4;
            this._lInvalidGinRetriesLimitReachedTimeout.Text = "Retries limit reached timeout (min)";
            // 
            // _eInvalidGinRetriesLimitReachedTimeout
            // 
            this._eInvalidGinRetriesLimitReachedTimeout.Location = new System.Drawing.Point(219, 68);
            this._eInvalidGinRetriesLimitReachedTimeout.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this._eInvalidGinRetriesLimitReachedTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._eInvalidGinRetriesLimitReachedTimeout.Name = "_eInvalidGinRetriesLimitReachedTimeout";
            this._eInvalidGinRetriesLimitReachedTimeout.Size = new System.Drawing.Size(120, 20);
            this._eInvalidGinRetriesLimitReachedTimeout.TabIndex = 3;
            this._eInvalidGinRetriesLimitReachedTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._eInvalidGinRetriesLimitReachedTimeout.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // _lInvalidGinRetriesCount
            // 
            this._lInvalidGinRetriesCount.AutoSize = true;
            this._lInvalidGinRetriesCount.Location = new System.Drawing.Point(6, 44);
            this._lInvalidGinRetriesCount.Name = "_lInvalidGinRetriesCount";
            this._lInvalidGinRetriesCount.Size = new System.Drawing.Size(70, 13);
            this._lInvalidGinRetriesCount.TabIndex = 2;
            this._lInvalidGinRetriesCount.Text = "Retries count";
            // 
            // _eInvalidGinRetriesCount
            // 
            this._eInvalidGinRetriesCount.Location = new System.Drawing.Point(219, 42);
            this._eInvalidGinRetriesCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._eInvalidGinRetriesCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._eInvalidGinRetriesCount.Name = "_eInvalidGinRetriesCount";
            this._eInvalidGinRetriesCount.Size = new System.Drawing.Size(120, 20);
            this._eInvalidGinRetriesCount.TabIndex = 1;
            this._eInvalidGinRetriesCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._eInvalidGinRetriesCount.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // _chbInvalidGinRetriesLimitEnabled
            // 
            this._chbInvalidGinRetriesLimitEnabled.AutoSize = true;
            this._chbInvalidGinRetriesLimitEnabled.Location = new System.Drawing.Point(6, 19);
            this._chbInvalidGinRetriesLimitEnabled.Name = "_chbInvalidGinRetriesLimitEnabled";
            this._chbInvalidGinRetriesLimitEnabled.Size = new System.Drawing.Size(171, 17);
            this._chbInvalidGinRetriesLimitEnabled.TabIndex = 0;
            this._chbInvalidGinRetriesLimitEnabled.Text = "Enabled invalid GIN retries limit";
            this._chbInvalidGinRetriesLimitEnabled.UseVisualStyleBackColor = true;
            this._chbInvalidGinRetriesLimitEnabled.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // _gbInvalidPinRetriesLimit
            // 
            this._gbInvalidPinRetriesLimit.Controls.Add(this._lInvalidPinRetriesLimitReachedTimeout);
            this._gbInvalidPinRetriesLimit.Controls.Add(this._eInvalidPinRetriesLimitReachedTimeout);
            this._gbInvalidPinRetriesLimit.Controls.Add(this._lInvalidPinRetriesCount);
            this._gbInvalidPinRetriesLimit.Controls.Add(this._eInvalidPinRetriesCount);
            this._gbInvalidPinRetriesLimit.Controls.Add(this._chbInvalidPinRetriesLimitEnabled);
            this._gbInvalidPinRetriesLimit.Location = new System.Drawing.Point(6, 6);
            this._gbInvalidPinRetriesLimit.Name = "_gbInvalidPinRetriesLimit";
            this._gbInvalidPinRetriesLimit.Size = new System.Drawing.Size(357, 99);
            this._gbInvalidPinRetriesLimit.TabIndex = 0;
            this._gbInvalidPinRetriesLimit.TabStop = false;
            this._gbInvalidPinRetriesLimit.Text = "Ivalid PIN retries limit";
            // 
            // _lInvalidPinRetriesLimitReachedTimeout
            // 
            this._lInvalidPinRetriesLimitReachedTimeout.AutoSize = true;
            this._lInvalidPinRetriesLimitReachedTimeout.Location = new System.Drawing.Point(6, 70);
            this._lInvalidPinRetriesLimitReachedTimeout.Name = "_lInvalidPinRetriesLimitReachedTimeout";
            this._lInvalidPinRetriesLimitReachedTimeout.Size = new System.Drawing.Size(164, 13);
            this._lInvalidPinRetriesLimitReachedTimeout.TabIndex = 4;
            this._lInvalidPinRetriesLimitReachedTimeout.Text = "Retries limit reached timeout (min)";
            // 
            // _eInvalidPinRetriesLimitReachedTimeout
            // 
            this._eInvalidPinRetriesLimitReachedTimeout.Location = new System.Drawing.Point(219, 68);
            this._eInvalidPinRetriesLimitReachedTimeout.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this._eInvalidPinRetriesLimitReachedTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._eInvalidPinRetriesLimitReachedTimeout.Name = "_eInvalidPinRetriesLimitReachedTimeout";
            this._eInvalidPinRetriesLimitReachedTimeout.Size = new System.Drawing.Size(120, 20);
            this._eInvalidPinRetriesLimitReachedTimeout.TabIndex = 3;
            this._eInvalidPinRetriesLimitReachedTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._eInvalidPinRetriesLimitReachedTimeout.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // _lInvalidPinRetriesCount
            // 
            this._lInvalidPinRetriesCount.AutoSize = true;
            this._lInvalidPinRetriesCount.Location = new System.Drawing.Point(6, 44);
            this._lInvalidPinRetriesCount.Name = "_lInvalidPinRetriesCount";
            this._lInvalidPinRetriesCount.Size = new System.Drawing.Size(70, 13);
            this._lInvalidPinRetriesCount.TabIndex = 2;
            this._lInvalidPinRetriesCount.Text = "Retries count";
            // 
            // _eInvalidPinRetriesCount
            // 
            this._eInvalidPinRetriesCount.Location = new System.Drawing.Point(219, 42);
            this._eInvalidPinRetriesCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._eInvalidPinRetriesCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._eInvalidPinRetriesCount.Name = "_eInvalidPinRetriesCount";
            this._eInvalidPinRetriesCount.Size = new System.Drawing.Size(120, 20);
            this._eInvalidPinRetriesCount.TabIndex = 1;
            this._eInvalidPinRetriesCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._eInvalidPinRetriesCount.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // _chbInvalidPinRetriesLimitEnabled
            // 
            this._chbInvalidPinRetriesLimitEnabled.AutoSize = true;
            this._chbInvalidPinRetriesLimitEnabled.Location = new System.Drawing.Point(6, 19);
            this._chbInvalidPinRetriesLimitEnabled.Name = "_chbInvalidPinRetriesLimitEnabled";
            this._chbInvalidPinRetriesLimitEnabled.Size = new System.Drawing.Size(170, 17);
            this._chbInvalidPinRetriesLimitEnabled.TabIndex = 0;
            this._chbInvalidPinRetriesLimitEnabled.Text = "Enabled invalid PIN retries limit";
            this._chbInvalidPinRetriesLimitEnabled.UseVisualStyleBackColor = true;
            this._chbInvalidPinRetriesLimitEnabled.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tabPagePersons
            // 
            this._tpPersons.BackColor = System.Drawing.SystemColors.Control;
            this._tpPersons.Controls.Add(this.buttonPersonsUnselectAll);
            this._tpPersons.Controls.Add(this.buttonPersonsSelectAll);
            this._tpPersons.Controls.Add(this.checkedListBoxPersons);
            this._tpPersons.Location = new System.Drawing.Point(4, 22);
            this._tpPersons.Name = "tabPagePersons";
            this._tpPersons.Padding = new System.Windows.Forms.Padding(3);
            this._tpPersons.Size = new System.Drawing.Size(907, 342);
            this._tpPersons.TabIndex = 6;
            this._tpPersons.Text = "Persons";
            // 
            // buttonPersonsUnselectAll
            // 
            this.buttonPersonsUnselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPersonsUnselectAll.Location = new System.Drawing.Point(87, 316);
            this.buttonPersonsUnselectAll.Name = "buttonPersonsUnselectAll";
            this.buttonPersonsUnselectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonsUnselectAll.TabIndex = 2;
            this.buttonPersonsUnselectAll.Text = "Unselect All";
            this.buttonPersonsUnselectAll.UseVisualStyleBackColor = true;
            this.buttonPersonsUnselectAll.Click += new System.EventHandler(this.OnPersonsUnselectAll);
            // 
            // buttonPersonsSelectAll
            // 
            this.buttonPersonsSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPersonsSelectAll.Location = new System.Drawing.Point(6, 316);
            this.buttonPersonsSelectAll.Name = "buttonPersonsSelectAll";
            this.buttonPersonsSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonsSelectAll.TabIndex = 1;
            this.buttonPersonsSelectAll.Text = "Select All";
            this.buttonPersonsSelectAll.UseVisualStyleBackColor = true;
            this.buttonPersonsSelectAll.Click += new System.EventHandler(this.OnPersonsSelectAll);
            // 
            // _bApply
            // 
            this._bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bApply.Enabled = false;
            this._bApply.Location = new System.Drawing.Point(690, 386);
            this._bApply.Name = "_bApply";
            this._bApply.Size = new System.Drawing.Size(75, 23);
            this._bApply.TabIndex = 100;
            this._bApply.Text = "Apply";
            this._bApply.UseVisualStyleBackColor = true;
            this._bApply.Click += new System.EventHandler(this._bApply_Click);
            // 
            // checkedListBoxPersons
            // 
            this.checkedListBoxPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxPersons.FormattingEnabled = true;
            this.checkedListBoxPersons.Location = new System.Drawing.Point(6, 6);
            this.checkedListBoxPersons.Name = "checkedListBoxPersons";
            this.checkedListBoxPersons.Size = new System.Drawing.Size(895, 304);
            this.checkedListBoxPersons.TabIndex = 0;
            // 
            // NCASDevicesAlarmSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 421);
            this.Controls.Add(this._bApply);
            this.Controls.Add(this._tcDevicesAlarmSetting);
            this.Controls.Add(this._bClose);
            this.Controls.Add(this._bSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NCASDevicesAlarmSettingsForm";
            this.Text = "NCASDevicesAlarmSettingsForm";
            this._tcDevicesAlarmSetting.ResumeLayout(false);
            this._tpAlarmAreaAlarms.ResumeLayout(false);
            this._tpAlarmAreaAlarms.PerformLayout();
            this._tpCcuAlarms.ResumeLayout(false);
            this._tpDcuAlarms.ResumeLayout(false);
            this._tpDoorEnvironmentAlarms.ResumeLayout(false);
            this._tpCrAlarms.ResumeLayout(false);
            this._gbSlForEnterToMenu.ResumeLayout(false);
            this._gbSlForEnterToMenu.PerformLayout();
            this._tpInvalidPinGinRetriesLimits.ResumeLayout(false);
            this._gbInvalidGinRetriesLimit.ResumeLayout(false);
            this._gbInvalidGinRetriesLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._eInvalidGinRetriesLimitReachedTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._eInvalidGinRetriesCount)).EndInit();
            this._gbInvalidPinRetriesLimit.ResumeLayout(false);
            this._gbInvalidPinRetriesLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._eInvalidPinRetriesLimitReachedTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._eInvalidPinRetriesCount)).EndInit();
            this._tpPersons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _bSave;
        private System.Windows.Forms.Button _bClose;
        private System.Windows.Forms.TabControl _tcDevicesAlarmSetting;
        private System.Windows.Forms.TabPage _tpCcuAlarms;
        private System.Windows.Forms.TabPage _tpDcuAlarms;
        private System.Windows.Forms.TabPage _tpCrAlarms;
        private System.Windows.Forms.TabPage _tpAlarmAreaAlarms;
        private System.Windows.Forms.CheckBox _chbAlarmAreaReportingToCRs;
        private System.Windows.Forms.Button _bApply;
        private System.Windows.Forms.TabPage _tpDoorEnvironmentAlarms;
        private System.Windows.Forms.TabPage _tpInvalidPinGinRetriesLimits;
        private System.Windows.Forms.GroupBox _gbInvalidPinRetriesLimit;
        private System.Windows.Forms.CheckBox _chbInvalidPinRetriesLimitEnabled;
        private System.Windows.Forms.Label _lInvalidPinRetriesCount;
        private System.Windows.Forms.NumericUpDown _eInvalidPinRetriesCount;
        private System.Windows.Forms.NumericUpDown _eInvalidPinRetriesLimitReachedTimeout;
        private System.Windows.Forms.Label _lInvalidPinRetriesLimitReachedTimeout;
        private System.Windows.Forms.GroupBox _gbInvalidGinRetriesLimit;
        private System.Windows.Forms.Label _lInvalidGinRetriesLimitReachedTimeout;
        private System.Windows.Forms.NumericUpDown _eInvalidGinRetriesLimitReachedTimeout;
        private System.Windows.Forms.Label _lInvalidGinRetriesCount;
        private System.Windows.Forms.NumericUpDown _eInvalidGinRetriesCount;
        private System.Windows.Forms.CheckBox _chbInvalidGinRetriesLimitEnabled;
        private Contal.IwQuick.PlatformPC.UI.Accordion.Accordion _accordionDcuAlarms;
        private Contal.IwQuick.PlatformPC.UI.Accordion.Accordion _accordionDsmAlarms;
        private System.Windows.Forms.CheckBox _cbOpenAllDcuAlarms;
        private System.Windows.Forms.CheckBox _cbOpenAllDsmAlarms;
        private System.Windows.Forms.CheckBox _cbOpenAllCrAlarms;
        private Contal.IwQuick.PlatformPC.UI.Accordion.Accordion _accordionCrAlarms;
        private System.Windows.Forms.CheckBox _cbOpenAllCcuAlarms;
        private Contal.IwQuick.PlatformPC.UI.Accordion.Accordion _accordionCcuAlarms;
        private Contal.IwQuick.PlatformPC.UI.Accordion.Accordion _accordionAlarmAreaAlarms;
        private System.Windows.Forms.GroupBox _gbSlForEnterToMenu;
        private System.Windows.Forms.Label _lGin2;
        private System.Windows.Forms.Label _lSecurityDailyPlanTimeZone;
        private System.Windows.Forms.TextBox _eGinForEnterToMenu;
        private Contal.IwQuick.UI.TextBoxMenu _tbmSecurityDailyPlanTimeZoneForEnterToMenu;
        private System.Windows.Forms.ToolStripMenuItem _tsiModify;
        private System.Windows.Forms.ToolStripMenuItem _tsiRemove;
        private System.Windows.Forms.ToolStripMenuItem _tsiCreateSecTimeZone;
        private System.Windows.Forms.ToolStripMenuItem _tsiCreateSecDailyPlan;
        private System.Windows.Forms.ComboBox _cbSlForEnterToMenu;
        private System.Windows.Forms.Label _lSecurityLevel;
        private System.Windows.Forms.TabPage _tpPersons;
        private System.Windows.Forms.Button buttonPersonsUnselectAll;
        private System.Windows.Forms.Button buttonPersonsSelectAll;
        private System.Windows.Forms.CheckedListBox checkedListBoxPersons;
    }
}