using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gethay_Console.Model
{
    internal class PessoaModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public double Heigth { get; set; }
        public double Weight { get; set; }
        public DateTime? Data { get; set; }
    }
}
