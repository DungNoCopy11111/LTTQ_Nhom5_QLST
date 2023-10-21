using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoThu
{
    public partial class frmTrangChu : Form
    {
        DataBaseProcess database = new DataBaseProcess();
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private static string userName = "";
        public static string UserName { get => userName; set => userName = value; }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            lblUser.Text = UserName;
        }
    }
}
