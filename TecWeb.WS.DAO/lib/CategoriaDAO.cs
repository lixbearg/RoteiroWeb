using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TecWeb.Agenda.ObjetoNegocio;

namespace TecWeb.WS.DAO
{
    public class CategoriaDAO
    {
        private static string SQL_SELECIONAR_CATEGORIAS = "SELECT Id, Nome FROM CATEGORIA ORDER BY ID";
        private static string SQL_SELECIONAR_CATEGORIAS_ID = "SELECT Id, Nome FROM CATEGORIA WHERE ID = @ID ORDER BY ID";

        public IList<Categoria> ObterCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_SELECIONAR_CATEGORIAS;

                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = reader.GetInt32(0);
                    categoria.Nome = reader.GetString(1);

                    categorias.Add(categoria);
                }

                reader.Close();
            }

            return categorias;
        }

        public Categoria ObterCategoria(int id)
        {
            Categoria categoria = null;

            using (IDbConnection connection = Util.ObterConexao())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = SQL_SELECIONAR_CATEGORIAS_ID;

                IDbDataParameter paramID = command.CreateParameter();

                paramID.ParameterName = "@ID";
                paramID.Value = id;

                command.Parameters.Add(paramID);

                IDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    categoria = new Categoria();
                    categoria.Id = reader.GetInt32(0);
                    categoria.Nome = reader.GetString(1);
                }

                reader.Close();
            }

            return categoria;
        }
    }
}
