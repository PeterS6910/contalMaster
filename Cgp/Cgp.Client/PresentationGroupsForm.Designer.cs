namespace Contal.Cgp.Client
{
    partial class PresentationGroupsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentationGroupsForm));
            this._cdgvData = new Contal.Cgp.Components.CgpDataGridView();
            this._pFilter = new System.Windows.Forms.Panel();
            this._lRecordCount = new System.Windows.Forms.Label();
            this._eGroupNameFilter = new System.Windows.Forms.TextBox();
            this._eEmailFilter = new System.Windows.Forms.TextBox();
            this._lNameFilter = new System.Windows.Forms.Label();
            this._lEmailFilter = new System.Windows.Forms.Label();
            this._bRunFilter = new System.Windows.Forms.Button();
            this._bFilterClear = new System.Windows.Forms.Button();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._pFilter.SuspendLayout();
            this._splitContainer.SuspendLayout();
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
            this._cdgvData.DataGrid.ColumnHeadersHeight = 34;
            this._cdgvData.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._cdgvData.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.DataGrid.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.DataGrid.Name = "_dgvData";
            this._cdgvData.DataGrid.ReadOnly = true;
            this._cdgvData.DataGrid.RowHeadersVisible = false;
            this._cdgvData.DataGrid.RowHeadersWidth = 62;
            this._cdgvData.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this._cdgvData.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._cdgvData.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._cdgvData.DataGrid.Size = new System.Drawing.Size(835, 441);
            this._cdgvData.DataGrid.TabIndex = 0;
            this._cdgvData.DefaultSortColumnName = null;
            this._cdgvData.DefaultSortDirection = System.ComponentModel.ListSortDirection.Ascending;
            this._cdgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.LocalizationHelper = null;
            this._cdgvData.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.Name = "_cdgvData";
            this._cdgvData.Size = new System.Drawing.Size(835, 441);
            this._cdgvData.TabIndex = 5;
            // 
            // _pFilter
            // 
            this._pFilter.Controls.Add(this._lRecordCount);
            this._pFilter.Controls.Add(this._bFilterClear);
            this._pFilter.Controls.Add(this._bRunFilter);
            this._pFilter.Controls.Add(this._lEmailFilter);
            this._pFilter.Controls.Add(this._lNameFilter);
            this._pFilter.Controls.Add(this._eEmailFilter);
            this._pFilter.Controls.Add(this._eGroupNameFilter);
            this._pFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pFilter.Location = new System.Drawing.Point(0, 0);
            this._pFilter.Name = "_pFilter";
            this._pFilter.Size = new System.Drawing.Size(835, 46);
            this._pFilter.TabIndex = 0;
            // 
            // _lRecordCount
            // 
            this._lRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lRecordCount.AutoSize = true;
            this._lRecordCount.Location = new System.Drawing.Point(680, 24);
            this._lRecordCount.Name = "_lRecordCount";
            this._lRecordCount.Size = new System.Drawing.Size(0, 20);
            this._lRecordCount.TabIndex = 5;
            // 
            // _bFilterClear
            // 
            this._bFilterClear.Location = new System.Drawing.Point(399, 17);
            this._bFilterClear.Name = "_bFilterClear";
            this._bFilterClear.Size = new System.Drawing.Size(75, 28);
            this._bFilterClear.TabIndex = 3;
            this._bFilterClear.Text = "Clear";
            this._bFilterClear.UseVisualStyleBackColor = true;
            this._bFilterClear.Click += new System.EventHandler(this._bFilterClear_Click);
            // 
            // _bRunFilter
            // 
            this._bRunFilter.Location = new System.Drawing.Point(318, 17);
            this._bRunFilter.Name = "_bRunFilter";
            this._bRunFilter.Size = new System.Drawing.Size(75, 28);
            this._bRunFilter.TabIndex = 2;
            this._bRunFilter.Text = "Filter";
            this._bRunFilter.UseVisualStyleBackColor = true;
            this._bRunFilter.Click += new System.EventHandler(this._bRunFilter_Click);
            // 
            // _lEmailFilter
            // 
            this._lEmailFilter.AutoSize = true;
            this._lEmailFilter.Location = new System.Drawing.Point(132, 5);
            this._lEmailFilter.Name = "_lEmailFilter";
            this._lEmailFilter.Size = new System.Drawing.Size(48, 20);
            this._lEmailFilter.TabIndex = 2;
            this._lEmailFilter.Text = "Email";
            // 
            // _lNameFilter
            // 
            this._lNameFilter.AutoSize = true;
            this._lNameFilter.Location = new System.Drawing.Point(8, 5);
            this._lNameFilter.Name = "_lNameFilter";
            this._lNameFilter.Size = new System.Drawing.Size(98, 20);
            this._lNameFilter.TabIndex = 0;
            this._lNameFilter.Text = "Group name";
            // 
            // _eEmailFilter
            // 
            this._eEmailFilter.Location = new System.Drawing.Point(135, 21);
            this._eEmailFilter.Name = "_eEmailFilter";
            this._eEmailFilter.Size = new System.Drawing.Size(177, 26);
            this._eEmailFilter.TabIndex = 1;
            this._eEmailFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            this._eEmailFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterKeyDown);
            // 
            // _eGroupNameFilter
            // 
            this._eGroupNameFilter.Location = new System.Drawing.Point(8, 21);
            this._eGroupNameFilter.Name = "_eGroupNameFilter";
            this._eGroupNameFilter.Size = new System.Drawing.Size(121, 26);
            this._eGroupNameFilter.TabIndex = 0;
            this._eGroupNameFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            this._eGroupNameFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterKeyDown);
            // _splitContainer
            //
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            //
            this._splitContainer.Panel1.Controls.Add(this._cdgvData);
            this._splitContainer.Size = new System.Drawing.Size(835, 489);
            this._splitContainer.SplitterDistance = 46;
            this._splitContainer.IsSplitterFixed = false;
            this._splitContainer.TabIndex = 6;
            // 
            // _splitContainer.Panel2
            //
            this._splitContainer.Panel2.Controls.Add(this._pFilter);
            // 
            // PresentationGroupsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(835, 489);
            this.Controls.Add(this._splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PresentationGroupsForm";
            this.Text = "PresentationGroupForm";
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).EndInit();
            this._pFilter.ResumeLayout(false);
            this._pFilter.PerformLayout();
            this._splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Contal.Cgp.Components.CgpDataGridView _cdgvData;
        private System.Windows.Forms.Panel _pFilter;
        private System.Windows.Forms.Button _bFilterClear;
        private System.Windows.Forms.Button _bRunFilter;
        private System.Windows.Forms.Label _lEmailFilter;
        private System.Windows.Forms.Label _lNameFilter;
        private System.Windows.Forms.TextBox _eEmailFilter;
        private System.Windows.Forms.TextBox _eGroupNameFilter;
        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.Label _lRecordCount;
    }
}
