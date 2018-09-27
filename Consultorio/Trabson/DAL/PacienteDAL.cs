using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabson.DAL
{
    class PacienteDAL
    {
        // sql server 2015 ifrs
        //static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Administrador\Documents\Visual Studio 2015\Projects\consultorio.mdf';Integrated Security=True;Connect Timeout=30";

        //sql server 2017 pc
        //static string connection = @"Data Source=HIGOR\SQLEXPRESS;Initial Catalog=consultorio;Integrated Security=True;Pooling=False";

        //bd 2015
        static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\higor\Documents\GitHub\Consultorio-LP3\BD 2015\consultorio.mdf';Integrated Security=True;Connect Timeout=30";

        public static int Cadastrar(string pNomePaciente, string pTelefone)
        {
            string cmd = "Insert Into Paciente (nomePaciente, telefone) values (@nomePaciente, @Telefone)";
            int res = 0;

            SqlConnection conn = new SqlConnection(connection);

            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            sqlcmd.Parameters.AddWithValue("@nomePaciente", pNomePaciente);
            sqlcmd.Parameters.AddWithValue("@telefone", pTelefone);

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

        public static int Alterar(string pNomePaciente, string pTelefone, int pIdPaciente)
        {
            //texto com o comando que sera executado
            string cmd = "UPDATE Paciente " +
                "SET nomePaciente = @nomePaciente, telefone =@telefone WHERE IdPaciente = @idPaciente";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(connection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql

            sqlcmd.Parameters.AddWithValue("@nomePaciente", pNomePaciente);
            sqlcmd.Parameters.AddWithValue("@telefone", pTelefone);
            sqlcmd.Parameters.AddWithValue("@idPaciente", pIdPaciente);

            try
            {
                conn.Open();    //abre a conexao com o banco
                res = sqlcmd.ExecuteNonQuery(); //executa o comando no banco de dados

            }
            catch (Exception)
            {

               // throw;
            }
            finally
            {
                conn.Close();
            }

            return res;
        }

        public static int Excluir(int pIdPaciente)
        {
            //texto com o comando que sera executado
            string cmd = "DELETE FROM Paciente WHERE IdPaciente = @idPaciente";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(connection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql


            sqlcmd.Parameters.AddWithValue("@idPaciente", pIdPaciente);

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
            string cmd = "Select Paciente.IdPaciente AS ID, Paciente.nomePaciente AS Nome, Paciente.telefone AS Telefone from Paciente";

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

        public static DataSet pesquisa(String texto)
        {
            //texto com o comando sql que sera executado
            string cmd = "Select Paciente.IdPaciente AS ID, Paciente.nomePaciente AS Nome, Paciente.telefone AS Telefone FROM Paciente WHERE nomePaciente LIKE @texto";

            //objeto que ira fazer a conexao
            SqlConnection conn = new SqlConnection(connection);
            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            sqlcmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

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
