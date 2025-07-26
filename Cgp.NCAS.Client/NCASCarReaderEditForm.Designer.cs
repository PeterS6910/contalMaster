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
            this._lDescription = new System.Windows.Forms.Label();
            this._eDescription = new System.Windows.Forms.TextBox();
            this._lAlarmArcs = new System.Windows.Forms.Label();
            this._cmaaAlarmArcs = new Contal.Cgp.NCAS.Client.ControlModifyAlarmArcs();
            this._bOk = new System.Windows.Forms.Button();
            this._bCancel = new System.Windows.Forms.Button();
            this._panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudPort)).BeginInit();
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
            this._panelBack.Controls.Add(this._lDescription, 0, 6);
            this._panelBack.Controls.Add(this._eDescription, 1, 6);
            this._panelBack.Controls.Add(this._lAlarmArcs, 0, 7);
            this._panelBack.Controls.Add(this._cmaaAlarmArcs, 1, 7);
            this._panelBack.Location = new System.Drawing.Point(12, 12);
            this._panelBack.Name = "_panelBack";
            this._panelBack.RowCount = 8;
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._panelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._panelBack.Size = new System.Drawing.Size(420, 270);
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
            // _lDescription
            // 
            this._lDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lDescription.AutoSize = true;
            this._lDescription.Location = new System.Drawing.Point(3, 156);
            this._lDescription.Name = "_lDescription";
            this._lDescription.Size = new System.Drawing.Size(60, 13);
            this._lDescription.TabIndex = 12;
            this._lDescription.Text = "Description";
            // 
            // _eDescription
            // 
            this._eDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._eDescription.Location = new System.Drawing.Point(129, 153);
            this._eDescription.Multiline = true;
            this._eDescription.Name = "_eDescription";
            this._eDescription.Size = new System.Drawing.Size(288, 54);
            this._eDescription.TabIndex = 13;
            // 
            // _lAlarmArcs
            // 
            this._lAlarmArcs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lAlarmArcs.AutoSize = true;
            this._lAlarmArcs.Location = new System.Drawing.Point(3, 218);
            this._lAlarmArcs.Name = "_lAlarmArcs";
            this._lAlarmArcs.Size = new System.Drawing.Size(58, 13);
            this._lAlarmArcs.TabIndex = 14;
            this._lAlarmArcs.Text = "Alarm arcs";
            // 
            // _cmaaAlarmArcs
            // 
            this._cmaaAlarmArcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cmaaAlarmArcs.Location = new System.Drawing.Point(129, 213);
            this._cmaaAlarmArcs.Name = "_cmaaAlarmArcs";
            this._cmaaAlarmArcs.Size = new System.Drawing.Size(288, 54);
            this._cmaaAlarmArcs.TabIndex = 15;
            // 
            // _bOk
            // 
            this._bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bOk.Location = new System.Drawing.Point(276, 288);
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
            this._bCancel.Location = new System.Drawing.Point(357, 288);
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
            this.ClientSize = new System.Drawing.Size(444, 323);
            this.Controls.Add(this._bCancel);
            this.Controls.Add(this._bOk);
            this.Controls.Add(this._panelBack);
            this.Name = "NCASCarReaderEditForm";
            this.Text = "NCASCarReaderEditForm";
            this._panelBack.ResumeLayout(false);
            this._panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudPort)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
