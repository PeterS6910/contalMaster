namespace Contal.Cgp.Client
{
    partial class CardSystemsEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardSystemsEditForm));
            this._eDescription = new System.Windows.Forms.TextBox();
            this._bCancel = new System.Windows.Forms.Button();
            this._bOk = new System.Windows.Forms.Button();
            this._lCards = new System.Windows.Forms.Label();
            this._eFilterCards = new System.Windows.Forms.TextBox();
            this._lbCards = new System.Windows.Forms.ListBox();
            this._tcCardSystem = new System.Windows.Forms.TabControl();
            this._tpProperties = new System.Windows.Forms.TabPage();
            this._lActualFullCompanyCode = new System.Windows.Forms.Label();
            this._lFullCompanyCode = new System.Windows.Forms.Label();
            this._cbCardSubType = new System.Windows.Forms.ComboBox();
            this._lCardSubType = new System.Windows.Forms.Label();
            this._lCardDataLengthActual = new System.Windows.Forms.Label();
            this._tbCardDataLength = new System.Windows.Forms.TrackBar();
            this._lCompanyCodeLengthActual = new System.Windows.Forms.Label();
            this._cbCardType = new System.Windows.Forms.ComboBox();
            this._lCardType = new System.Windows.Forms.Label();
            this._lCompanyCode = new System.Windows.Forms.Label();
            this._eCompanyCode = new System.Windows.Forms.TextBox();
            this._lCompanyCodeLength = new System.Windows.Forms.Label();
            this._lCardDataLength = new System.Windows.Forms.Label();
            this._tpSmartCardData = new System.Windows.Forms.TabPage();
            this._tlpAidAndKeys = new System.Windows.Forms.TableLayoutPanel();
            this._eAid = new System.Windows.Forms.TextBox();
            this._lAkey = new System.Windows.Forms.Label();
            this._eAkey = new System.Windows.Forms.TextBox();
            this._lBkey = new System.Windows.Forms.Label();
            this._lAid = new System.Windows.Forms.Label();
            this._eBkey = new System.Windows.Forms.TextBox();
            this._dgvSectors = new System.Windows.Forms.DataGridView();
            this._cbSize = new System.Windows.Forms.ComboBox();
            this._lSize = new System.Windows.Forms.Label();
            this._cbExplicitSmartCardDataPopulation = new System.Windows.Forms.CheckBox();
            this._lEncoding = new System.Windows.Forms.Label();
            this._cbEncoding = new System.Windows.Forms.ComboBox();
            this._tpUserFolders = new System.Windows.Forms.TabPage();
            this._bRefresh = new System.Windows.Forms.Button();
            this._lbUserFolders = new Contal.IwQuick.UI.ImageListBox();
            this._tpReferencedBy = new System.Windows.Forms.TabPage();
            this._tpDescription = new System.Windows.Forms.TabPage();
            this._tpCardGeneration = new System.Windows.Forms.TabPage();
            this._nudCardNumberTo = new System.Windows.Forms.NumericUpDown();
            this._nudCardNumberFrom = new System.Windows.Forms.NumericUpDown();
            this._bGenerate = new System.Windows.Forms.Button();
            this._pbCardGeneration = new System.Windows.Forms.ProgressBar();
            this._tbGenerationResult = new System.Windows.Forms.TextBox();
            this._lTo = new System.Windows.Forms.Label();
            this._lFrom = new System.Windows.Forms.Label();
            this._lCardRange = new System.Windows.Forms.Label();
            this._lName = new System.Windows.Forms.Label();
            this._eName = new System.Windows.Forms.TextBox();
            this._bCreate = new System.Windows.Forms.Button();
            this._panelBack = new System.Windows.Forms.Panel();
            this._tcCardSystem.SuspendLayout();
            this._tpProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbCardDataLength)).BeginInit();
            this._tpSmartCardData.SuspendLayout();
            this._tlpAidAndKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvSectors)).BeginInit();
            this._tpUserFolders.SuspendLayout();
            this._tpDescription.SuspendLayout();
            this._tpCardGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudCardNumberTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCardNumberFrom)).BeginInit();
            this._panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // _eDescription
            // 
            this._eDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._eDescription.Location = new System.Drawing.Point(3, 3);
            this._eDescription.Multiline = true;
            this._eDescription.Name = "_eDescription";
            this._eDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._eDescription.Size = new System.Drawing.Size(536, 269);
            this._eDescription.TabIndex = 0;
            this._eDescription.TabStop = false;
            this._eDescription.TextChanged += new System.EventHandler(this.EditTextChangerOnlyInDatabase);
            // 
            // _bCancel
            // 
            this._bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bCancel.Location = new System.Drawing.Point(482, 578);
            this._bCancel.Name = "_bCancel";
            this._bCancel.Size = new System.Drawing.Size(80, 22);
            this._bCancel.TabIndex = 8;
            this._bCancel.Text = "Cancel";
            this._bCancel.UseVisualStyleBackColor = true;
            this._bCancel.Click += new System.EventHandler(this._bCancel_Click);
            // 
            // _bOk
            // 
            this._bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bOk.Location = new System.Drawing.Point(396, 578);
            this._bOk.Name = "_bOk";
            this._bOk.Size = new System.Drawing.Size(80, 22);
            this._bOk.TabIndex = 7;
            this._bOk.Text = "OK";
            this._bOk.UseVisualStyleBackColor = true;
            this._bOk.Click += new System.EventHandler(this._bOk_Click);
            // 
            // _lCards
            // 
            this._lCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._lCards.AutoSize = true;
            this._lCards.Location = new System.Drawing.Point(12, 343);
            this._lCards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lCards.Name = "_lCards";
            this._lCards.Size = new System.Drawing.Size(37, 13);
            this._lCards.TabIndex = 3;
            this._lCards.Text = "Cards:";
            // 
            // _eFilterCards
            // 
            this._eFilterCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._eFilterCards.Location = new System.Drawing.Point(8, 358);
            this._eFilterCards.Margin = new System.Windows.Forms.Padding(2);
            this._eFilterCards.Name = "_eFilterCards";
            this._eFilterCards.Size = new System.Drawing.Size(549, 20);
            this._eFilterCards.TabIndex = 4;
            this._eFilterCards.KeyUp += new System.Windows.Forms.KeyEventHandler(this._eFilterCards_KeyUp);
            // 
            // _lbCards
            // 
            this._lbCards.AllowDrop = true;
            this._lbCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._lbCards.BackColor = System.Drawing.SystemColors.Info;
            this._lbCards.FormattingEnabled = true;
            this._lbCards.Location = new System.Drawing.Point(8, 382);
            this._lbCards.Margin = new System.Windows.Forms.Padding(2);
            this._lbCards.Name = "_lbCards";
            this._lbCards.Size = new System.Drawing.Size(550, 160);
            this._lbCards.TabIndex = 5;
            this._lbCards.TabStop = false;
            this._lbCards.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._lbCards_MouseDoubleClick);
            // 
            // _tcCardSystem
            // 
            this._tcCardSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tcCardSystem.Controls.Add(this._tpProperties);
            this._tcCardSystem.Controls.Add(this._tpSmartCardData);
            this._tcCardSystem.Controls.Add(this._tpUserFolders);
            this._tcCardSystem.Controls.Add(this._tpReferencedBy);
            this._tcCardSystem.Controls.Add(this._tpDescription);
            this._tcCardSystem.Controls.Add(this._tpCardGeneration);
            this._tcCardSystem.Location = new System.Drawing.Point(12, 39);
            this._tcCardSystem.Name = "_tcCardSystem";
            this._tcCardSystem.SelectedIndex = 0;
            this._tcCardSystem.Size = new System.Drawing.Size(550, 301);
            this._tcCardSystem.TabIndex = 2;
            this._tcCardSystem.TabStop = false;
            // 
            // _tpProperties
            // 
            this._tpProperties.BackColor = System.Drawing.SystemColors.Control;
            this._tpProperties.Controls.Add(this._lActualFullCompanyCode);
            this._tpProperties.Controls.Add(this._lFullCompanyCode);
            this._tpProperties.Controls.Add(this._cbCardSubType);
            this._tpProperties.Controls.Add(this._lCardSubType);
            this._tpProperties.Controls.Add(this._lCardDataLengthActual);
            this._tpProperties.Controls.Add(this._tbCardDataLength);
            this._tpProperties.Controls.Add(this._lCompanyCodeLengthActual);
            this._tpProperties.Controls.Add(this._cbCardType);
            this._tpProperties.Controls.Add(this._lCardType);
            this._tpProperties.Controls.Add(this._lCompanyCode);
            this._tpProperties.Controls.Add(this._eCompanyCode);
            this._tpProperties.Controls.Add(this._lCompanyCodeLength);
            this._tpProperties.Controls.Add(this._lCardDataLength);
            this._tpProperties.Location = new System.Drawing.Point(4, 22);
            this._tpProperties.Name = "_tpProperties";
            this._tpProperties.Padding = new System.Windows.Forms.Padding(3);
            this._tpProperties.Size = new System.Drawing.Size(542, 275);
            this._tpProperties.TabIndex = 0;
            this._tpProperties.Text = "Properties";
            this._tpProperties.Click += new System.EventHandler(this._tpProperties_Click);
            // 
            // _lActualFullCompanyCode
            // 
            this._lActualFullCompanyCode.AutoSize = true;
            this._lActualFullCompanyCode.Location = new System.Drawing.Point(144, 170);
            this._lActualFullCompanyCode.Name = "_lActualFullCompanyCode";
            this._lActualFullCompanyCode.Size = new System.Drawing.Size(0, 13);
            this._lActualFullCompanyCode.TabIndex = 12;
            // 
            // _lFullCompanyCode
            // 
            this._lFullCompanyCode.AutoSize = true;
            this._lFullCompanyCode.Location = new System.Drawing.Point(6, 170);
            this._lFullCompanyCode.Name = "_lFullCompanyCode";
            this._lFullCompanyCode.Size = new System.Drawing.Size(96, 13);
            this._lFullCompanyCode.TabIndex = 11;
            this._lFullCompanyCode.Text = "Full company code";
            // 
            // _cbCardSubType
            // 
            this._cbCardSubType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbCardSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCardSubType.FormattingEnabled = true;
            this._cbCardSubType.ItemHeight = 13;
            this._cbCardSubType.Location = new System.Drawing.Point(147, 33);
            this._cbCardSubType.Name = "_cbCardSubType";
            this._cbCardSubType.Size = new System.Drawing.Size(302, 21);
            this._cbCardSubType.TabIndex = 3;
            this._cbCardSubType.EnabledChanged += new System.EventHandler(this._cbCardSubType_EnabledChanged);
            this._cbCardSubType.SelectedIndexChanged += new System.EventHandler(this._cbCardSubType_SelectedIndexChanged);
            this._cbCardSubType.TextChanged += new System.EventHandler(this.EditTextChanger);
            // 
            // _lCardSubType
            // 
            this._lCardSubType.AutoSize = true;
            this._lCardSubType.Location = new System.Drawing.Point(6, 35);
            this._lCardSubType.Name = "_lCardSubType";
            this._lCardSubType.Size = new System.Drawing.Size(69, 13);
            this._lCardSubType.TabIndex = 2;
            this._lCardSubType.Text = "Card subtype";
            // 
            // _lCardDataLengthActual
            // 
            this._lCardDataLengthActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lCardDataLengthActual.AutoSize = true;
            this._lCardDataLengthActual.Location = new System.Drawing.Point(435, 75);
            this._lCardDataLengthActual.Name = "_lCardDataLengthActual";
            this._lCardDataLengthActual.Size = new System.Drawing.Size(13, 13);
            this._lCardDataLengthActual.TabIndex = 6;
            this._lCardDataLengthActual.Text = "0";
            // 
            // _tbCardDataLength
            // 
            this._tbCardDataLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbCardDataLength.Location = new System.Drawing.Point(147, 60);
            this._tbCardDataLength.Maximum = 40;
            this._tbCardDataLength.Name = "_tbCardDataLength";
            this._tbCardDataLength.Size = new System.Drawing.Size(282, 45);
            this._tbCardDataLength.TabIndex = 5;
            this._tbCardDataLength.ValueChanged += new System.EventHandler(this.CardDataLengthChanged);
            // 
            // _lCompanyCodeLengthActual
            // 
            this._lCompanyCodeLengthActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lCompanyCodeLengthActual.AutoSize = true;
            this._lCompanyCodeLengthActual.Location = new System.Drawing.Point(160, 145);
            this._lCompanyCodeLengthActual.Name = "_lCompanyCodeLengthActual";
            this._lCompanyCodeLengthActual.Size = new System.Drawing.Size(13, 13);
            this._lCompanyCodeLengthActual.TabIndex = 10;
            this._lCompanyCodeLengthActual.Text = "0";
            // 
            // _cbCardType
            // 
            this._cbCardType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCardType.FormattingEnabled = true;
            this._cbCardType.ItemHeight = 13;
            this._cbCardType.Location = new System.Drawing.Point(147, 6);
            this._cbCardType.Name = "_cbCardType";
            this._cbCardType.Size = new System.Drawing.Size(302, 21);
            this._cbCardType.TabIndex = 1;
            this._cbCardType.SelectedIndexChanged += new System.EventHandler(this._cbCardType_SelectedIndexChanged);
            this._cbCardType.TextChanged += new System.EventHandler(this.EditTextChanger);
            // 
            // _lCardType
            // 
            this._lCardType.AutoSize = true;
            this._lCardType.Location = new System.Drawing.Point(6, 9);
            this._lCardType.Name = "_lCardType";
            this._lCardType.Size = new System.Drawing.Size(52, 13);
            this._lCardType.TabIndex = 0;
            this._lCardType.Text = "Card type";
            // 
            // _lCompanyCode
            // 
            this._lCompanyCode.AutoSize = true;
            this._lCompanyCode.Location = new System.Drawing.Point(6, 114);
            this._lCompanyCode.Name = "_lCompanyCode";
            this._lCompanyCode.Size = new System.Drawing.Size(78, 13);
            this._lCompanyCode.TabIndex = 7;
            this._lCompanyCode.Text = "Company code";
            // 
            // _eCompanyCode
            // 
            this._eCompanyCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._eCompanyCode.Location = new System.Drawing.Point(147, 111);
            this._eCompanyCode.Name = "_eCompanyCode";
            this._eCompanyCode.Size = new System.Drawing.Size(304, 20);
            this._eCompanyCode.TabIndex = 8;
            this._eCompanyCode.TextChanged += new System.EventHandler(this.EditTextChanger);
            // 
            // _lCompanyCodeLength
            // 
            this._lCompanyCodeLength.AutoSize = true;
            this._lCompanyCodeLength.Location = new System.Drawing.Point(6, 145);
            this._lCompanyCodeLength.Name = "_lCompanyCodeLength";
            this._lCompanyCodeLength.Size = new System.Drawing.Size(110, 13);
            this._lCompanyCodeLength.TabIndex = 9;
            this._lCompanyCodeLength.Text = "Company code length";
            // 
            // _lCardDataLength
            // 
            this._lCardDataLength.AutoSize = true;
            this._lCardDataLength.Location = new System.Drawing.Point(6, 75);
            this._lCardDataLength.Name = "_lCardDataLength";
            this._lCardDataLength.Size = new System.Drawing.Size(85, 13);
            this._lCardDataLength.TabIndex = 4;
            this._lCardDataLength.Text = "Card data length";
            // 
            // _tpSmartCardData
            // 
            this._tpSmartCardData.BackColor = System.Drawing.SystemColors.Control;
            this._tpSmartCardData.Controls.Add(this._tlpAidAndKeys);
            this._tpSmartCardData.Controls.Add(this._dgvSectors);
            this._tpSmartCardData.Controls.Add(this._cbSize);
            this._tpSmartCardData.Controls.Add(this._lSize);
            this._tpSmartCardData.Controls.Add(this._cbExplicitSmartCardDataPopulation);
            this._tpSmartCardData.Controls.Add(this._lEncoding);
            this._tpSmartCardData.Controls.Add(this._cbEncoding);
            this._tpSmartCardData.Location = new System.Drawing.Point(4, 22);
            this._tpSmartCardData.Name = "_tpSmartCardData";
            this._tpSmartCardData.Padding = new System.Windows.Forms.Padding(3);
            this._tpSmartCardData.Size = new System.Drawing.Size(542, 275);
            this._tpSmartCardData.TabIndex = 4;
            this._tpSmartCardData.Text = "Smart card data";
            this._tpSmartCardData.Enter += new System.EventHandler(this._tpSmartCardData_Enter);
            // 
            // _tlpAidAndKeys
            // 
            this._tlpAidAndKeys.AutoSize = true;
            this._tlpAidAndKeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tlpAidAndKeys.ColumnCount = 2;
            this._tlpAidAndKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tlpAidAndKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tlpAidAndKeys.Controls.Add(this._eAid, 1, 0);
            this._tlpAidAndKeys.Controls.Add(this._lAkey, 0, 1);
            this._tlpAidAndKeys.Controls.Add(this._eAkey, 1, 1);
            this._tlpAidAndKeys.Controls.Add(this._lBkey, 0, 2);
            this._tlpAidAndKeys.Controls.Add(this._lAid, 0, 0);
            this._tlpAidAndKeys.Controls.Add(this._eBkey, 1, 2);
            this._tlpAidAndKeys.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this._tlpAidAndKeys.Location = new System.Drawing.Point(9, 9);
            this._tlpAidAndKeys.Name = "_tlpAidAndKeys";
            this._tlpAidAndKeys.RowCount = 3;
            this._tlpAidAndKeys.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpAidAndKeys.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpAidAndKeys.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpAidAndKeys.Size = new System.Drawing.Size(170, 78);
            this._tlpAidAndKeys.TabIndex = 19;
            // 
            // _eAid
            // 
            this._eAid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._eAid.Location = new System.Drawing.Point(43, 3);
            this._eAid.Name = "_eAid";
            this._eAid.Size = new System.Drawing.Size(124, 20);
            this._eAid.TabIndex = 1;
            this._eAid.TextChanged += new System.EventHandler(this._eAid_TextChanged);
            this._eAid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AidKeyPress);
            // 
            // _lAkey
            // 
            this._lAkey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lAkey.AutoSize = true;
            this._lAkey.Location = new System.Drawing.Point(3, 32);
            this._lAkey.Name = "_lAkey";
            this._lAkey.Size = new System.Drawing.Size(34, 13);
            this._lAkey.TabIndex = 2;
            this._lAkey.Text = "A-key";
            // 
            // _eAkey
            // 
            this._eAkey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._eAkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this._eAkey.Location = new System.Drawing.Point(43, 29);
            this._eAkey.MaxLength = 12;
            this._eAkey.Name = "_eAkey";
            this._eAkey.PasswordChar = '●';
            this._eAkey.Size = new System.Drawing.Size(123, 20);
            this._eAkey.TabIndex = 3;
            // 
            // _lBkey
            // 
            this._lBkey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lBkey.AutoSize = true;
            this._lBkey.Location = new System.Drawing.Point(3, 58);
            this._lBkey.Name = "_lBkey";
            this._lBkey.Size = new System.Drawing.Size(34, 13);
            this._lBkey.TabIndex = 6;
            this._lBkey.Text = "B-key";
            // 
            // _lAid
            // 
            this._lAid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lAid.AutoSize = true;
            this._lAid.Location = new System.Drawing.Point(3, 6);
            this._lAid.Name = "_lAid";
            this._lAid.Size = new System.Drawing.Size(25, 13);
            this._lAid.TabIndex = 0;
            this._lAid.Text = "AID";
            // 
            // _eBkey
            // 
            this._eBkey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._eBkey.Location = new System.Drawing.Point(43, 55);
            this._eBkey.MaxLength = 12;
            this._eBkey.Name = "_eBkey";
            this._eBkey.PasswordChar = '●';
            this._eBkey.Size = new System.Drawing.Size(123, 20);
            this._eBkey.TabIndex = 7;
            // 
            // _dgvSectors
            // 
            this._dgvSectors.AllowUserToAddRows = false;
            this._dgvSectors.AllowUserToDeleteRows = false;
            this._dgvSectors.AllowUserToResizeRows = false;
            this._dgvSectors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvSectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvSectors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dgvSectors.Location = new System.Drawing.Point(9, 94);
            this._dgvSectors.Name = "_dgvSectors";
            this._dgvSectors.RowHeadersVisible = false;
            this._dgvSectors.Size = new System.Drawing.Size(527, 152);
            this._dgvSectors.TabIndex = 18;
            this._dgvSectors.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvSectors_CellEndEdit);
            this._dgvSectors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvSectors_CellClick);
            this._dgvSectors.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this._dgvSectors_EditingControlShowing);
            this._dgvSectors.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvSectors_CellEnter);
            // 
            // _cbSize
            // 
            this._cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSize.FormattingEnabled = true;
            this._cbSize.Items.AddRange(new object[] {
            "1K",
            "4K"});
            this._cbSize.Location = new System.Drawing.Point(347, 31);
            this._cbSize.Name = "_cbSize";
            this._cbSize.Size = new System.Drawing.Size(89, 21);
            this._cbSize.TabIndex = 17;
            this._cbSize.SelectionChangeCommitted += new System.EventHandler(this._cbSize_SelectionChangeCommitted);
            // 
            // _lSize
            // 
            this._lSize.AutoSize = true;
            this._lSize.Location = new System.Drawing.Point(263, 35);
            this._lSize.Name = "_lSize";
            this._lSize.Size = new System.Drawing.Size(27, 13);
            this._lSize.TabIndex = 16;
            this._lSize.Text = "Size";
            // 
            // _cbExplicitSmartCardDataPopulation
            // 
            this._cbExplicitSmartCardDataPopulation.AutoSize = true;
            this._cbExplicitSmartCardDataPopulation.Location = new System.Drawing.Point(9, 252);
            this._cbExplicitSmartCardDataPopulation.Name = "_cbExplicitSmartCardDataPopulation";
            this._cbExplicitSmartCardDataPopulation.Size = new System.Drawing.Size(187, 17);
            this._cbExplicitSmartCardDataPopulation.TabIndex = 15;
            this._cbExplicitSmartCardDataPopulation.Text = "Explicit smart card data population";
            this._cbExplicitSmartCardDataPopulation.UseVisualStyleBackColor = true;
            this._cbExplicitSmartCardDataPopulation.CheckedChanged += new System.EventHandler(this.EditTextChanger);
            // 
            // _lEncoding
            // 
            this._lEncoding.AutoSize = true;
            this._lEncoding.Location = new System.Drawing.Point(263, 9);
            this._lEncoding.Name = "_lEncoding";
            this._lEncoding.Size = new System.Drawing.Size(52, 13);
            this._lEncoding.TabIndex = 10;
            this._lEncoding.Text = "Encoding";
            // 
            // _cbEncoding
            // 
            this._cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbEncoding.FormattingEnabled = true;
            this._cbEncoding.Location = new System.Drawing.Point(347, 5);
            this._cbEncoding.Name = "_cbEncoding";
            this._cbEncoding.Size = new System.Drawing.Size(89, 21);
            this._cbEncoding.TabIndex = 11;
            this._cbEncoding.SelectionChangeCommitted += new System.EventHandler(this._cbEncoding_SelectionChangeCommitted);
            this._cbEncoding.SelectedIndexChanged += new System.EventHandler(this.EncodingTypeChanged);
            // 
            // _tpUserFolders
            // 
            this._tpUserFolders.BackColor = System.Drawing.SystemColors.Control;
            this._tpUserFolders.Controls.Add(this._bRefresh);
            this._tpUserFolders.Controls.Add(this._lbUserFolders);
            this._tpUserFolders.Location = new System.Drawing.Point(4, 22);
            this._tpUserFolders.Name = "_tpUserFolders";
            this._tpUserFolders.Size = new System.Drawing.Size(542, 275);
            this._tpUserFolders.TabIndex = 3;
            this._tpUserFolders.Text = "User folders";
            this._tpUserFolders.Enter += new System.EventHandler(this._tpUserFolders_Enter);
            // 
            // _bRefresh
            // 
            this._bRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bRefresh.Location = new System.Drawing.Point(464, 210);
            this._bRefresh.Name = "_bRefresh";
            this._bRefresh.Size = new System.Drawing.Size(75, 23);
            this._bRefresh.TabIndex = 1;
            this._bRefresh.Text = "Refresh";
            this._bRefresh.UseVisualStyleBackColor = true;
            this._bRefresh.Click += new System.EventHandler(this._bRefresh_Click);
            // 
            // _lbUserFolders
            // 
            this._lbUserFolders.AllowDrop = false;
            this._lbUserFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._lbUserFolders.BackColor = System.Drawing.SystemColors.Info;
            this._lbUserFolders.FormattingEnabled = true;
            this._lbUserFolders.Location = new System.Drawing.Point(0, 0);
            this._lbUserFolders.Margin = new System.Windows.Forms.Padding(2);
            this._lbUserFolders.Name = "_lbUserFolders";
            this._lbUserFolders.Size = new System.Drawing.Size(542, 199);
            this._lbUserFolders.TabIndex = 0;
            this._lbUserFolders.TabStop = false;
            this._lbUserFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._lbUserFolders_MouseDoubleClick);
            // 
            // _tpReferencedBy
            // 
            this._tpReferencedBy.BackColor = System.Drawing.SystemColors.Control;
            this._tpReferencedBy.Location = new System.Drawing.Point(4, 22);
            this._tpReferencedBy.Name = "_tpReferencedBy";
            this._tpReferencedBy.Padding = new System.Windows.Forms.Padding(3);
            this._tpReferencedBy.Size = new System.Drawing.Size(542, 275);
            this._tpReferencedBy.TabIndex = 2;
            this._tpReferencedBy.Text = "Referenced by";
            // 
            // _tpDescription
            // 
            this._tpDescription.BackColor = System.Drawing.SystemColors.Control;
            this._tpDescription.Controls.Add(this._eDescription);
            this._tpDescription.Location = new System.Drawing.Point(4, 22);
            this._tpDescription.Name = "_tpDescription";
            this._tpDescription.Padding = new System.Windows.Forms.Padding(3);
            this._tpDescription.Size = new System.Drawing.Size(542, 275);
            this._tpDescription.TabIndex = 1;
            this._tpDescription.Text = "Description";
            // 
            // _tpCardGeneration
            // 
            this._tpCardGeneration.BackColor = System.Drawing.SystemColors.Control;
            this._tpCardGeneration.Controls.Add(this._nudCardNumberTo);
            this._tpCardGeneration.Controls.Add(this._nudCardNumberFrom);
            this._tpCardGeneration.Controls.Add(this._bGenerate);
            this._tpCardGeneration.Controls.Add(this._pbCardGeneration);
            this._tpCardGeneration.Controls.Add(this._tbGenerationResult);
            this._tpCardGeneration.Controls.Add(this._lTo);
            this._tpCardGeneration.Controls.Add(this._lFrom);
            this._tpCardGeneration.Controls.Add(this._lCardRange);
            this._tpCardGeneration.Location = new System.Drawing.Point(4, 22);
            this._tpCardGeneration.Name = "_tpCardGeneration";
            this._tpCardGeneration.Size = new System.Drawing.Size(542, 275);
            this._tpCardGeneration.TabIndex = 5;
            this._tpCardGeneration.Text = "Card serie";
            // 
            // _nudCardNumberTo
            // 
            this._nudCardNumberTo.Location = new System.Drawing.Point(255, 28);
            this._nudCardNumberTo.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._nudCardNumberTo.Name = "_nudCardNumberTo";
            this._nudCardNumberTo.Size = new System.Drawing.Size(120, 20);
            this._nudCardNumberTo.TabIndex = 4;
            this._nudCardNumberTo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._nudCardNumberTo.ValueChanged += new System.EventHandler(this._nudCardNumberTo_ValueChanged);
            // 
            // _nudCardNumberFrom
            // 
            this._nudCardNumberFrom.Location = new System.Drawing.Point(62, 28);
            this._nudCardNumberFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudCardNumberFrom.Name = "_nudCardNumberFrom";
            this._nudCardNumberFrom.Size = new System.Drawing.Size(120, 20);
            this._nudCardNumberFrom.TabIndex = 4;
            this._nudCardNumberFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudCardNumberFrom.ValueChanged += new System.EventHandler(this._nudCardNumberFrom_ValueChanged);
            // 
            // _bGenerate
            // 
            this._bGenerate.Location = new System.Drawing.Point(464, 28);
            this._bGenerate.Name = "_bGenerate";
            this._bGenerate.Size = new System.Drawing.Size(75, 23);
            this._bGenerate.TabIndex = 3;
            this._bGenerate.Text = "Generate";
            this._bGenerate.UseVisualStyleBackColor = true;
            this._bGenerate.Click += new System.EventHandler(this._bGenerate_Click);
            // 
            // _pbCardGeneration
            // 
            this._pbCardGeneration.Location = new System.Drawing.Point(4, 223);
            this._pbCardGeneration.Name = "_pbCardGeneration";
            this._pbCardGeneration.Size = new System.Drawing.Size(535, 10);
            this._pbCardGeneration.TabIndex = 2;
            // 
            // _tbGenerationResult
            // 
            this._tbGenerationResult.Location = new System.Drawing.Point(6, 57);
            this._tbGenerationResult.Multiline = true;
            this._tbGenerationResult.Name = "_tbGenerationResult";
            this._tbGenerationResult.ReadOnly = true;
            this._tbGenerationResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._tbGenerationResult.Size = new System.Drawing.Size(533, 163);
            this._tbGenerationResult.TabIndex = 1;
            // 
            // _lTo
            // 
            this._lTo.AutoSize = true;
            this._lTo.Location = new System.Drawing.Point(188, 30);
            this._lTo.Name = "_lTo";
            this._lTo.Size = new System.Drawing.Size(20, 13);
            this._lTo.TabIndex = 0;
            this._lTo.Text = "To";
            // 
            // _lFrom
            // 
            this._lFrom.AutoSize = true;
            this._lFrom.Location = new System.Drawing.Point(3, 30);
            this._lFrom.Name = "_lFrom";
            this._lFrom.Size = new System.Drawing.Size(30, 13);
            this._lFrom.TabIndex = 0;
            this._lFrom.Text = "From";
            // 
            // _lCardRange
            // 
            this._lCardRange.AutoSize = true;
            this._lCardRange.Location = new System.Drawing.Point(1, 12);
            this._lCardRange.Name = "_lCardRange";
            this._lCardRange.Size = new System.Drawing.Size(97, 13);
            this._lCardRange.TabIndex = 0;
            this._lCardRange.Text = "Card number range";
            // 
            // _lName
            // 
            this._lName.AutoSize = true;
            this._lName.Location = new System.Drawing.Point(12, 15);
            this._lName.Name = "_lName";
            this._lName.Size = new System.Drawing.Size(35, 13);
            this._lName.TabIndex = 0;
            this._lName.Text = "Name";
            // 
            // _eName
            // 
            this._eName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._eName.Location = new System.Drawing.Point(78, 12);
            this._eName.Name = "_eName";
            this._eName.Size = new System.Drawing.Size(294, 20);
            this._eName.TabIndex = 1;
            this._eName.TextChanged += new System.EventHandler(this.EditTextChangerOnlyInDatabase);
            // 
            // _bCreate
            // 
            this._bCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bCreate.Location = new System.Drawing.Point(482, 550);
            this._bCreate.Name = "_bCreate";
            this._bCreate.Size = new System.Drawing.Size(80, 22);
            this._bCreate.TabIndex = 6;
            this._bCreate.Text = "Create";
            this._bCreate.UseVisualStyleBackColor = true;
            this._bCreate.Click += new System.EventHandler(this._bCreate_Click);
            // 
            // _panelBack
            // 
            this._panelBack.Controls.Add(this._tcCardSystem);
            this._panelBack.Controls.Add(this._bCreate);
            this._panelBack.Controls.Add(this._bOk);
            this._panelBack.Controls.Add(this._bCancel);
            this._panelBack.Controls.Add(this._lCards);
            this._panelBack.Controls.Add(this._lbCards);
            this._panelBack.Controls.Add(this._eFilterCards);
            this._panelBack.Controls.Add(this._eName);
            this._panelBack.Controls.Add(this._lName);
            this._panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelBack.Location = new System.Drawing.Point(0, 0);
            this._panelBack.Name = "_panelBack";
            this._panelBack.Size = new System.Drawing.Size(574, 612);
            this._panelBack.TabIndex = 0;
            // 
            // CardSystemsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(574, 612);
            this.Controls.Add(this._panelBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(582, 620);
            this.Name = "CardSystemsEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CardsSystemEditForm";
            this.Load += new System.EventHandler(this.CardSystemsEditForm_Load);
            this._tcCardSystem.ResumeLayout(false);
            this._tpProperties.ResumeLayout(false);
            this._tpProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbCardDataLength)).EndInit();
            this._tpSmartCardData.ResumeLayout(false);
            this._tpSmartCardData.PerformLayout();
            this._tlpAidAndKeys.ResumeLayout(false);
            this._tlpAidAndKeys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvSectors)).EndInit();
            this._tpUserFolders.ResumeLayout(false);
            this._tpDescription.ResumeLayout(false);
            this._tpDescription.PerformLayout();
            this._tpCardGeneration.ResumeLayout(false);
            this._tpCardGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudCardNumberTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCardNumberFrom)).EndInit();
            this._panelBack.ResumeLayout(false);
            this._panelBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _eDescription;
        private System.Windows.Forms.Button _bCancel;
        private System.Windows.Forms.Button _bOk;
        private System.Windows.Forms.Label _lCards;
        private System.Windows.Forms.TextBox _eFilterCards;
        private System.Windows.Forms.ListBox _lbCards;
        private System.Windows.Forms.TabControl _tcCardSystem;
        private System.Windows.Forms.TabPage _tpProperties;
        private System.Windows.Forms.Label _lActualFullCompanyCode;
        private System.Windows.Forms.Label _lFullCompanyCode;
        private System.Windows.Forms.ComboBox _cbCardSubType;
        private System.Windows.Forms.Label _lCardSubType;
        private System.Windows.Forms.Label _lCardDataLengthActual;
        private System.Windows.Forms.TrackBar _tbCardDataLength;
        private System.Windows.Forms.Label _lCompanyCodeLengthActual;
        private System.Windows.Forms.ComboBox _cbCardType;
        private System.Windows.Forms.Label _lCardType;
        private System.Windows.Forms.Label _lCompanyCode;
        private System.Windows.Forms.TextBox _eCompanyCode;
        private System.Windows.Forms.Label _lCompanyCodeLength;
        private System.Windows.Forms.Label _lCardDataLength;
        private System.Windows.Forms.Label _lName;
        private System.Windows.Forms.TextBox _eName;
        private System.Windows.Forms.TabPage _tpDescription;
        private System.Windows.Forms.Button _bCreate;
        private System.Windows.Forms.Panel _panelBack;
        private System.Windows.Forms.TabPage _tpReferencedBy;
        private System.Windows.Forms.TabPage _tpUserFolders;
        private System.Windows.Forms.Button _bRefresh;
        private Contal.IwQuick.UI.ImageListBox _lbUserFolders;
        private System.Windows.Forms.TabPage _tpSmartCardData;
        private System.Windows.Forms.TextBox _eAid;
        private System.Windows.Forms.Label _lAid;
        private System.Windows.Forms.Label _lBkey;
        private System.Windows.Forms.Label _lAkey;
        private System.Windows.Forms.TextBox _eBkey;
        private System.Windows.Forms.TextBox _eAkey;
        private System.Windows.Forms.Label _lEncoding;
        private System.Windows.Forms.ComboBox _cbEncoding;
        private System.Windows.Forms.CheckBox _cbExplicitSmartCardDataPopulation;
        private System.Windows.Forms.TabPage _tpCardGeneration;
        private System.Windows.Forms.TextBox _tbGenerationResult;
        private System.Windows.Forms.Label _lTo;
        private System.Windows.Forms.Label _lFrom;
        private System.Windows.Forms.Label _lCardRange;
        private System.Windows.Forms.ProgressBar _pbCardGeneration;
        private System.Windows.Forms.Button _bGenerate;
        private System.Windows.Forms.NumericUpDown _nudCardNumberTo;
        private System.Windows.Forms.NumericUpDown _nudCardNumberFrom;
        private System.Windows.Forms.ComboBox _cbSize;
        private System.Windows.Forms.Label _lSize;
        private System.Windows.Forms.DataGridView _dgvSectors;
        private System.Windows.Forms.TableLayoutPanel _tlpAidAndKeys;
    }
}