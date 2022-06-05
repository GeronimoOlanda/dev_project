using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gethay_Console.Controller
{
    internal class Pessoa
    {
        private string _Name;
        private string _Age;
        private string _Email;
        private string _Password;
        private string _cpf;
        private int _rg;
        private int _telefone;
         
        public Pessoa(string name, string age, string email, string password, string cpf, int rg, int telefone)
        {
            this._Name = name;
            this._Age = age;
            this._Email = email;
            this._Password = password;
            this._cpf = cpf;
            this._rg = rg;
            this._telefone = telefone;
        }

        //formataçã do CPF em C# (utilizando formato de string)
        public string FormateCPF()
        { 
            return Convert.ToUInt64(_cpf).ToString(@"000\.000\.000\-00");
        }

        //Formatação do Telefone
        public string FormateTelefone()
        {
            return Convert.ToUInt64(_telefone).ToString(@"0\.0000\-0000");
        }

     

    }
}
