namespace KaktuszokGUI
{
    partial class FrmKaktusz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUI01 = new Label();
            tbxSzures = new TextBox();
            dgvKaktuszok = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvKaktuszok).BeginInit();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUI01.Location = new Point(12, 29);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(137, 19);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Szűrés név alapján:";
            // 
            // tbxSzures
            // 
            tbxSzures.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSzures.Location = new Point(155, 26);
            tbxSzures.Name = "tbxSzures";
            tbxSzures.Size = new Size(502, 25);
            tbxSzures.TabIndex = 1;
            // 
            // dgvKaktuszok
            // 
            dgvKaktuszok.AllowUserToAddRows = false;
            dgvKaktuszok.AllowUserToDeleteRows = false;
            dgvKaktuszok.AllowUserToResizeColumns = false;
            dgvKaktuszok.AllowUserToResizeRows = false;
            dgvKaktuszok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKaktuszok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKaktuszok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaktuszok.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvKaktuszok.Location = new Point(12, 75);
            dgvKaktuszok.Name = "dgvKaktuszok";
            dgvKaktuszok.RowHeadersVisible = false;
            dgvKaktuszok.RowTemplate.Height = 25;
            dgvKaktuszok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKaktuszok.Size = new Size(645, 363);
            dgvKaktuszok.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.FillWeight = 200F;
            Column2.HeaderText = "név";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "tud";
            Column3.Name = "Column3";
            Column3.Visible = false;
            // 
            // Column4
            // 
            Column4.HeaderText = "nehézség";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "vízigény";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "fényigény";
            Column6.Name = "Column6";
            // 
            // FrmKaktusz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(669, 450);
            Controls.Add(dgvKaktuszok);
            Controls.Add(tbxSzures);
            Controls.Add(lblUI01);
            Name = "FrmKaktusz";
            Text = "KaktuszokGUI";
            ((System.ComponentModel.ISupportInitialize)dgvKaktuszok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxSzures;
        private DataGridView dgvKaktuszok;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}