namespace tournament
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.полуфиналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentDataSet = new tournament.TournamentDataSet();
            this.SortBtn = new System.Windows.Forms.Button();
            this.полуфиналTableAdapter = new tournament.TournamentDataSetTableAdapters.ПолуфиналTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentDataSet34 = new tournament.TournamentDataSet34();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._3_4TableAdapter = new tournament.TournamentDataSet34TableAdapters._3_4TableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.полуфиналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.game5DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.game3DataGridViewTextBoxColumn,
            this.game4DataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.bindingSource2;
            this.DataGrid.Location = new System.Drawing.Point(32, 27);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGrid.Size = new System.Drawing.Size(466, 150);
            this.DataGrid.TabIndex = 3;
            // 
            // полуфиналBindingSource
            // 
            this.полуфиналBindingSource.DataMember = "Полуфинал";
            this.полуфиналBindingSource.DataSource = this.tournamentDataSet;
            // 
            // tournamentDataSet
            // 
            this.tournamentDataSet.DataSetName = "TournamentDataSet";
            this.tournamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SortBtn
            // 
            this.SortBtn.BackColor = System.Drawing.Color.Yellow;
            this.SortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SortBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortBtn.Location = new System.Drawing.Point(244, 308);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(77, 42);
            this.SortBtn.TabIndex = 4;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = false;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // полуфиналTableAdapter
            // 
            this.полуфиналTableAdapter.ClearBeforeFill = true;
            // 
            // tournamentDataSet34
            // 
            this.tournamentDataSet34.DataSetName = "TournamentDataSet34";
            this.tournamentDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "3/4";
            this.bindingSource2.DataSource = this.tournamentDataSet34;
            // 
            // _3_4TableAdapter
            // 
            this._3_4TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Player";
            this.dataGridViewTextBoxColumn1.HeaderText = "Player";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // game5DataGridViewTextBoxColumn
            // 
            this.game5DataGridViewTextBoxColumn.DataPropertyName = "Game 5";
            this.game5DataGridViewTextBoxColumn.HeaderText = "Game 5";
            this.game5DataGridViewTextBoxColumn.Name = "game5DataGridViewTextBoxColumn";
            this.game5DataGridViewTextBoxColumn.Width = 69;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Table";
            this.dataGridViewTextBoxColumn2.HeaderText = "Table";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Game 1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Game 1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Game 2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Game 2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 69;
            // 
            // game3DataGridViewTextBoxColumn
            // 
            this.game3DataGridViewTextBoxColumn.DataPropertyName = "Game 3";
            this.game3DataGridViewTextBoxColumn.HeaderText = "Game 3";
            this.game3DataGridViewTextBoxColumn.Name = "game3DataGridViewTextBoxColumn";
            this.game3DataGridViewTextBoxColumn.Width = 69;
            // 
            // game4DataGridViewTextBoxColumn
            // 
            this.game4DataGridViewTextBoxColumn.DataPropertyName = "Game 4";
            this.game4DataGridViewTextBoxColumn.HeaderText = "Game 4";
            this.game4DataGridViewTextBoxColumn.Name = "game4DataGridViewTextBoxColumn";
            this.game4DataGridViewTextBoxColumn.Width = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::tournament.Properties.Resources.game_of_thrones_wallpaper_wide_images_yy309i;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(650, 366);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.DataGrid);
            this.Name = "Form1";
            this.Text = "Tournament draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.полуфиналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn game1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn game2DataGridViewTextBoxColumn;
        private TournamentDataSet tournamentDataSet;
        private System.Windows.Forms.BindingSource полуфиналBindingSource;
        private TournamentDataSetTableAdapters.ПолуфиналTableAdapter полуфиналTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private TournamentDataSet34 tournamentDataSet34;
        private System.Windows.Forms.BindingSource bindingSource2;
        private TournamentDataSet34TableAdapters._3_4TableAdapter _3_4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn game5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn game3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn game4DataGridViewTextBoxColumn;
    }
}

