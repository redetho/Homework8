using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class pessoa
    {
        //declara nome e email dentro de Pessoa
        public string Nome { get; set; }
        public string Email { get; set; }
        //constructor
        public pessoa(string nome, string email) 
        {
            Nome = nome;
            Email = email;
        }
        //override
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
