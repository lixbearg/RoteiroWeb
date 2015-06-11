using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TecWeb.Agenda.ObjetoNegocio;

namespace TecWeb.WS.DAO
{
    public class UsuarioDAO
    {
        private static string SQL_INSERIR_USUARIO = "INSERT INTO USUARIO(Nome, NomeUsuario, Senha) VALUES(@Nome, @NomeUsuario, @Senha)";
        private static string SQL_ALTERAR_USUARIO = "UPDATE USUARIO SET Nome=@Nome, Senha=@Senha WHERE ID = @ID";
        private static string SQL_REMOVER_USUARIO = "DELETE FROM USUARIO WHERE ID = @ID";
        private static string SQL_VERIFICAR_USUARIO = "SELECT COUNT(*) FROM USUARIO WHERE NomeUsuario = @NomeUsuario";
        private static string SQL_LOGIN_USUARIO = "SELECT Id, Nome, NomeUsuario, Senha FROM USUARIO WHERE NomeUsuario = @NomeUsuario AND Senha = @Senha";
        private static string SQL_OBTER_USUARIO = "SELECT Id, Nome, NomeUsuario, Senha FROM USUARIO WHERE Id = @Id";
        private static string SQL_OBTER_USUARIO_NOMEUSUARIO = "SELECT Id, Nome, NomeUsuario, Senha FROM USUARIO WHERE NomeUsuario = @NomeUsuario";

        public bool VerificarExistencia(string nomeUsuario)
        {
            bool existe = false;

            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_VERIFICAR_USUARIO;

                IDbDataParameter paramNomeUsuario = command.CreateParameter();

                paramNomeUsuario.ParameterName = "@NomeUsuario";
                paramNomeUsuario.Value = nomeUsuario;

                command.Parameters.Add(paramNomeUsuario);

                existe = ((int) command.ExecuteScalar()) > 0;
            }

            return existe;
        }

        public Usuario ObterUsuario(string nomeUsuario, string senha)
        {
            Usuario usuario = null;

            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_LOGIN_USUARIO;

                IDbDataParameter paramNomeUsuario = command.CreateParameter();
                IDbDataParameter paramSenha = command.CreateParameter();

                paramNomeUsuario.ParameterName = "@NomeUsuario";
                paramNomeUsuario.Value = nomeUsuario;
                paramSenha.ParameterName = "@Senha";
                paramSenha.Value = senha;

                command.Parameters.Add(paramNomeUsuario);
                command.Parameters.Add(paramSenha);

                IDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.Id = reader.GetInt32(0);
                    usuario.Nome = reader.GetString(1);
                    usuario.NomeUsuario = reader.GetString(2);
                    usuario.Senha = reader.GetString(3);
                }

                reader.Close();
            }

            return usuario;
        }

        public Usuario ObterUsuario(string nomeUsuario)
        {
            Usuario usuario = null;

            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_OBTER_USUARIO_NOMEUSUARIO;

                IDbDataParameter paramNomeUsuario = command.CreateParameter();
                IDbDataParameter paramSenha = command.CreateParameter();

                paramNomeUsuario.ParameterName = "@NomeUsuario";
                paramNomeUsuario.Value = nomeUsuario;

                command.Parameters.Add(paramNomeUsuario);

                IDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.Id = reader.GetInt32(0);
                    usuario.Nome = reader.GetString(1);
                    usuario.NomeUsuario = reader.GetString(2);
                    usuario.Senha = reader.GetString(3);
                }

                reader.Close();
            }

            return usuario;
        }

        public Usuario ObterUsuario(int id)
        {
            Usuario usuario = null;

            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_OBTER_USUARIO;

                IDbDataParameter paramID = command.CreateParameter();

                paramID.ParameterName = "@Id";
                paramID.Value = id;

                command.Parameters.Add(paramID);

                IDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.Id = reader.GetInt32(0);
                    usuario.Nome = reader.GetString(1);
                    usuario.NomeUsuario = reader.GetString(2);
                    usuario.Senha = reader.GetString(3);
                }

                reader.Close();
            }

            return usuario;
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_INSERIR_USUARIO;

                IDbDataParameter paramNome = command.CreateParameter();
                IDbDataParameter paramNomeUsuario = command.CreateParameter();
                IDbDataParameter paramSenha = command.CreateParameter();

                paramNome.ParameterName = "@Nome";
                paramNome.Value = usuario.Nome;
                paramNomeUsuario.ParameterName = "@NomeUsuario";
                paramNomeUsuario.Value = usuario.NomeUsuario;
                paramSenha.ParameterName = "@Senha";
                paramSenha.Value = usuario.Senha;

                command.Parameters.Add(paramNome);
                command.Parameters.Add(paramNomeUsuario);
                command.Parameters.Add(paramSenha);

                command.ExecuteNonQuery();
            }
        }

        public void AlterarUsuario(Usuario usuario)
        {
            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_ALTERAR_USUARIO;

                IDbDataParameter paramNome = command.CreateParameter();
                IDbDataParameter paramSenha = command.CreateParameter();
                IDbDataParameter paramID = command.CreateParameter();

                paramNome.ParameterName = "@Nome";
                paramSenha.ParameterName = "@Senha";
                paramSenha.Value = usuario.Senha;
                paramID.ParameterName = "@ID";
                paramID.Value = usuario.Id;

                command.Parameters.Add(paramNome);
                command.Parameters.Add(paramSenha);
                command.Parameters.Add(paramID);

                command.ExecuteNonQuery();
            }
        }

        public void RemoverUsuario(Usuario usuario)
        {
            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_REMOVER_USUARIO;

                IDbDataParameter paramID = command.CreateParameter();

                paramID.ParameterName = "@ID";
                paramID.Value = usuario.Id;

                command.Parameters.Add(paramID);

                command.ExecuteNonQuery();
            }
        }
    }
}
