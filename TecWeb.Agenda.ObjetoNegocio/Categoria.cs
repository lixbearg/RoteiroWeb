using System;
using System.Collections.Generic;
using System.Text;

namespace TecWeb.Agenda.ObjetoNegocio
{
    public class Categoria
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
