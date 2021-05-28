namespace RetroPlaylists
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExportFilename = new System.Windows.Forms.TextBox();
            this.btExport = new System.Windows.Forms.Button();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.btLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoadFilename = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.core_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.core_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crc32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLoad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLoadFilename);
            this.groupBox1.Controls.Add(this.dgItems);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btExport);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtExportFilename);
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // txtExportFilename
            // 
            this.txtExportFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExportFilename.Location = new System.Drawing.Point(40, 19);
            this.txtExportFilename.Name = "txtExportFilename";
            this.txtExportFilename.Size = new System.Drawing.Size(382, 26);
            this.txtExportFilename.TabIndex = 0;
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(428, 17);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(118, 28);
            this.btExport.TabIndex = 3;
            this.btExport.Text = "SAVE";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.path,
            this.label,
            this.core_path,
            this.core_name,
            this.crc32,
            this.db_name});
            this.dgItems.Location = new System.Drawing.Point(6, 51);
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.Size = new System.Drawing.Size(540, 236);
            this.dgItems.TabIndex = 1;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(428, 17);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(118, 28);
            this.btLoad.TabIndex = 6;
            this.btLoad.Text = "LOAD";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File:";
            // 
            // txtLoadFilename
            // 
            this.txtLoadFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoadFilename.Location = new System.Drawing.Point(40, 19);
            this.txtLoadFilename.Name = "txtLoadFilename";
            this.txtLoadFilename.Size = new System.Drawing.Size(382, 26);
            this.txtLoadFilename.TabIndex = 4;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "N°";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Width = 44;
            // 
            // path
            // 
            this.path.HeaderText = "Path";
            this.path.MinimumWidth = 50;
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Width = 200;
            // 
            // label
            // 
            this.label.HeaderText = "Label";
            this.label.MinimumWidth = 50;
            this.label.Name = "label";
            this.label.ReadOnly = true;
            this.label.Width = 150;
            // 
            // core_path
            // 
            this.core_path.HeaderText = "Core Path";
            this.core_path.MinimumWidth = 50;
            this.core_path.Name = "core_path";
            this.core_path.ReadOnly = true;
            // 
            // core_name
            // 
            this.core_name.HeaderText = "Core Name";
            this.core_name.MinimumWidth = 50;
            this.core_name.Name = "core_name";
            this.core_name.ReadOnly = true;
            // 
            // crc32
            // 
            this.crc32.HeaderText = "crc32";
            this.crc32.MinimumWidth = 50;
            this.crc32.Name = "crc32";
            this.crc32.ReadOnly = true;
            // 
            // db_name
            // 
            this.db_name.HeaderText = "DB Name";
            this.db_name.MinimumWidth = 50;
            this.db_name.Name = "db_name";
            this.db_name.ReadOnly = true;
            this.db_name.Width = 200;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExportFilename;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoadFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
        private System.Windows.Forms.DataGridViewTextBoxColumn core_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn core_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn crc32;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_name;
    }
}

