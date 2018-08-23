using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ConvertDBF
{
    public partial class MAICO : Form
    {
        public MAICO()
        {
            InitializeComponent();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\OneDrive - Olimpia Management\Escritorio;Extended Properties=dBASE IV;Database=Escritorio";
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                var sql = "select PEGELRT from ton;";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                DataSet ds = new DataSet(); ;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
            }
        }
    }
}
