using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// El espacio de nombres OleDB, contiene clases para las bases de datos Acess
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace ejemplo_bases
{

    public static class bbdd
    {
        // Ip de la maquina, usuario y contraseña

        static string ruta = "SERVER=10.0.10.9;PORT=3306;DATABASE=concursomusica; UID=danielaguirre; PASSWORD=danielaguirre;";
        static MySqlConnection conection = new MySqlConnection(ruta);

        static MySqlCommand sqlcommand = new MySqlCommand();

         static MySqlDataAdapter da_grupos = new MySqlDataAdapter("select * from grupos", conection);
         static MySqlDataAdapter da_canciones = new MySqlDataAdapter("select * from canciones", conection);
        //objeto DataSet: Alamacenamiento de lo datos.

        public static DataSet ds_concursomusica = new DataSet();
        

        static public void cargaDatos()
        {

            conectar();
            //metodo Fill: que ejecuta la consulta  y guarda los datos en el dataset indicado, en la tabla indicada 

            da_canciones.Fill(ds_concursomusica, "Canciones");
            da_grupos.Fill(ds_concursomusica, "Grupos");

            desconectar();



        }




        public static void conectar()
        {
            try
            {

                conection.Open();
                if (conection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Conectado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión\n" + ex.ToString());
            }
        }

        public static void desconectar()
        {
            try
            {
                conection.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public static MySqlDataReader consulta_select(string sql)
        {
            sqlcommand.Connection = conection;
            sqlcommand.CommandText = sql;
            // Para consultas de select
            return sqlcommand.ExecuteReader();


        }

        public static int consulta_no_select(string sql)
        {
            sqlcommand.Connection = conection;
            sqlcommand.CommandText = sql;
            // Consultas: update, insert, delete
            return sqlcommand.ExecuteNonQuery();


        }


    }
}
