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
    public partial class frm_DocDuLieu : Form
    {
        public frm_DocDuLieu()
        {
            InitializeComponent();
        }

        private void frm_DocDuLieu_Load(object sender, EventArgs e)
        {
            dgv_DuLieu.DataSource = path_src.dt;
            lab_DuongDan.Text = path_src.path;
        }
    }
}
