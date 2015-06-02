using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TecWeb.Agenda.ObjetoNegocio;

namespace TecWeb.Agenda.DAO
{
    public class ContatoDAO
    {
        private static string SQL_INSERIR_CONTATO = "INSERT INTO CONTATO(Categoria_ID, Usuario_ID, Nome, Logradouro, Numero, Bairro, Cidade, Estado, CEP, EnderecoEletronico, Email, Telefone, TelefoneCelular) VALUES(@Categoria_ID, @Usuario_ID, @Nome, @Logradouro, @Numero, @Bairro, @Cidade, @Estado, @CEP, @EnderecoEletronico, @Email, @Telefone, @TelefoneCelular)";
        private static string SQL_ALTERAR_CONTATO = "UPDATE CONTATO SET Categoria_ID=@Categoria_ID, Usuario_ID = @Usuario_ID, Nome = @Nome, Logradouro = @Logradouro, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, CEP = @CEP EnderecoEletronico = @EnderecoEletronico Email = @Email, Telefone = @Telefone, TelefoneCelular = @Telefone_Celular WHERE ID = @ID";
        private static string SQL_REMOVER_CONTATO = "DELETE FROM CONTATO WHERE ID = @ID";
        private static string SQL_SELECIONAR_CONTATOS = "SELECT Id, Categoria_ID, Usuario_ID, Nome, Logradouro, Numero, Bairro, Cidade, Estado, EnderecoEletronico, Email, Telefone, TelefoneCelular, Cep FROM CONTATO ";

        public List<Contato> ObterContatos(string nome, string logradouro, string cidade, string email, int categoria)
        {
            List<Contato> contatos = new List<Contato>();

            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_SELECIONAR_CONTATOS + "WHERE 1=1";

                if (nome != string.Empty)
                {
                    command.CommandText += "AND Nome Like '%" + nome + "%' ";
                }

                if (logradouro != string.Empty)
                {
                    command.CommandText += "AND Logradouro Like '%" + logradouro + "%' ";
                }


                if (cidade != string.Empty)
                {
                    command.CommandText += "AND Cidade Like '%" + cidade + "%' ";
                }

                if (email != string.Empty)
                {
                    command.CommandText += "AND Email Like '%" + email + "%' ";
                }

                if (categoria != 0)
                {
                    command.CommandText += "AND Categoria_ID = " + categoria;
                }

                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Contato contato = new Contato();

                    contato.Id = reader.GetInt32(0);
                    contato.CategoriaID = reader.GetInt32(1);
                    contato.UsuarioID = reader.GetInt32(2);
                    contato.Nome = reader.GetString(3);
                    contato.Logradouro = reader.GetString(4);
                    contato.Numero = reader.GetInt32(5);
                    contato.Bairro = reader.GetString(6);
                    contato.Cidade = reader.GetString(7);
                    contato.Estado = reader.GetString(8);
                    contato.EnderecoEletronico = reader.GetString(9);
                    contato.Email = reader.GetString(10);
                    contato.Telefone = reader.GetString(11);
                    contato.TelefoneCelular = reader.GetString(12);
                    contato.Cep = reader.GetString(13);
                    
                    CategoriaDAO categoriaDAO = new CategoriaDAO();
                    Categoria categoriaContato = categoriaDAO.ObterCategoria(contato.CategoriaID);
                    if (categoriaContato != null)
                    {
                        contato.CategoriaNome = categoriaContato.Nome;
                    }

                    contatos.Add(contato);
                }

                reader.Close();
            }

