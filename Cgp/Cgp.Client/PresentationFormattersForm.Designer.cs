namespace Contal.Cgp.Client
{
    partial class PresentationFormattersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentationFormattersForm));
            this._cdgvData = new Contal.Cgp.Components.CgpDataGridView();
            this._pFilter = new System.Windows.Forms.Panel();
            this._eFormatterNameFilter = new System.Windows.Forms.TextBox();
            this._eFormatterMessageFilter = new System.Windows.Forms.TextBox();
            this._lFormatterNameFilter = new System.Windows.Forms.Label();
            this._lMsgFormattlFilter = new System.Windows.Forms.Label();
            this._bRunFilter = new System.Windows.Forms.Button();
            this._bFilterClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).BeginInit();
            this._pFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cdgvData
            // 
            this._cdgvData.AllwaysRefreshOrder = false;
            this._cdgvData.CgpDataGridEvents = null;
            this._cdgvData.CopyOnRightClick = true;
            // 
            // 
            // 
            this._cdgvData.DataGrid.AllowUserToAddRows = false;
            this._cdgvData.DataGrid.AllowUserToDeleteRows = false;
            this._cdgvData.DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cdgvData.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._cdgvData.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._cdgvData.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._cdgvData.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.DataGrid.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.DataGrid.Name = "_dgvData";
            this._cdgvData.DataGrid.ReadOnly = true;
            this._cdgvData.DataGrid.RowHeadersVisible = false;
            this._cdgvData.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this._cdgvData.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._cdgvData.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._cdgvData.DataGrid.Size = new System.Drawing.Size(777, 241);
            this._cdgvData.DataGrid.TabIndex = 0;
            this._cdgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.LocalizationHelper = null;
            this._cdgvData.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.Name = "_cdgvData";
            this._cdgvData.Size = new System.Drawing.Size(777, 241);
            this._cdgvData.TabIndex = 1;
            // 
            // _pFilter
            // 
            this._pFilter.Controls.Add(this._bFilterClear);
            this._pFilter.Controls.Add(this._bRunFilter);
            this._pFilter.Controls.Add(this._lMsgFormattlFilter);
            this._pFilter.Controls.Add(this._lFormatterNameFilter);
            this._pFilter.Controls.Add(this._eFormatterMessageFilter);
            this._pFilter.Controls.Add(this._eFormatterNameFilter);
            this._pFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this._pFilter.Location = new System.Drawing.Point(0, 0);
            this._pFilter.Name = "_pFilter";
            this._pFilter.Size = new System.Drawing.Size(777, 46);
            this._pFilter.TabIndex = 0;
            // 
            // _eFormatterNameFilter
            // 
            this._eFormatterNameFilter.Location = new System.Drawing.Point(8, 21);
            this._eFormatterNameFilter.Name = "_eFormatterNameFilter";
            this._eFormatterNameFilter.Size = new System.Drawing.Size(167, 20);
            this._eFormatterNameFilter.TabIndex = 0;
            this._eFormatterNameFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            this._eFormatterNameFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterKeyDown);
            // 
            // _eFormatterMessageFilter
            // 
            this._eFormatterMessageFilter.Location = new System.Drawing.Point(181, 20);
            this._eFormatterMessageFilter.Name = "_eFormatterMessageFilter";
            this._eFormatterMessageFilter.Size = new System.Drawing.Size(147, 20);
            this._eFormatterMessageFilter.TabIndex = 1;
            this._eFormatterMessageFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            this._eFormatterMessageFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterKeyDown);
            // 
            // _lFormatterNameFilter
            // 
            this._lFormatterNameFilter.AutoSize = true;
            this._lFormatterNameFilter.Location = new System.Drawing.Point(8, 5);
            this._lFormatterNameFilter.Name = "_lFormatterNameFilter";
            this._lFormatterNameFilter.Size = new System.Drawing.Size(80, 13);
            this._lFormatterNameFilter.TabIndex = 0;
            this._lFormatterNameFilter.Text = "Formatter name";
            // 
            // _lMsgFormattlFilter
            // 
            this._lMsgFormattlFilter.AutoSize = true;
            this._lMsgFormattlFilter.Location = new System.Drawing.Point(178, 4);
            this._lMsgFormattlFilter.Name = "_lMsgFormattlFilter";
            this._lMsgFormattlFilter.Size = new System.Drawing.Size(82, 13);
            this._lMsgFormattlFilter.TabIndex = 2;
            this._lMsgFormattlFilter.Text = "Message format";
            // 
            // _bRunFilter
            // 
            this._bRunFilter.Location = new System.Drawing.Point(334, 18);
            this._bRunFilter.Name = "_bRunFilter";
            this._bRunFilter.Size = new System.Drawing.Size(75, 23);
            this._bRunFilter.TabIndex = 2;
            this._bRunFilter.Text = "Filter";
            this._bRunFilter.UseVisualStyleBackColor = true;
            this._bRunFilter.Click += new System.EventHandler(this.RunFilterClick);
            // 
            // _bFilterClear
            // 
            this._bFilterClear.Location = new System.Drawing.Point(415, 18);
            this._bFilterClear.Name = "_bFilterClear";
            this._bFilterClear.Size = new System.Drawing.Size(75, 23);
            this._bFilterClear.TabIndex = 3;
            this._bFilterClear.Text = "Clear";
            this._bFilterClear.UseVisualStyleBackColor = true;
            this._bFilterClear.Click += new System.EventHandler(this.FilterClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._pFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 48);
            this.panel1.TabIndex = 0;
            // 
            // PresentationFormattersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(777, 289);
            this.Controls.Add(this._cdgvData);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PresentationFormattersForm";
            this.Text = "PresentationFormattersForm";
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).EndInit();
            this._pFilter.ResumeLayout(false);
            this._pFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Contal.Cgp.Components.CgpDataGridView _cdgvData;
        private System.Windows.Forms.Panel _pFilter;
        private System.Windows.Forms.Button _bFilterClear;
        private System.Windows.Forms.Button _bRunFilter;
        private System.Windows.Forms.Label _lMsgFormattlFilter;
        private System.Windows.Forms.Label _lFormatterNameFilter;
        private System.Windows.Forms.TextBox _eFormatterMessageFilter;
        private System.Windows.Forms.TextBox _eFormatterNameFilter;
        private System.Windows.Forms.Panel panel1;
    }
}