using System;
using System.Collections.Generic;
using System.Text;

namespace TecWeb.Agenda.ObjetoNegocio
{
    public class Usuario
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
        private string nomeUsuario;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
