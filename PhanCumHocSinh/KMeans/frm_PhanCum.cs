using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMeans
{
    public partial class frm_PhanCum : Form
    {
       
        public frm_PhanCum()
        {
            InitializeComponent();
        }

        public class Students
        {
            public static String[,] EXCEL;        // Mảng chứa danh sách sinh viên (thông tin cơ bản, điểm trung bình các môn được chọn của sinh viên đó, điểm các môn được chọn)
            public static Double[] Students_Group;// Mảng chứa các điểm trung bình khác nhau của sinh viên (độ đa dạng của điểm trung bình)
            public static int COU_Students_Group; // Đếm số lượng phần tử của mảng Students_Group 
            public static double max_mark;
            public static double min_mark;
        }

        public class Subjects
        {
            public static String[] SUBJECT;
            public static int COU_SUBJECT;
            public static String[] ARR_Subjects; // Mảng chứa các môn học đã chọn
            public static int COU_Subjects;      // Đếm số lượng phần tử của mảng chứa các môn học đã chọn
        }

        public class KMeans_Cluster
        {
            public static int NUM_Cluster;        // Số cụm người dùng nhập vào
        }

        public class KMeans_Center
        {
            public static Double[] CENTER;      // Mảng chứa các tâm cụm đại diện của từng cụm
            public static Double[] COU_Vector;  // Mảng chứa số phần tử của các cụm
        }

        public class KMeans_Result
        {
            public static DataTable dt_Export_Excel;   // DataTable dùng để chứa dữ liệu phân cụm xuất ra file excel
            public static DataRow dr_Export_Excel;

            public static DataTable dt_View_Clustering;// DataTable dùng để chứa dữ liệu phân cụm xuất ra màn hình hiển thị
            public static DataRow dr_View_Clustering;

            public static DataTable dt_View_Clustering_Detail; // DataTable dùng để chứa dữ liệu chi tiết của từng cụm xuất ra màn hình hiển thị
            public static DataRow dr_View_Clustering_Detail;
        }
        public IEnumerable<Control> GetAll(Control control, Type type)// Hàm duyệt tất cả các control trong form để kiểm tra các checkbox
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public void Hide_Button_ThucHien(object sender, EventArgs e)
        {
            btn_ThucHien.Enabled = true;
        }

        int k = 0;

        public static Double[] Select_Center(int K)
        {
            int COU_Students_Group_Temp = 0;
            Double[] Cluster_Begin = new Double[KMeans_Cluster.NUM_Cluster];
            Double[] Students_Group_Temp = new Double[Students.COU_Students_Group];

            if (K == 1)
            {
                Cluster_Begin[0] = Students.min_mark;
                return Cluster_Begin;
            }
            else
            {
                Cluster_Begin[0] = Students.min_mark;
                Cluster_Begin[1] = Students.max_mark;
            }

            if (K != 2)
            {
                for (int i = 0; i < Students.COU_Students_Group; i++)
                {
                    if ((Students.Students_Group[i] != Students.max_mark) && (Students.Students_Group[i] != Students.min_mark))
                    {
                        Students_Group_Temp[COU_Students_Group_Temp] = Students.Students_Group[i];
                        COU_Students_Group_Temp++;
                    }
                }

                double division = Students.max_mark / (KMeans_Cluster.NUM_Cluster - 1);
                double min_distance;
                int location_min_distance;

                for (int i = KMeans_Cluster.NUM_Cluster - 1; i >= 2; i--)
                {
                    min_distance = 10.0;
                    location_min_distance = 0;

                    for (int j = 0; j < COU_Students_Group_Temp; j++)
                    {
                        if (Math.Sqrt(Math.Pow((Students_Group_Temp[j] - ((i - 1) * division)), 2)) < min_distance)
                        {
                            min_distance = Math.Sqrt(Math.Pow((Students_Group_Temp[j] - ((i - 1) * division)), 2));
                            location_min_distance = j;
                        }
                    }

                    Cluster_Begin[i] = Students_Group_Temp[location_min_distance];

                    for (int k = location_min_distance; k < COU_Students_Group_Temp - 1; k++)
                    {
                        Students_Group_Temp[k] = Students_Group_Temp[k + 1];
                    }

                    COU_Students_Group_Temp--;

                    //MessageBox.Show(" Cluster["+ i +"]: " + Cluster_Begin[i].ToString());
                }
            }
            return Cluster_Begin;
        }

        private void frm_KQ_PC_Load(object sender, EventArgs e)
        {
          
            dgv_TongHopTheoLop.Visible = false;
            dgv_TongHopTheoLop.Visible = false;
           
            txt_SoCum.Focus();

          
            Subjects.SUBJECT = new String[path_src.dt.Columns.Count];
            Subjects.COU_SUBJECT = 0;
            foreach (DataColumn Col in path_src.dt.Columns)
            {
                Subjects.SUBJECT[Subjects.COU_SUBJECT] = Col.ColumnName;
                Subjects.COU_SUBJECT++;
            }

            for (int i = 0; i < Subjects.COU_SUBJECT; i++)
            {
                for (int j = 0; j < path_src.dt_subject.Rows.Count; j++)
                {
                    DataRow dr_subject = path_src.dt_subject.Rows[j];
                    if (Subjects.SUBJECT[i] == dr_subject[1].ToString())
                    {
                        string item = string.Empty;

                      //  item = dr_subject[0].ToString();
                        item = dr_subject[1].ToString();
                        
                        lst_Subject.Items.Add(item);
                    }
                }
            }
        }

        public void KeyPressNumber(Control cont, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                this.errorProvider1.SetError(cont, "Bạn phải nhập dữ liệu là kiểu số");
                e.Handled = true;
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_SoCum_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressNumber(txt_SoCum, e);
        }

        private void txt_SoCum_EditValueChanged(object sender, EventArgs e)
        {
            Control crt = (Control)sender;
            if (crt.Text.Trim().Length > 0 && !Char.IsDigit(crt.Text[crt.Text.Length - 1]))
            {
                this.errorProvider1.SetError(crt, "Bạn phải nhập số!");
                k = 0;
            }
            else
            {
                this.errorProvider1.Clear();
                btn_ThucHien.Enabled = true;
            }
        }

        private void lst_Subject_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            btn_ThucHien.Enabled = true;
        }
       
        private void dgv_DanhSachCum_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachCum.RowCount > 0)
            {
               
                Double DTB_Max_Detail = 0;
                Double DTB_Min_Detail = 10;
                
                double center = Convert.ToDouble(dgv_DanhSachCum.CurrentRow.Cells["Cen"].Value.ToString());

                dgv_ChiTietCum.DataSource = null;
                dgv_TongHopTheoLop.DataSource = null;

                String[] Class = new String[path_src.dt.Rows.Count];
                int COU_Class = 0;
                int NUM_Class = 0;


                KMeans_Result.dt_View_Clustering_Detail = new DataTable();
                KMeans_Result.dt_View_Clustering_Detail.Columns.Add(new DataColumn("f_stt"));
                KMeans_Result.dt_View_Clustering_Detail.Columns.Add(new DataColumn("f_masv"));
                KMeans_Result.dt_View_Clustering_Detail.Columns.Add(new DataColumn("f_lop"));
                KMeans_Result.dt_View_Clustering_Detail.Columns.Add(new DataColumn("f_ho"));
                KMeans_Result.dt_View_Clustering_Detail.Columns.Add(new DataColumn("f_ten"));
                KMeans_Result.dt_View_Clustering_Detail.Columns.Add(new DataColumn("f_dtb"));

                for (int i = 0; i < Subjects.COU_Subjects; i++)
                    KMeans_Result.dt_View_Clustering_Detail.Columns.Add(new DataColumn(Subjects.ARR_Subjects[i]));

              

                for (int i = 0; i < path_src.dt.Rows.Count; i++)
                {
                    
                    if (Convert.ToDouble(Students.EXCEL[i, 6]) == center)
                    {
                        KMeans_Result.dr_View_Clustering_Detail = KMeans_Result.dt_View_Clustering_Detail.NewRow();
                        KMeans_Result.dr_View_Clustering_Detail["f_stt"] = Students.EXCEL[i, 0];
                        KMeans_Result.dr_View_Clustering_Detail["f_masv"] = Students.EXCEL[i, 1];
                        KMeans_Result.dr_View_Clustering_Detail["f_lop"] = Students.EXCEL[i, 4];
                        KMeans_Result.dr_View_Clustering_Detail["f_ho"] = Students.EXCEL[i, 2];
                        KMeans_Result.dr_View_Clustering_Detail["f_ten"] = Students.EXCEL[i, 3];
                        KMeans_Result.dr_View_Clustering_Detail["f_dtb"] = Math.Round(Convert.ToDouble(Students.EXCEL[i, 5]), 2);

                        for (int j = 0; j < Subjects.COU_Subjects; j++)
                            KMeans_Result.dr_View_Clustering_Detail[Subjects.ARR_Subjects[j]] = Students.EXCEL[i, 6 + j];

                        KMeans_Result.dt_View_Clustering_Detail.Rows.Add(KMeans_Result.dr_View_Clustering_Detail);

                        Class[NUM_Class] = Students.EXCEL[i, 3];
                        NUM_Class++;

                        if (Math.Round(Convert.ToDouble(Students.EXCEL[i, 5]), 2) > DTB_Max_Detail)
                        {
                            DTB_Max_Detail = Math.Round(Convert.ToDouble(Students.EXCEL[i, 4]), 2);
                        }
                        if (Math.Round(Convert.ToDouble(Students.EXCEL[i, 5]), 2) < DTB_Min_Detail)
                        {
                            DTB_Min_Detail = Math.Round(Convert.ToDouble(Students.EXCEL[i, 5]), 2);
                        }
                    }
                }
                dgv_ChiTietCum.DataSource = KMeans_Result.dt_View_Clustering_Detail;

                String[,] Class_Detail = new String[NUM_Class, 3];
                Class_Detail[0, 0] = Class[0];
                Class_Detail[0, 1] = "1";
                Class_Detail[0, 2] = "1%";
                COU_Class++;

                for (int i = 1; i < NUM_Class; i++)
                {
                    int similar_class = 0;

                    for (int j = 0; j < COU_Class; j++)
                    {
                        if (Class[i] == Class_Detail[j, 0])
                        {
                            Class_Detail[j, 1] = (Convert.ToInt32(Class_Detail[j, 1]) + 1).ToString();
                            similar_class++;
                        }
                    }

                    if (similar_class == 0)
                    {
                        Class_Detail[COU_Class, 0] = Class[i];
                        Class_Detail[COU_Class, 1] = "1";
                        COU_Class++;
                    }
                }

                for (int i = 0; i < NUM_Class; i++)
                {
                    Class_Detail[i, 2] = (Math.Round(Convert.ToDouble(Class_Detail[i, 1]) / Convert.ToDouble(dgv_DanhSachCum.CurrentRow.Cells[2].Value.ToString()), 4) * 100).ToString() + " %";
                }

                DataTable dt_th = new DataTable();
                dt_th.Columns.Add(new DataColumn("TenLop"));
                dt_th.Columns.Add(new DataColumn("SoLuong"));
                dt_th.Columns.Add(new DataColumn("TyLe_Lop"));

                DataRow dr_th;

                for (int i = 0; i < COU_Class; i++)
                {
                    dr_th = dt_th.NewRow();
                    dr_th["TenLop"] = Class_Detail[i, 0];
                    dr_th["SoLuong"] = Class_Detail[i, 1];
                    dr_th["TyLe_Lop"] = Class_Detail[i, 2];
                    dt_th.Rows.Add(dr_th);
                }
                dgv_TongHopTheoLop.DataSource = dt_th;

                txt_DiemTB_Max.Text = DTB_Max_Detail.ToString();
                txt_DiemTB_Min.Text = DTB_Min_Detail.ToString();
            }
        }

        private void btn_ThucHien_Click(object sender, EventArgs e)
        {
        

            if (k != 0)
            {
                if (dgv_ChiTietCum.Columns[5] != null)
                    for (int i = 4 + Subjects.COU_Subjects; i >= 5; i--)// Remove từng cột để xóa các cột chứa điểm của từng môn
                        dgv_ChiTietCum.Columns.RemoveAt(i);
            }

            //txt_SoLanLap.Text =
            //txt_SoHocSinh.Text =
            txt_DiemTB_Max.Text =
            txt_DiemTB_Min.Text = "";

            dgv_DanhSachCum.DataSource = null;

            if (txt_SoCum.Text != "")
            {
                if (Convert.ToInt32(txt_SoCum.Text) <= 0)
                {
                    MessageBox.Show("Bạn vui lòng nhập vào số tâm cụm hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                 
                    k = 0;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng nhập vào số tâm cụm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
              
                k = 0;
                return;
            }

            if (path_src.path == "")
            {
                 MessageBox.Show("Bạn vui lòng chọn đường dẫn tập tin Excel cần phân tích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            
                k = 0;
            }

            else
            {
                KMeans_Cluster.NUM_Cluster = Convert.ToInt32(txt_SoCum.Text); // Gán NUM_Cluster = số cụm người dùng nhập vào

                Subjects.ARR_Subjects = new String[Subjects.SUBJECT.Length]; // Tạo mảng chứa các môn học người dùng chọn. Hiện tại danh sách môn học có 9 môn 
                Subjects.COU_Subjects = 0;             // Đếm số môn học người dùng chọn

                DataGridViewTextBoxColumn Grid_Name; //= new DataGridViewColumn();
                for (int i = 0; i < lst_Subject.Items.Count; i++)
                {
                    if (lst_Subject.GetSelected(i)== true)
                    {
                        Subjects.ARR_Subjects[Subjects.COU_Subjects] = lst_Subject.Items[i].ToString();

                        Grid_Name = new DataGridViewTextBoxColumn();
                      
                        Grid_Name.HeaderText = lst_Subject.Items[i].ToString();
                        Grid_Name.DataPropertyName= lst_Subject.Items[i].ToString();
                        Grid_Name.Name= lst_Subject.Items[i].ToString();
  
                        Grid_Name.Visible = true;


                        var col3 = new DataGridViewTextBoxColumn();




                        dgv_ChiTietCum.Columns.AddRange(new DataGridViewColumn[] { Grid_Name });
                   
                        Subjects.COU_Subjects++;
                    }
                }

                if (Subjects.COU_Subjects == 0)
                {
                    MessageBox.Show("Cần chọn ít nhất 1 môn học để phân cụm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                              k = 0;
                    return;
                }
                // Tạo mảng EXCEL chứa thông tin cơ bản củasinh viên( 4 cột), Điểm trung bình của các môn đã chọn( 1 cột), Tâm cụm tương ứng( 1 cột), Điểm của các môn đã chọn( tùy vào số môn người dùng chọn)
                Students.EXCEL = new String[path_src.dt.Rows.Count, 6 + Subjects.COU_Subjects];

                Students.Students_Group = new Double[path_src.dt.Rows.Count];
                Students.COU_Students_Group = 0;

                double sum_mark = 0;// Tổng điểm của các môn mà người dùng đã chọn của sinh viên đó 

                DataRow dr0 = path_src.dt.Rows[0];

                try
                {
                    // Tạo ra điểm trung bình đầu tiên để ddauw vào mảng Students_Group
                    for (int j = 0; j < Subjects.COU_Subjects; j++)
                    {
                        sum_mark += Convert.ToDouble(dr0[Subjects.ARR_Subjects[j]]);
                    }

                    Students.EXCEL[0, 4] = (sum_mark / Subjects.COU_Subjects).ToString();

                    Students.Students_Group[0] = Convert.ToDouble(Students.EXCEL[0, 4]);
                    Students.COU_Students_Group++;

                    Students.min_mark = Students.Students_Group[0];
                    Students.max_mark = Students.Students_Group[0];

                    // Duyệt từng sinh viên và đưa vào mảng EXCEL tất cả các thông tin, nếu điểm trung bình các môn đã chọn của sinh viên đó chưa tồn tại trong bảng Students_Group thì thêm vào
                    for (int i = 0; i <= path_src.dt.Rows.Count - 1; i++)
                    {

                        int count = 0; // Biến kiểm tra trùng điểm trung bình
                        sum_mark = 0; // Biến tổng điểm các môn đã chọn của từng sinh viên
                        DataRow dr = path_src.dt.Rows[i];

                        Students.EXCEL[i, 0] = dr["f_masv"].ToString();
                        Students.EXCEL[i, 1] = dr["f_ho"].ToString();
                        Students.EXCEL[i, 2] = dr["f_ten"].ToString();
                        Students.EXCEL[i, 3] = dr["f_tenlop"].ToString();

                        for (int j = 0; j < Subjects.COU_Subjects; j++)  // Đưa điểm các môn đã chọn của sinh viên đó  vào mảng EXCEL
                        {
                            sum_mark += Convert.ToDouble(dr[Subjects.ARR_Subjects[j]]);
                            Students.EXCEL[i, 6 + j] = dr[Subjects.ARR_Subjects[j]].ToString();
                        }

                        Students.EXCEL[i, 4] = (sum_mark / Subjects.COU_Subjects).ToString();// Đưa điểm trung bình các môn đã chọn của sinh viên đó  vào mảng EXCEL

                        for (int j = 0; j < Students.COU_Students_Group; j++)// Duyệt mảng Students_Group xem điểm trung bình của sinh viên này đã có trong đó chưa
                        {
                            if ((Convert.ToDouble(Students.EXCEL[i, 4])) == (Students.Students_Group[j]))// Nếu đã có thì tăng biến kiểm tra
                            {
                                count++;
                            }
                        }
                        if (count == 0)// Nếu biến kiểm tra bằng 0 (tức là điểm mới chưa có trong mảng) thì thêm vào 
                        {
                            Students.Students_Group[Students.COU_Students_Group] = Convert.ToDouble(Students.EXCEL[i, 4]);

                            if (Students.Students_Group[Students.COU_Students_Group] > Students.max_mark)
                                Students.max_mark = Students.Students_Group[Students.COU_Students_Group];
                            if (Students.Students_Group[Students.COU_Students_Group] < Students.min_mark)
                                Students.min_mark = Students.Students_Group[Students.COU_Students_Group];

                            Students.COU_Students_Group++;
                        }
                    }
                }
                catch
                {
                     MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. \n_________________________________________________\n\n1. Có thể tập tin Excel có các tên cột không đúng định dạng. \n2. Có thể tập tin Excel không đầy đủ dữ liệu ở một số dòng. \n\nBạn vui lòng kiểm tra và thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;

                }


                if (Students.COU_Students_Group < KMeans_Cluster.NUM_Cluster)
                {
                    MessageBox.Show("Số tâm cụm vượt quá số lượng giá trị khác nhau của dữ liệu !\n\t      ( Số tâm cụm phải '<' hoặc '=' " + Students.COU_Students_Group + " )", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    k = 0;
                    return;
                }

                Double Variance_MIN;   // Phương sai (độ lệch) bé nhất
                Double DTB_Max = 0;// Điểm trung bình lớn nhất 
                Double DTB_Min = 10;// Điểm trung bình bé nhất
                int stop = 0, lap = 0;// Biến kiểm tra dừng và biến đếm số lần lặp

                Double[] Variance = new Double[KMeans_Cluster.NUM_Cluster];        // Mảng phương sai (độ lệch)
                Double[] SUM_Vector = new Double[KMeans_Cluster.NUM_Cluster];      // Mảng tổng giá trị điểm trung bình của cụm
                KMeans_Center.COU_Vector = new Double[KMeans_Cluster.NUM_Cluster]; // Mảng số sinh viên của cụm

                Double[] CEN_Temp = new Double[KMeans_Cluster.NUM_Cluster];        // Mảng tâm cụm trước đó (vòng lặp kề trước của vòng lặp hiện tại)
                KMeans_Center.CENTER = new Double[KMeans_Cluster.NUM_Cluster];     // Mảng tâm cụm hiện tại (vòng lặp hiện tại)


                

                KMeans_Center.CENTER = Select_Center(KMeans_Cluster.NUM_Cluster);

                while (stop != 1)
                {
                    lap++;

                    for (int i = 0; i < KMeans_Cluster.NUM_Cluster; i++)
                    {
                        KMeans_Center.COU_Vector[i] = SUM_Vector[i] = 0;
                        CEN_Temp[i] = KMeans_Center.CENTER[i];// Cập nhật sanh sách tâm cụm trước 
                    }

                    //-------------------------Start Step 2--------------------------// 

                    for (int i = 0; i < path_src.dt.Rows.Count; i++)
                    {
                        if (Convert.ToDouble(Students.EXCEL[i, 4]) > DTB_Max)
                            DTB_Max = Convert.ToDouble(Students.EXCEL[i, 4]);
                        if (Convert.ToDouble(Students.EXCEL[i, 4]) < DTB_Min)
                            DTB_Min = Convert.ToDouble(Students.EXCEL[i, 4]);

                        for (int j = 0; j < KMeans_Cluster.NUM_Cluster; j++)
                        {
                            Variance[j] = 0;
                        }
                        int MIN = 0;

                        Variance_MIN = Math.Sqrt(Math.Pow((Convert.ToDouble(Students.EXCEL[i, 4]) - KMeans_Center.CENTER[0]), 2));
                        for (int j = 1; j < KMeans_Cluster.NUM_Cluster; j++)
                        {
                            Variance[j] = Math.Sqrt(Math.Pow((Convert.ToDouble(Students.EXCEL[i, 4]) - KMeans_Center.CENTER[j]), 2));

                            if (Variance[j] < Variance_MIN)
                            {
                                Variance_MIN = Variance[j];
                                MIN = j;
                            }
                        }

                        Students.EXCEL[i, 5] = Convert.ToString(KMeans_Center.CENTER[MIN]);
                        SUM_Vector[MIN] += Convert.ToDouble(Students.EXCEL[i, 4]);
                        KMeans_Center.COU_Vector[MIN]++;
                    }

                    //-------------------------Start Step 3--------------------------//  

                    int CUO_CEN_Similar = 0;

                    for (int i = 0; i < KMeans_Cluster.NUM_Cluster; i++)
                    {
                        KMeans_Center.CENTER[i] = SUM_Vector[i] / KMeans_Center.COU_Vector[i];

                        if (KMeans_Center.CENTER[i] == CEN_Temp[i])
                        {
                            CUO_CEN_Similar++;
                        }
                    }

                    if (CUO_CEN_Similar == KMeans_Cluster.NUM_Cluster)
                    {
                        stop = 1;
                    }
                }

                //---------------------------------------------------END KMEANS------------------------------------------------------------
                KMeans_Result.dt_View_Clustering = new DataTable();
                KMeans_Result.dt_View_Clustering.Columns.Add(new DataColumn("TTCum"));
                KMeans_Result.dt_View_Clustering.Columns.Add(new DataColumn("TamCum"));
                KMeans_Result.dt_View_Clustering.Columns.Add(new DataColumn("SoPT"));
                KMeans_Result.dt_View_Clustering.Columns.Add(new DataColumn("TyLe"));
                KMeans_Result.dt_View_Clustering.Columns.Add(new DataColumn("Cen"));

                KMeans_Result.dt_Export_Excel = new DataTable();
                KMeans_Result.dt_Export_Excel.Columns.Add(new DataColumn("TT Cụm", typeof(Double)));
                KMeans_Result.dt_Export_Excel.Columns.Add(new DataColumn("Tâm cụm", typeof(Double)));
                KMeans_Result.dt_Export_Excel.Columns.Add(new DataColumn("Số PT", typeof(Double)));
                KMeans_Result.dt_Export_Excel.Columns.Add(new DataColumn("Tỷ lệ (%)", typeof(Double)));

                for (int i = 0; i < KMeans_Cluster.NUM_Cluster; i++)
                {

                    KMeans_Result.dr_View_Clustering = KMeans_Result.dt_View_Clustering.NewRow();
                    KMeans_Result.dr_Export_Excel = KMeans_Result.dt_Export_Excel.NewRow();

                    KMeans_Result.dr_Export_Excel["TT Cụm"] = KMeans_Result.dr_View_Clustering["TTCum"] = i + 1;
                    KMeans_Result.dr_Export_Excel["Tâm cụm"] = KMeans_Result.dr_View_Clustering["TamCum"] = Math.Round(KMeans_Center.CENTER[i], 2);
                    KMeans_Result.dr_Export_Excel["Số PT"] = KMeans_Result.dr_View_Clustering["SoPT"] = KMeans_Center.COU_Vector[i];
                    KMeans_Result.dr_Export_Excel["Tỷ lệ (%)"] = Math.Round((KMeans_Center.COU_Vector[i] / path_src.dt.Rows.Count), 4) * 100;
                    KMeans_Result.dr_View_Clustering["TyLe"] = (Math.Round((KMeans_Center.COU_Vector[i] / path_src.dt.Rows.Count), 4) * 100) + " %";
                    KMeans_Result.dr_View_Clustering["Cen"] = KMeans_Center.CENTER[i];

                    KMeans_Result.dt_View_Clustering.Rows.Add(KMeans_Result.dr_View_Clustering);
                    KMeans_Result.dt_Export_Excel.Rows.Add(KMeans_Result.dr_Export_Excel);
                }
                dgv_DanhSachCum.DataSource = KMeans_Result.dt_View_Clustering;

         
              

                dgv_ChiTietCum.Visible = true;
                dgv_TongHopTheoLop.Visible = true;
                dgv_TongHopTheoLop.Visible = true;
               
            }

            k = 1;
            btn_ThucHien.Enabled = false;
          
        }

        private void dgv_ChiTietCum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lst_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
