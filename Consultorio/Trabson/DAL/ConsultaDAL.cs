using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabson.DAL
{
    class ConsultaDAL
    {
        // sql server 2015 ifrs
        //static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Administrador\Documents\Visual Studio 2015\Projects\consultorio.mdf';Integrated Security=True;Connect Timeout=30";

        //sql server 2017 pc
        //static string connection = @"Data Source=HIGOR\SQLEXPRESS;Initial Catalog=consultorio;Integrated Security=True;Pooling=False";

        //bd 2015
        static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\higor\Documents\GitHub\Consultorio-LP3\BD 2015\consultorio.mdf';Integrated Security=True;Connect Timeout=30";

        public static int Cadastrar(int pId_medico, int pId_paciente, DateTime pDataConsulta, DateTime pHoraInicio, DateTime pHoraFim, string pObservacao, bool pAtivo)
        {
            string cmd = "Insert Into Consulta (Id_medico, Id_paciente, dataConsulta, dataInicio, dataFim, observacoes, ativo) values " 
                + " (@Id_medico, @Id_paciente, @dataConsulta, @horaInicio, @horaFim, @observacoes, @bit)";
            int res = 0;

            SqlConnection conn = new SqlConnection(connection);

            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            sqlcmd.Parameters.AddWithValue("@Id_medico", pId_medico);
            sqlcmd.Parameters.AddWithValue("@Id_paciente", pId_paciente);
            sqlcmd.Parameters.AddWithValue("@dataConsulta", pDataConsulta);
            sqlcmd.Parameters.AddWithValue("@horaInicio", pHoraInicio);
            sqlcmd.Parameters.AddWithValue("@horaFim", pHoraFim);
            sqlcmd.Parameters.AddWithValue("@observacoes", pObservacao);
            sqlcmd.Parameters.AddWithValue("@bit", pAtivo);

            try
            {
                conn.Open();
                res = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        public static int Alterar(int pId_medico, int pId_paciente, DateTime pDataConsulta, DateTime pHoraInicio, DateTime pHoraFim, string pObservacao, bool pAtivo, int pIdConsulta) 
        {
            //texto com o comando que sera executado
            string cmd = "UPDATE Consulta " +
                "SET Id_medico = @Id_medico, Id_paciente =@Id_paciente, dataConsulta = @dataConsulta, dataInicio = @horaInicio, dataInicio = @horaFim, observacoes = @observacoes ativo = @bit WHERE IdConsulta = @IdConsulta";

            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(connection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql

            sqlcmd.Parameters.AddWithValue("@Id_medico", pId_medico);
            sqlcmd.Parameters.AddWithValue("@Id_paciente", pId_paciente);
            sqlcmd.Parameters.AddWithValue("@dataConsulta", pDataConsulta);
            sqlcmd.Parameters.AddWithValue("@horaInicio", pHoraInicio);
            sqlcmd.Parameters.AddWithValue("@horaFim", pHoraFim);
            sqlcmd.Parameters.AddWithValue("@observacoes", pObservacao);
            sqlcmd.Parameters.AddWithValue("@bit", pAtivo);
            sqlcmd.Parameters.AddWithValue("@idConsulta", pIdConsulta);


            try
            {
                conn.Open();    //abre a conexao com o banco
                res = sqlcmd.ExecuteNonQuery(); //executa o comando no banco de dados

            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                conn.Close();
            }

            return res;
        }

        public static int Excluir(int pIdConsulta)
        {
            //texto com o comando que sera executado
            string cmd = "DELETE FROM Consulta WHERE IdConsulta = @IdConsulta";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(connection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql


            sqlcmd.Parameters.AddWithValue("@IdConsulta", pIdConsulta);

            try
            {
                conn.Open();    //abre a conexao com o banco
                res = sqlcmd.ExecuteNonQuery(); //executa o comando no banco de dados

            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                conn.Close();
            }

            return res;
        }

        public static DataSet atualizaTabela()
        {
            //texto com o comando sql que sera executado
            //string cmd = "Select * from Consulta";

            string cmd = "SELECT Consulta.IdConsulta AS ID ,Medico.nomeMedico AS Médico ,Consulta.Id_medico AS MED ,Paciente.nomePaciente AS Paciente ,Consulta.Id_paciente AS PAC ,Consulta.dataConsulta AS Data, Consulta.dataInicio AS Início, Consulta.dataFim AS Fim, Consulta.observacoes AS Observações, Consulta.ativo AS Ativo " +
                         " FROM Consulta INNER JOIN " +
                         " Medico ON Consulta.Id_medico = Medico.IdMedico INNER JOIN " +
                         " Paciente ON Consulta.id_paciente = Paciente.IdPaciente";
                        // WHERE(Paciente.nomePaciente = @texto)"

            //objeto que ira fazer a conexao
            SqlConnection conn = new SqlConnection(connection);
            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

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

                throw;
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }

        public static DataTable atualizaComboMedico()
        {
            //texto com o comando sql que sera executado
            string cmd = "Select * from Medico";

            //objeto que ira fazer a conexao
            SqlConnection conn = new SqlConnection(connection);
            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;

            DataTable dataSet = new DataTable();


            try
            {
                conn.Open();    //abre a conexao com o banco
                adapter.Fill(dataSet);



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }

        public static DataTable atualizaComboPaciente()
        {
            //texto com o comando sql que sera executado
            string cmd = "Select * from Paciente";

            //objeto que ira fazer a conexao
            SqlConnection conn = new SqlConnection(connection);
            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;

            DataTable dataSet = new DataTable();


            try
            {
                conn.Open();    //abre a conexao com o banco
                adapter.Fill(dataSet);



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }

        public static DataSet pesquisa(string texto)
        {
            //texto com o comando sql que sera executado
            //MessageBox.Show(texto);
            //texto = "@texto";

            string cmd = "SELECT Consulta.IdConsulta AS ID ,Medico.nomeMedico AS Médico ,Consulta.Id_medico AS MED ,Paciente.nomePaciente AS Paciente ,Consulta.Id_paciente AS PAC ,Consulta.dataConsulta AS Data, Consulta.dataInicio AS Início, Consulta.dataFim AS Fim, Consulta.observacoes AS Observações, Consulta.ativo AS Ativo " +
                         " FROM Consulta INNER JOIN " +
                         " Medico ON Consulta.Id_medico = Medico.IdMedico INNER JOIN " +
                         " Paciente ON Consulta.id_paciente = Paciente.IdPaciente " +
                         " WHERE Paciente.nomePaciente LIKE @texto";

            //uma bruxaria muito sinistra esta acontecendo aqui 

            //objeto que ira fazer a conexao
            SqlConnection conn = new SqlConnection(connection);
            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            sqlcmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
            //sqlcmd.Parameters.AddWithValue("texto" ,texto);

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
