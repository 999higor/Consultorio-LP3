
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabson.DAL
{
    class RelatorioDAL
    {
        // sql server 2015 ifrs
        //static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Administrador\Documents\Visual Studio 2015\Projects\consultorio.mdf';Integrated Security=True;Connect Timeout=30";

        //sql server 2017 pc
        //static string connection = @"Data Source=HIGOR\SQLEXPRESS;Initial Catalog=consultorio;Integrated Security=True;Pooling=False";

        //bd 2015
        static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\higor\Documents\GitHub\Consultorio-LP3\BD 2015\consultorio.mdf';Integrated Security=True;Connect Timeout=30";

        public static DataSet pesquisa(string texto)
        {
            //texto com o comando sql que sera executado
            //MessageBox.Show(texto);
            //texto = "@texto";

            string cmd = "SELECT Consulta.IdConsulta AS ID ,Medico.nomeMedico AS Médico ,Consulta.Id_medico AS MED ,Paciente.nomePaciente AS Paciente ,Consulta.Id_paciente AS PAC ,Consulta.dataConsulta AS Data, Consulta.dataInicio AS Início, Consulta.dataFim AS Fim, Consulta.observacoes AS Observações, Consulta.ativo AS Ativo " +
                         " FROM Consulta INNER JOIN " +
                         " Medico ON Consulta.Id_medico = Medico.IdMedico INNER JOIN " +
                         " Paciente ON Consulta.id_paciente = Paciente.IdPaciente " +
                         " WHERE Consulta.dataConsulta=@texto";

            //uma bruxaria muito sinistra esta acontecendo aqui 

            //objeto que ira fazer a conexao
            SqlConnection conn = new SqlConnection(connection);
            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

           // sqlcmd.Parameters.AddWithValue("texto" ,"%"+ texto + "%");
            sqlcmd.Parameters.AddWithValue("@texto" ,texto);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;

            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();    //abre a conexao com o banco
                adapter.Fill(dataSet);
                //res = sqlcmd.ExecuteNonQuery(); //executa o comando no banco de dados


            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }
    }
}
