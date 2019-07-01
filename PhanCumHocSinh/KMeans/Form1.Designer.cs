namespace KMeans
{
    partial class Kmeans_gomcum
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ThucHien = new System.Windows.Forms.Button();
            this.txt_SoCum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Subject = new System.Windows.Forms.CheckedListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_DuongDan = new System.Windows.Forms.TextBox();
            this.lab_DuongDan = new System.Windows.Forms.Label();
            this.dgv_DuLieu = new System.Windows.Forms.DataGridView();
            this.btn_DocDuLieu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TongHopTheoLop)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietCum)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1018, 487);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Biểu đồ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 17);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(607, 306);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Vẽ đồ thị";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phân tích";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_TongHopTheoLop);
            this.groupBox2.Controls.Add(this.txt_DiemTB_Max);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_DiemTB_Min);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(209, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 450);
            this.groupBox2.TabIndex = 3;
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
            this.dgv_TongHopTheoLop.Location = new System.Drawing.Point(3, 244);
            this.dgv_TongHopTheoLop.Name = "dgv_TongHopTheoLop";
            this.dgv_TongHopTheoLop.Size = new System.Drawing.Size(416, 174);
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
            this.txt_DiemTB_Max.Location = new System.Drawing.Point(325, 228);
            this.txt_DiemTB_Max.Name = "txt_DiemTB_Max";
            this.txt_DiemTB_Max.Size = new System.Drawing.Size(13, 13);
            this.txt_DiemTB_Max.TabIndex = 5;
            this.txt_DiemTB_Max.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Điểm TB lớn nhất:";
            // 
            // txt_DiemTB_Min
            // 
            this.txt_DiemTB_Min.AutoSize = true;
            this.txt_DiemTB_Min.Location = new System.Drawing.Point(117, 228);
            this.txt_DiemTB_Min.Name = "txt_DiemTB_Min";
            this.txt_DiemTB_Min.Size = new System.Drawing.Size(13, 13);
            this.txt_DiemTB_Min.TabIndex = 3;
            this.txt_DiemTB_Min.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm TB nhỏ nhất:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgv_ChiTietCum);
            this.groupBox3.Location = new System.Drawing.Point(436, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 398);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết cụm";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgv_ChiTietCum
            // 
            this.dgv_ChiTietCum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ChiTietCum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_ChiTietCum.Location = new System.Drawing.Point(6, 19);
            this.dgv_ChiTietCum.Name = "dgv_ChiTietCum";
            this.dgv_ChiTietCum.Size = new System.Drawing.Size(328, 370);
            this.dgv_ChiTietCum.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "f_mahs";
            this.Column5.HeaderText = "Mã HS";
            this.Column5.Name = "Column5";
            this.Column5.Width = 57;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "f_lop";
            this.Column6.HeaderText = "Lớp";
            this.Column6.Name = "Column6";
            this.Column6.Width = 57;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "f_ho";
            this.Column7.HeaderText = "Họ";
            this.Column7.Name = "Column7";
            this.Column7.Width = 57;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "f_ten";
            this.Column8.HeaderText = "Tên";
            this.Column8.Name = "Column8";
            this.Column8.Width = 57;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "f_dtb";
            this.Column9.HeaderText = "ĐTB";
            this.Column9.Name = "Column9";
            this.Column9.Width = 57;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_DanhSachCum);
            this.panel1.Location = new System.Drawing.Point(9, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 177);
            this.panel1.TabIndex = 0;
            // 
            // dgv_DanhSachCum
            // 
            this.dgv_DanhSachCum.AllowUserToAddRows = false;
            this.dgv_DanhSachCum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachCum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachCum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_DanhSachCum.Location = new System.Drawing.Point(0, 0);
            this.dgv_DanhSachCum.Name = "dgv_DanhSachCum";
            this.dgv_DanhSachCum.Size = new System.Drawing.Size(410, 177);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_ThucHien);
            this.groupBox1.Controls.Add(this.txt_SoCum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lst_Subject);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 452);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân tích cụm";
            // 
            // btn_ThucHien
            // 
            this.btn_ThucHien.Location = new System.Drawing.Point(21, 355);
            this.btn_ThucHien.Name = "btn_ThucHien";
            this.btn_ThucHien.Size = new System.Drawing.Size(141, 34);
            this.btn_ThucHien.TabIndex = 4;
            this.btn_ThucHien.Text = "Thực hiện";
            this.btn_ThucHien.UseVisualStyleBackColor = true;
            this.btn_ThucHien.Click += new System.EventHandler(this.btn_ThucHien_Click);
            // 
            // txt_SoCum
            // 
            this.txt_SoCum.Location = new System.Drawing.Point(72, 317);
            this.txt_SoCum.Name = "txt_SoCum";
            this.txt_SoCum.Size = new System.Drawing.Size(82, 20);
            this.txt_SoCum.TabIndex = 3;
            this.txt_SoCum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoCum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số cụm";
            // 
            // lst_Subject
            // 
            this.lst_Subject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Subject.FormattingEnabled = true;
            this.lst_Subject.Location = new System.Drawing.Point(10, 19);
            this.lst_Subject.Name = "lst_Subject";
            this.lst_Subject.Size = new System.Drawing.Size(162, 409);
            this.lst_Subject.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_DuongDan);
            this.tabPage1.Controls.Add(this.lab_DuongDan);
            this.tabPage1.Controls.Add(this.dgv_DuLieu);
            this.tabPage1.Controls.Add(this.btn_DocDuLieu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đọc dữ liệu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_DuongDan
            // 
            this.txt_DuongDan.Location = new System.Drawing.Point(353, 33);
            this.txt_DuongDan.Name = "txt_DuongDan";
            this.txt_DuongDan.Size = new System.Drawing.Size(441, 20);
            this.txt_DuongDan.TabIndex = 4;
            // 
            // lab_DuongDan
            // 
            this.lab_DuongDan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_DuongDan.AutoSize = true;
            this.lab_DuongDan.BackColor = System.Drawing.Color.LightGray;
            this.lab_DuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DuongDan.Location = new System.Drawing.Point(258, 33);
            this.lab_DuongDan.Name = "lab_DuongDan";
            this.lab_DuongDan.Size = new System.Drawing.Size(70, 20);
            this.lab_DuongDan.TabIndex = 3;
            this.lab_DuongDan.Text = "Đường dẫn";
            this.lab_DuongDan.UseCompatibleTextRendering = true;
            // 
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Location = new System.Drawing.Point(5, 88);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.Size = new System.Drawing.Size(1013, 382);
            this.dgv_DuLieu.TabIndex = 2;
            // 
            // btn_DocDuLieu
            // 
            this.btn_DocDuLieu.Location = new System.Drawing.Point(44, 23);
            this.btn_DocDuLieu.Name = "btn_DocDuLieu";
            this.btn_DocDuLieu.Size = new System.Drawing.Size(93, 39);
            this.btn_DocDuLieu.TabIndex = 0;
            this.btn_DocDuLieu.Text = "Đọc dữ liệu";
            this.btn_DocDuLieu.UseVisualStyleBackColor = true;
            this.btn_DocDuLieu.Click += new System.EventHandler(this.btn_DocDuLieu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 513);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // Kmeans_gomcum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "Kmeans_gomcum";
            this.Text = "KMeans";
            this.Load += new System.EventHandler(this.Kmeans_gomcum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TongHopTheoLop)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietCum)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lab_DuongDan;
        private System.Windows.Forms.DataGridView dgv_DuLieu;
        private System.Windows.Forms.Button btn_DocDuLieu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_TongHopTheoLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label txt_DiemTB_Max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_DiemTB_Min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_ChiTietCum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DanhSachCum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ThucHien;
        private System.Windows.Forms.TextBox txt_SoCum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lst_Subject;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_DuongDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

