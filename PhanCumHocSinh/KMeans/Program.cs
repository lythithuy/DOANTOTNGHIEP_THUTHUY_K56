using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMeans
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Kmeans_gomcum());
        }
    }
    public static class path_src
    {
        public static string path = "";// Đường dẫn của file excel input
        public static DataTable dt;// Dùng lưu trữ dữ liệu từ file excel
                                   //public static string path_subject = "C:\\Desktop\\tenfile.xlsx";// Đường dân của file excel input
        public static string path_subject = @"Resource\DanhSachMonHoc.xlsx";
        public static DataTable dt_subject;// Dùng lưu trữ dữ liệu từ file excel
    }
}
