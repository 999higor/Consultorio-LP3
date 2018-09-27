using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabson.DAL
{
    class MedicoDAL

    {   //sql server 2015 ifrs
        //static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Administrador\Documents\Visual Studio 2015\Projects\consultorio.mdf';Integrated Security=True;Connect Timeout=30";
        
        //sql server 2017 pc
        static string connection = @"Data Source=HIGOR\SQLEXPRESS;Initial Catalog=consultorio;Integrated Security=True;Pooling=False";

        
        public static int Cadastrar(string pNomeMedico, string pCRM)
        {
            string cmd = "Insert Into Medico (nomeMedico, CRM) values (@nomeMedico, @CRM)";
            int res = 0;

            SqlConnection conn = new SqlConnection(connection);
           
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            sqlcmd.Parameters.AddWithValue("@nomeMedico", pNomeMedico);
            sqlcmd.Parameters.AddWithValue("@CRM", pCRM);

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

        public static int Alterar(string pNomeMedico, string pCRM,  int pIdMedico)
        {
            //texto com o comando que sera executado
            string cmd = "UPDATE Medico " +
                "SET nomeMedico = @Nome, CRM =@CRM  WHERE IdMedico = @ID";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(connection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql

            sqlcmd.Parameters.AddWithValue("@Nome", pNomeMedico);
            sqlcmd.Parameters.AddWithValue("@CRM", pCRM);
            sqlcmd.Parameters.AddWithValue("@ID", pIdMedico);

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

        public static int Excluir(int pIdMedico)
        {
            //texto com o comando que sera executado
            string cmd = "DELETE FROM Medico WHERE IdMedico = @idMedico";
            int res = 0;

            // objeto que fara a conexao
            SqlConnection conn = new SqlConnection(connection);

            //objeto que ira executar o comando sql
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);

            //adiciona valores aos parametros do sql


            sqlcmd.Parameters.AddWithValue("@idMedico", pIdMedico);

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
            string cmd = "Select Medico.IdMedico AS ID, Medico.nomeMedico AS Nome, Medico.CRM AS CRM from Medico";

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
            string cmd = "Select Medico.IdMedico AS ID, Medico.nomeMedico AS Nome, Medico.CRM AS CRM FROM Medico WHERE nomeMedico LIKE @texto";

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

                throw;
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }


    }
}
