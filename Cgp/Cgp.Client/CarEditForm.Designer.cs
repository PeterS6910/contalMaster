namespace Contal.Cgp.Client
{
    partial class CarEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox _eLp;
        private System.Windows.Forms.TextBox _eBrand;
        private System.Windows.Forms.TextBox _eDescription;
        private System.Windows.Forms.ComboBox _cbSecurityLevel;
        private System.Windows.Forms.TextBox _eUtcDateStateLastChange;
        private System.Windows.Forms.Button _bOk;
        private System.Windows.Forms.Button _bCancel;
        private System.Windows.Forms.TabControl _tcCar;
        private System.Windows.Forms.TabPage _tpInformation;
        private System.Windows.Forms.TabPage _tpCards;
        private System.Windows.Forms.ListView _lvAssignedCards;
        private System.Windows.Forms.ListView _lvAvailableCards;
        private System.Windows.Forms.Button _bAssignCard;
        private System.Windows.Forms.Button _bUnassignCard;
        private System.Windows.Forms.Label _lAssignedCards;
        private System.Windows.Forms.Label _lAvailableCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private IwQuick.UI.TextBoxDatePicker _dpValidityDateFrom;
        private IwQuick.UI.TextBoxDatePicker _dpValidityDateTo;

        private void InitializeComponent()
        {
            this._eLp = new System.Windows.Forms.TextBox();
            this._eBrand = new System.Windows.Forms.TextBox();
            this._eDescription = new System.Windows.Forms.TextBox();
            this._cbSecurityLevel = new System.Windows.Forms.ComboBox();
            this._eUtcDateStateLastChange = new System.Windows.Forms.TextBox();
            this._bOk = new System.Windows.Forms.Button();
            this._bCancel = new System.Windows.Forms.Button();
            this._tcCar = new System.Windows.Forms.TabControl();
            this._tpInformation = new System.Windows.Forms.TabPage();
            this._dpValidityDateTo = new Contal.IwQuick.UI.TextBoxDatePicker();
            this._dpValidityDateFrom = new Contal.IwQuick.UI.TextBoxDatePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._tpCards = new System.Windows.Forms.TabPage();
            this._lAvailableCards = new System.Windows.Forms.Label();
            this._lAssignedCards = new System.Windows.Forms.Label();
            this._bUnassignCard = new System.Windows.Forms.Button();
            this._bAssignCard = new System.Windows.Forms.Button();
            this._lvAvailableCards = new System.Windows.Forms.ListView();
            this._lvAssignedCards = new System.Windows.Forms.ListView();
            this._tcCar.SuspendLayout();
            this._tpInformation.SuspendLayout();
            this._tpCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // _eLp
            // 
            this._eLp.Location = new System.Drawing.Point(258, 12);
            this._eLp.Name = "_eLp";
            this._eLp.Size = new System.Drawing.Size(260, 26);
            this._eLp.TabIndex = 4;
            this._eLp.Tag = "s";
            // 
            // _eBrand
            // 
            this._eBrand.Location = new System.Drawing.Point(259, 55);
            this._eBrand.Name = "_eBrand";
            this._eBrand.Size = new System.Drawing.Size(260, 26);
            this._eBrand.TabIndex = 3;
            // 
            // _eDescription
            // 
            this._eDescription.Location = new System.Drawing.Point(259, 292);
            this._eDescription.Name = "_eDescription";
            this._eDescription.Size = new System.Drawing.Size(260, 26);
            this._eDescription.TabIndex = 2;
            // 
            // _cbSecurityLevel
            // 
            this._cbSecurityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSecurityLevel.FormattingEnabled = true;
            this._cbSecurityLevel.Location = new System.Drawing.Point(258, 197);
            this._cbSecurityLevel.Name = "_cbSecurityLevel";
            this._cbSecurityLevel.Size = new System.Drawing.Size(260, 28);
            this._cbSecurityLevel.TabIndex = 7;
            // 
            // _eUtcDateStateLastChange
            // 
            this._eUtcDateStateLastChange.Location = new System.Drawing.Point(258, 242);
            this._eUtcDateStateLastChange.Name = "_eUtcDateStateLastChange";
            this._eUtcDateStateLastChange.Size = new System.Drawing.Size(260, 26);
            this._eUtcDateStateLastChange.TabIndex = 9;
            // 
            // _bOk
            // 
            this._bOk.Location = new System.Drawing.Point(444, 386);
            this._bOk.Name = "_bOk";
            this._bOk.Size = new System.Drawing.Size(75, 30);
            this._bOk.TabIndex = 1;
            this._bOk.Text = "OK";
            this._bOk.Click += new System.EventHandler(this._bOk_Click);
            // 
            // _bCancel
            // 
            this._bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._bCancel.Location = new System.Drawing.Point(280, 386);
            this._bCancel.Name = "_bCancel";
            this._bCancel.Size = new System.Drawing.Size(75, 30);
            this._bCancel.TabIndex = 0;
            this._bCancel.Text = "Cancel";
            this._bCancel.Click += new System.EventHandler(this._bCancel_Click);
            // 
            // _tcCar
            // 
            this._tcCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tcCar.Controls.Add(this._tpInformation);
            this._tcCar.Controls.Add(this._tpCards);
            this._tcCar.Location = new System.Drawing.Point(12, 12);
            this._tcCar.Name = "_tcCar";
            this._tcCar.SelectedIndex = 0;
            this._tcCar.Size = new System.Drawing.Size(596, 369);
            this._tcCar.TabIndex = 2;
            this._tcCar.TabStop = false;
            this._tcCar.SelectedIndexChanged += new System.EventHandler(this._tcCar_SelectedIndexChanged);
            // 
            // _tpInformation
            //             
            this._tpInformation.Controls.Add(this._dpValidityDateTo);
            this._tpInformation.Controls.Add(this._dpValidityDateFrom);
            this._tpInformation.Controls.Add(this.label8);
            this._tpInformation.Controls.Add(this.label6);
            this._tpInformation.Controls.Add(this.label5);
            this._tpInformation.Controls.Add(this.label4);
            this._tpInformation.Controls.Add(this.label3);
            this._tpInformation.Controls.Add(this.label2);
            this._tpInformation.Controls.Add(this.label1);
            this._tpInformation.Controls.Add(this._eUtcDateStateLastChange);
            this._tpInformation.Controls.Add(this._cbSecurityLevel);
            this._tpInformation.Controls.Add(this._eDescription);
            this._tpInformation.Controls.Add(this._eBrand);
            this._tpInformation.Controls.Add(this._eLp);
            this._tpInformation.Location = new System.Drawing.Point(4, 29);
            this._tpInformation.Name = "_tpInformation";
            this._tpInformation.Padding = new System.Windows.Forms.Padding(3);
            this._tpInformation.Size = new System.Drawing.Size(588, 323);
            this._tpInformation.TabIndex = 0;
            this._tpInformation.Text = "Information";
            // 
            // _dpValidityDateTo
            // 
            this._dpValidityDateTo.addActualTime = false;
            this._dpValidityDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));            
            this._dpValidityDateTo.ButtonClearDateImage = null;
            this._dpValidityDateTo.ButtonClearDateText = "";
            this._dpValidityDateTo.ButtonClearDateWidth = 23;
            this._dpValidityDateTo.ButtonDateImage = null;
            this._dpValidityDateTo.ButtonDateText = "";
            this._dpValidityDateTo.ButtonDateWidth = 23;
            this._dpValidityDateTo.CustomFormat = "d. M. yyyy HH:mm:ss";
            this._dpValidityDateTo.DateFormName = "Calendar";
            this._dpValidityDateTo.LocalizationHelper = null;
            this._dpValidityDateTo.Location = new System.Drawing.Point(258, 147);
            this._dpValidityDateTo.Margin = new System.Windows.Forms.Padding(4);
            this._dpValidityDateTo.MaximumSize = new System.Drawing.Size(1500, 90);
            this._dpValidityDateTo.MinimumSize = new System.Drawing.Size(180, 33);
            this._dpValidityDateTo.Name = "_dpValidityDateTo";
            this._dpValidityDateTo.ReadOnly = false;
            this._dpValidityDateTo.SelectTime = Contal.IwQuick.UI.SelectedTimeOfDay.StartOfDay;
            this._dpValidityDateTo.Size = new System.Drawing.Size(321, 33);
            this._dpValidityDateTo.TabIndex = 26;
            this._dpValidityDateTo.ValidateAfter = 2D;
            this._dpValidityDateTo.ValidationEnabled = false;
            this._dpValidityDateTo.ValidationError = "";
            this._dpValidityDateTo.Value = null;
            // 
            // _dpValidityDateFrom
            // 
            this._dpValidityDateFrom.addActualTime = false;
            this._dpValidityDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));            
            this._dpValidityDateFrom.ButtonClearDateImage = null;
            this._dpValidityDateFrom.ButtonClearDateText = "";
            this._dpValidityDateFrom.ButtonClearDateWidth = 23;
            this._dpValidityDateFrom.ButtonDateImage = null;
            this._dpValidityDateFrom.ButtonDateText = "";
            this._dpValidityDateFrom.ButtonDateWidth = 23;
            this._dpValidityDateFrom.CustomFormat = "d. M. yyyy HH:mm:ss";
            this._dpValidityDateFrom.DateFormName = "Calendar";
            this._dpValidityDateFrom.LocalizationHelper = null;
            this._dpValidityDateFrom.Location = new System.Drawing.Point(259, 91);
            this._dpValidityDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this._dpValidityDateFrom.MaximumSize = new System.Drawing.Size(1500, 90);
            this._dpValidityDateFrom.MinimumSize = new System.Drawing.Size(180, 33);
            this._dpValidityDateFrom.Name = "_dpValidityDateFrom";
            this._dpValidityDateFrom.ReadOnly = false;
            this._dpValidityDateFrom.SelectTime = Contal.IwQuick.UI.SelectedTimeOfDay.StartOfDay;
            this._dpValidityDateFrom.Size = new System.Drawing.Size(321, 33);
            this._dpValidityDateFrom.TabIndex = 25;
            this._dpValidityDateFrom.ValidateAfter = 2D;
            this._dpValidityDateFrom.ValidationEnabled = false;
            this._dpValidityDateFrom.ValidationError = "";
            this._dpValidityDateFrom.Value = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Version";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Security Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Validate Date To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Validate Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ŠPZ - LP";
            // 
            // _tpCards
            //             
            this._tpCards.Controls.Add(this._lAvailableCards);
            this._tpCards.Controls.Add(this._lAssignedCards);
            this._tpCards.Controls.Add(this._bUnassignCard);
            this._tpCards.Controls.Add(this._bAssignCard);
            this._tpCards.Controls.Add(this._lvAvailableCards);
            this._tpCards.Controls.Add(this._lvAssignedCards);
            this._tpCards.Location = new System.Drawing.Point(4, 29);
            this._tpCards.Name = "_tpCards";
            this._tpCards.Padding = new System.Windows.Forms.Padding(3);
            this._tpCards.Size = new System.Drawing.Size(588, 336);
            this._tpCards.TabIndex = 1;
            this._tpCards.Text = "Cards";
            // 
            // _lAvailableCards
            // 
            this._lAvailableCards.AutoSize = true;
            this._lAvailableCards.Location = new System.Drawing.Point(352, 9);
            this._lAvailableCards.Name = "_lAvailableCards";
            this._lAvailableCards.Size = new System.Drawing.Size(72, 20);
            this._lAvailableCards.TabIndex = 5;
            this._lAvailableCards.Text = "Available";
            // 
            // _lAssignedCards
            // 
            this._lAssignedCards.AutoSize = true;
            this._lAssignedCards.Location = new System.Drawing.Point(6, 9);
            this._lAssignedCards.Name = "_lAssignedCards";
            this._lAssignedCards.Size = new System.Drawing.Size(75, 20);
            this._lAssignedCards.TabIndex = 4;
            this._lAssignedCards.Text = "Assigned";
            // 
            // _bUnassignCard
            // 
            this._bUnassignCard.Location = new System.Drawing.Point(250, 94);
            this._bUnassignCard.Name = "_bUnassignCard";
            this._bUnassignCard.Size = new System.Drawing.Size(90, 30);
            this._bUnassignCard.TabIndex = 3;
            this._bUnassignCard.Text = "<<";
            this._bUnassignCard.UseVisualStyleBackColor = true;
            this._bUnassignCard.Click += new System.EventHandler(this._bUnassignCard_Click);
            // 
            // _bAssignCard
            // 
            this._bAssignCard.Location = new System.Drawing.Point(250, 194);
            this._bAssignCard.Name = "_bAssignCard";
            this._bAssignCard.Size = new System.Drawing.Size(90, 30);
            this._bAssignCard.TabIndex = 2;
            this._bAssignCard.Text = ">>";
            this._bAssignCard.UseVisualStyleBackColor = true;
            this._bAssignCard.Click += new System.EventHandler(this._bAssignCard_Click);
            // 
            // _lvAvailableCards
            // 
            this._lvAvailableCards.HideSelection = false;
            this._lvAvailableCards.Location = new System.Drawing.Point(352, 29);
            this._lvAvailableCards.Name = "_lvAvailableCards";
            this._lvAvailableCards.Size = new System.Drawing.Size(230, 260);
            this._lvAvailableCards.TabIndex = 1;
            this._lvAvailableCards.UseCompatibleStateImageBehavior = false;
            this._lvAvailableCards.View = System.Windows.Forms.View.List;
            // 
            // _lvAssignedCards
            // 
            this._lvAssignedCards.HideSelection = false;
            this._lvAssignedCards.Location = new System.Drawing.Point(6, 29);
            this._lvAssignedCards.Name = "_lvAssignedCards";
            this._lvAssignedCards.Size = new System.Drawing.Size(230, 260);
            this._lvAssignedCards.TabIndex = 0;
            this._lvAssignedCards.UseCompatibleStateImageBehavior = false;
            this._lvAssignedCards.View = System.Windows.Forms.View.List;
            // 
            // CarEditForm
            // 
            this.AcceptButton = this._bOk;
            this.CancelButton = this._bCancel;
            this.ClientSize = new System.Drawing.Size(620, 426);
            this.Controls.Add(this._tcCar);
            this.Controls.Add(this._bCancel);
            this.Controls.Add(this._bOk);
            this.Name = "CarEditForm";
            this._tcCar.ResumeLayout(false);
            this._tpInformation.ResumeLayout(false);
            this._tpInformation.PerformLayout();
            this._tpCards.ResumeLayout(false);
            this._tpCards.PerformLayout();
            this.ResumeLayout(false);

        }

      
    }
}
