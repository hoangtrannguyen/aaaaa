using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aaaaa
{
    public partial class Form1 : Form
    {
        string strCon= @"Data Source=LAPTOP-IJQG44F2\SQLEXPRESS;Initial Catalog = ShopApp; Integrated Security = True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection();
                sqlCon.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