            return contatos;
        }

        public void AdicionarContato(Contato contato)
        {
            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_INSERIR_CONTATO;

                IDbDataParameter paramCategoriaID = command.CreateParameter();
                IDbDataParameter paramUsuarioID = command.CreateParameter();
                IDbDataParameter paramNome = command.CreateParameter();
                IDbDataParameter paramLogradouro = command.CreateParameter();
                IDbDataParameter paramNumero = command.CreateParameter();
                IDbDataParameter paramBairro = command.CreateParameter();
                IDbDataParameter paramCidade = command.CreateParameter();
                IDbDataParameter paramEstado = command.CreateParameter();
                IDbDataParameter paramCEP = command.CreateParameter();
                IDbDataParameter paramEnderecoEletronico = command.CreateParameter();
                IDbDataParameter paramEmail = command.CreateParameter();
                IDbDataParameter paramTelefone = command.CreateParameter();
                IDbDataParameter paramTelefoneCelular = command.CreateParameter();

                paramCategoriaID.ParameterName = "@Categoria_ID";
                paramUsuarioID.ParameterName = "@Usuario_ID";
                paramNome.ParameterName = "@Nome";
                paramLogradouro.ParameterName = "@Logradouro";
                paramNumero.ParameterName = "@Numero";
                paramBairro.ParameterName = "@Bairro";
                paramCidade.ParameterName = "@Cidade";
                paramEstado.ParameterName = "@Estado";
                paramCEP.ParameterName = "@CEP";
                paramEnderecoEletronico.ParameterName = "@EnderecoEletronico";
                paramEmail.ParameterName = "@Email";
                paramTelefone.ParameterName = "@Telefone";
                paramTelefoneCelular.ParameterName = "@TelefoneCelular";

                paramCategoriaID.Value = contato.CategoriaID;
                paramUsuarioID.Value = contato.UsuarioID;
                paramNome.Value = contato.Nome;
                paramLogradouro.Value = contato.Logradouro;
                paramNumero.Value = contato.Numero;
                paramBairro.Value = contato.Bairro;
                paramCidade.Value = contato.Cidade;
                paramEstado.Value = contato.Estado;
                paramCEP.Value = contato.Cep;
                paramEnderecoEletronico.Value = contato.EnderecoEletronico;
                paramEmail.Value = contato.Email;
                paramTelefone.Value = contato.Telefone;
                paramTelefoneCelular.Value = contato.TelefoneCelular;

                command.Parameters.Add(paramCategoriaID);
                command.Parameters.Add(paramUsuarioID);
                command.Parameters.Add(paramNome);
                command.Parameters.Add(paramLogradouro);
                command.Parameters.Add(paramNumero);
                command.Parameters.Add(paramBairro);
                command.Parameters.Add(paramCidade);
                command.Parameters.Add(paramEstado);
                command.Parameters.Add(paramCEP);
                command.Parameters.Add(paramEnderecoEletronico);
                command.Parameters.Add(paramEmail);
                command.Parameters.Add(paramTelefone);
                command.Parameters.Add(paramTelefoneCelular);

                command.ExecuteNonQuery();
            }
        }

        public void AlterarContato(Contato contato)
        {
            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_ALTERAR_CONTATO;

                IDbDataParameter paramCategoriaID = command.CreateParameter();
                IDbDataParameter paramUsuarioID = command.CreateParameter();
                IDbDataParameter paramNome = command.CreateParameter();
                IDbDataParameter paramLogradouro = command.CreateParameter();
                IDbDataParameter paramNumero = command.CreateParameter();
                IDbDataParameter paramBairro = command.CreateParameter();
                IDbDataParameter paramCidade = command.CreateParameter();
                IDbDataParameter paramEstado = command.CreateParameter();
                IDbDataParameter paramCEP = command.CreateParameter();
                IDbDataParameter paramEnderecoEletronico = command.CreateParameter();
                IDbDataParameter paramEmail = command.CreateParameter();
                IDbDataParameter paramTelefone = command.CreateParameter();
                IDbDataParameter paramTelefoneCelular = command.CreateParameter();
                IDbDataParameter paramID = command.CreateParameter();

                paramCategoriaID.ParameterName = "@Categoria_ID";
                paramUsuarioID.ParameterName = "@Usuario_ID";
                paramNome.ParameterName = "@Nome";
                paramLogradouro.ParameterName = "@Logradouro";
                paramNumero.ParameterName = "@Numero";
                paramCidade.ParameterName = "@Cidade";
                paramEstado.ParameterName = "@Estado";
                paramCEP.ParameterName = "@CEP";
                paramEnderecoEletronico.ParameterName = "@EnderecoEletronico";
                paramEmail.ParameterName = "@Email";
                paramTelefone.ParameterName = "@Telefone";
                paramTelefoneCelular.ParameterName = "@TelefoneCelular";
                paramID.ParameterName = "@ID";

                paramCategoriaID.Value = contato.CategoriaID;
                paramUsuarioID.Value = contato.UsuarioID;
                paramNome.Value = contato.Nome;
                paramLogradouro.Value = contato.Logradouro;
                paramNumero.Value = contato.Numero;
                paramCidade.Value = contato.Cidade;
                paramEstado.Value = contato.Estado;
                paramCEP.Value = contato.Cep;
                paramEnderecoEletronico.Value = contato.EnderecoEletronico;
                paramEmail.Value = contato.Email;
                paramTelefone.Value = contato.Telefone;
                paramTelefoneCelular.Value = contato.TelefoneCelular;
                paramID.Value = contato.Id;

                command.Parameters.Add(paramCategoriaID);
                command.Parameters.Add(paramUsuarioID);
                command.Parameters.Add(paramNome);
                command.Parameters.Add(paramLogradouro);
                command.Parameters.Add(paramNumero);
                command.Parameters.Add(paramCidade);
                command.Parameters.Add(paramEstado);
                command.Parameters.Add(paramCEP);
                command.Parameters.Add(paramEnderecoEletronico);
                command.Parameters.Add(paramEmail);
                command.Parameters.Add(paramTelefone);
                command.Parameters.Add(paramTelefoneCelular);
                command.Parameters.Add(paramID);

                command.ExecuteNonQuery();
            }
        }

        public void RemoverContato(Contato contato)
        {
            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_REMOVER_CONTATO;

                IDbDataParameter paramID = command.CreateParameter();

                paramID.ParameterName = "@ID";
                paramID.Value = contato.Id;

                command.Parameters.Add(paramID);

                command.ExecuteNonQuery();
            }
        }
    }
}
