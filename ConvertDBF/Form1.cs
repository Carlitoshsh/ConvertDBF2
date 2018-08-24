using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;

namespace ConvertDBF
{
    public partial class MAICO : Form
    {
        public string carpeta;
        public MAICO()
        {
            InitializeComponent();
        }

        private void conectarConBaseDeDatosMAICO(string selectedPath, string sql)
        {
            try
            {
                string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + selectedPath + ";Extended Properties=dBASE IV;";
                using (OleDbConnection con = new OleDbConnection(constr))
                {
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    con.Open();
                    DataSet ds = new DataSet("Resultados");
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(ds);
                    MessageBox.Show(ds.GetXml(), "Datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void abrirCarpeta(string sql)
        {
            if (carpeta != null) {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        carpeta = fbd.SelectedPath;
                    }
                }
            }
            conectarConBaseDeDatosMAICO(carpeta, sql);
            
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            var sql = "select PEGELRT from ton where IDPATAUD='"+documento.Text+"';";
            abrirCarpeta(sql);
        }

        private void editarArchivo() {
            string datosDeUsuario = @"C:\ProgramData\Maico\ma42\whf.in";
            string[] lines = File.ReadAllLines(datosDeUsuario);
            lines[0] = documento.Text; //Documento
            lines[1] = apellido.Text;
            lines[2] = nombre.Text;
            lines[3] = "25.12.1994";
            File.WriteAllLines(datosDeUsuario, lines);
        }

        private void abrirPrueba_Click(object sender, EventArgs e)
        {
            var sql = "insert into PATIENT values("+
                    "'"+documento.Text+ "', '" + documento.Text + "', null, '" + apellido.Text + "', '" + nombre.Text + "'," +
                    "null, null, null, null, '1994-12-25', '2018-08-08', 1,"+
                    "null, null, null, null, null, null, null, null)";
            abrirCarpeta(sql);
            editarArchivo();

            ProcessStartInfo infoProceso = new ProcessStartInfo();
            infoProceso.FileName = @"C:\Program Files (x86)\MAICO\MA42\ma42i.exe";
            Process.Start(infoProceso);

        }

    }
}
