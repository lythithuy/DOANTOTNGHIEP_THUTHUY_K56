namespace KMeans
{
    partial class frm_PhanCum
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ThucHien = new System.Windows.Forms.Button();
            this.txt_SoCum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Subject = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_TongHopTheoLop = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DiemTB_Max = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DiemTB_Min = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_ChiTietCum = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DanhSachCum = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TongHopTheoLop)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietCum)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ThucHien);
            this.groupBox1.Controls.Add(this.txt_SoCum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lst_Subject);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân tích cụm";
            // 
            // btn_ThucHien
            // 
            this.btn_ThucHien.Location = new System.Drawing.Point(10, 462);
            this.btn_ThucHien.Name = "btn_ThucHien";
            this.btn_ThucHien.Size = new System.Drawing.Size(202, 34);
            this.btn_ThucHien.TabIndex = 4;
            this.btn_ThucHien.Text = "Thực hiện";
            this.btn_ThucHien.UseVisualStyleBackColor = true;
            this.btn_ThucHien.Click += new System.EventHandler(this.btn_ThucHien_Click);
            // 
            // txt_SoCum
            // 
            this.txt_SoCum.Location = new System.Drawing.Point(57, 429);
            this.txt_SoCum.Name = "txt_SoCum";
            this.txt_SoCum.Size = new System.Drawing.Size(155, 20);
            this.txt_SoCum.TabIndex = 3;
            this.txt_SoCum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoCum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số cụm";
            // 
            // lst_Subject
            // 
            this.lst_Subject.FormattingEnabled = true;
            this.lst_Subject.Location = new System.Drawing.Point(6, 19);
            this.lst_Subject.Name = "lst_Subject";
            this.lst_Subject.Size = new System.Drawing.Size(206, 394);
            this.lst_Subject.TabIndex = 1;
            this.lst_Subject.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lst_Subject_ItemCheck);
            this.lst_Subject.SelectedIndexChanged += new System.EventHandler(this.lst_Subject_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_TongHopTheoLop);
            this.groupBox2.Controls.Add(this.txt_DiemTB_Max);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_DiemTB_Min);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(245, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 502);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông số cụm";
            // 
            // dgv_TongHopTheoLop
            // 
            this.dgv_TongHopTheoLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TongHopTheoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TongHopTheoLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgv_TongHopTheoLop.Location = new System.Drawing.Point(431, 305);
            this.dgv_TongHopTheoLop.Name = "dgv_TongHopTheoLop";
            this.dgv_TongHopTheoLop.Size = new System.Drawing.Size(320, 191);
            this.dgv_TongHopTheoLop.TabIndex = 6;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TenLop";
            this.Column10.HeaderText = "Tên lớp";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "SoLuong";
            this.Column11.HeaderText = "Số lượng";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TyLe_Lop";
            this.Column12.HeaderText = "Tỷ lệ";
            this.Column12.Name = "Column12";
            // 
            // txt_DiemTB_Max
            // 
            this.txt_DiemTB_Max.AutoSize = true;
            this.txt_DiemTB_Max.Location = new System.Drawing.Point(739, 289);
            this.txt_DiemTB_Max.Name = "txt_DiemTB_Max";
            this.txt_DiemTB_Max.Size = new System.Drawing.Size(13, 13);
            this.txt_DiemTB_Max.TabIndex = 5;
            this.txt_DiemTB_Max.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Điểm TB lớn nhất:";
            // 
            // txt_DiemTB_Min
            // 
            this.txt_DiemTB_Min.AutoSize = true;
            this.txt_DiemTB_Min.Location = new System.Drawing.Point(531, 289);
            this.txt_DiemTB_Min.Name = "txt_DiemTB_Min";
            this.txt_DiemTB_Min.Size = new System.Drawing.Size(13, 13);
            this.txt_DiemTB_Min.TabIndex = 3;
            this.txt_DiemTB_Min.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm TB nhỏ nhất:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_ChiTietCum);
            this.groupBox3.Location = new System.Drawing.Point(425, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 263);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết cụm";
            // 
            // dgv_ChiTietCum
            // 
            this.dgv_ChiTietCum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietCum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietCum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_ChiTietCum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChiTietCum.Location = new System.Drawing.Point(3, 16);
            this.dgv_ChiTietCum.Name = "dgv_ChiTietCum";
            this.dgv_ChiTietCum.Size = new System.Drawing.Size(323, 244);
            this.dgv_ChiTietCum.TabIndex = 0;
            this.dgv_ChiTietCum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietCum_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "f_STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "f_masv";
            this.Column5.HeaderText = "MSSV";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "f_lop";
            this.Column6.HeaderText = "Lớp";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "f_ho";
            this.Column7.HeaderText = "Họ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "f_ten";
            this.Column8.HeaderText = "Tên";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "f_dtb";
            this.Column9.HeaderText = "ĐTB";
            this.Column9.Name = "Column9";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_DanhSachCum);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 477);
            this.panel1.TabIndex = 0;
            // 
            // dgv_DanhSachCum
            // 
            this.dgv_DanhSachCum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_DanhSachCum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachCum.Location = new System.Drawing.Point(0, 0);
            this.dgv_DanhSachCum.Name = "dgv_DanhSachCum";
            this.dgv_DanhSachCum.Size = new System.Drawing.Size(413, 477);
            this.dgv_DanhSachCum.TabIndex = 0;
            this.dgv_DanhSachCum.SelectionChanged += new System.EventHandler(this.dgv_DanhSachCum_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TTCum";
            this.Column1.HeaderText = "TT Cụm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TamCum";
            this.Column2.HeaderText = "Tâm cụm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoPT";
            this.Column3.HeaderText = "Số PT";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TyLe";
            this.Column4.HeaderText = "Tỷ lệ";
            this.Column4.Name = "Column4";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_PhanCum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_PhanCum";
            this.Text = "frm_PhanCum";
            this.Load += new System.EventHandler(this.frm_KQ_PC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TongHopTheoLop)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietCum)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox lst_Subject;
        private System.Windows.Forms.TextBox txt_SoCum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThucHien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DanhSachCum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_ChiTietCum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_DiemTB_Max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_DiemTB_Min;
        private System.Windows.Forms.DataGridView dgv_TongHopTheoLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}