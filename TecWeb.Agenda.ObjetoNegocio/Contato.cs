using System;
using System.Collections.Generic;
using System.Text;

namespace TecWeb.Agenda.ObjetoNegocio
{
    public class Contato
    {
        private string categoriaNome;

        public string CategoriaNome
        {
            get { return categoriaNome; }
            set { categoriaNome = value; }
        }
        
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int usuarioID;

        public int UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }
        private int categoriaID;

        public int CategoriaID
        {
            get { return categoriaID; }
            set { categoriaID = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string logradouro;

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        private string enderecoEletronico;

        public string EnderecoEletronico
        {
            get { return enderecoEletronico; }
            set { enderecoEletronico = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        private string telefoneCelular;

        public string TelefoneCelular
        {
            get { return telefoneCelular; }
            set { telefoneCelular = value; }
        }
    }
}
