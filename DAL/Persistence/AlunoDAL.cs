using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Biblioteca de acesso ao SQL SERVER
using DAL.Model;

namespace DAL.Persistence
{
    public class AlunoDAL : Conexao
    {
        //metodo - GRAVAR DADOS - INSERT:
        public void Gravar(Aluno p)
        {
            try
            {
                //ABRIR A CONEXAO:
                AbrirConexao();

               
                Cmd = new SqlCommand("insert into Aluno(Nome, Data_Nasc, Idade, Objetivo_Graduacao, Genero) values(@v1, @v2, @v3, @v4, @v5)", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Data_Nasc);
                Cmd.Parameters.AddWithValue("@v3", p.Idade);
                Cmd.Parameters.AddWithValue("@v4", p.Objetivo_Graduacao);
                Cmd.Parameters.AddWithValue("@v5", p.Genero);


                Cmd.ExecuteNonQuery();//EXECUTA NOSSO METODO!!!

              
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar Aluno:" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //METODO - ATUALIZAR DADOS - UPDATE:
        public void Atualizar(Aluno p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Aluno set Nome=@v1, Data_Nasc=@v2, Idade=@v3, Objetivo_Graduacao=@v4, Genero=@v5 where Codigo=@v6", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Data_Nasc);
                Cmd.Parameters.AddWithValue("@v3", p.Idade);
                Cmd.Parameters.AddWithValue("@v4", p.Objetivo_Graduacao);
                Cmd.Parameters.AddWithValue("@v5", p.Genero);
                Cmd.Parameters.AddWithValue("@v6", p.Codigo);
                

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Atualixar o Aluno:" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //NETODO - EXCLUIR DADOS - DELETE:
        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Aluno where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Excluir o Aluno:" + ex.Message);
            }
            finally
            {

            }
        }

        //METODO PARA OBTER PESSOA PELO ID:
        public Aluno PesquisarporCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluno where Codigo=@v1", Con);
                Cmd.Parameters.AddWithValue("@V1", Codigo);
                Dr = Cmd.ExecuteReader();//execução da leitura das informações no BD;

                Aluno p = null; //criando espaco de memoria: ponteiro

                if (Dr.Read())
                {
                    p = new Aluno();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Data_Nasc = Convert.ToString(Dr["Data_Nasc"]);
                    p.Idade = Convert.ToString(Dr["Idade"]);
                    p.Objetivo_Graduacao = Convert.ToString(Dr["Objetivo_Graduacao"]);
                    p.Genero = Convert.ToString(Dr["Genero"]);

                }
                return p;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar Aluno: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //METODO PARA LISTAR TODAS AS PESSOAS CADASTRASAOS:
        public List<Aluno> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluno", Con);
                Dr = Cmd.ExecuteReader();

                List<Aluno> lista = new List<Aluno>();

                while (Dr.Read())
                {
                    Aluno p = new Aluno();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Data_Nasc= Convert.ToString(Dr["Idade"]);
                    p.Objetivo_Graduacao = Convert.ToString(Dr["Objetivo_Graduacao"]);
                    p.Genero = Convert.ToString(Dr["Genero"]);

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar os Aluno " + ex.Message);

            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
