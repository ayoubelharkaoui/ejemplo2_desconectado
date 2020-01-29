using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_bases
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bbdd.cargaDatos();
            //dataGridView1.DataSource = bbdd.ds_concursomusica.Tables[0];
            DataTable dt = new DataTable();
            //dt = bbdd.ds_concursomusica.Tables[1];
            for (int i = 0; i < bbdd.ds_concursomusica.Tables.Count; i++)
            {
                dt = bbdd.ds_concursomusica.Tables[i];
                cmb_tablas.Items.Add(dt.TableName);
            }
            //gsf
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_ejecutar_Click(object sender, EventArgs e)
        {

            

            if (rdo_select.Checked)
            {
//             

                MySqlDataReader datos = bbdd.consulta_select(txt_consulta.Text);

           

                datos.Close();
               
            }

            if (rdo_no_select.Checked)
            {
                bbdd.consulta_no_select(txt_consulta.Text);



            }
        }

        private void Cmb_tablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tablas.SelectedIndex == 0)
            {
                dataGridView1.DataSource = bbdd.ds_concursomusica.Tables[0];
            }
            else if(cmb_tablas.SelectedIndex==1)
            {
                dataGridView1.DataSource = bbdd.ds_concursomusica.Tables[1];
            }
        }
    }
}
