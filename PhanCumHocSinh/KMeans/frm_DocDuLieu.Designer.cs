namespace KMeans
{
    partial class frm_DocDuLieu
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
            this.dgv_DuLieu = new System.Windows.Forms.DataGridView();
            this.lab_DuongDan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Location = new System.Drawing.Point(12, 12);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.Size = new System.Drawing.Size(784, 372);
            this.dgv_DuLieu.TabIndex = 0;
            // 
            // lab_DuongDan
            // 
            this.lab_DuongDan.AutoSize = true;
            this.lab_DuongDan.Location = new System.Drawing.Point(12, 400);
            this.lab_DuongDan.Name = "lab_DuongDan";
            this.lab_DuongDan.Size = new System.Drawing.Size(35, 13);
            this.lab_DuongDan.TabIndex = 1;
            this.lab_DuongDan.Text = "label1";
            // 
            // frm_DocDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_DuongDan);
            this.Controls.Add(this.dgv_DuLieu);
            this.Name = "frm_DocDuLieu";
            this.Text = "frm_DocDuLieu";
            this.Load += new System.EventHandler(this.frm_DocDuLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DuLieu;
        private System.Windows.Forms.Label lab_DuongDan;
    }
}