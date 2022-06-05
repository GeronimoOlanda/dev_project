using Gethay_Console.Controller;

namespace Gethay_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa =  new Pessoa( 
                                            name: "Geronimo", 
                                            age: "24", 
                                            email: "geronim@outlook.com",
                                            password: "Teste421@eq2@dd",
                                            cpf: "42553611314",
                                            rg: 624432142,
                                            telefone: 932544825
                                        );

           
            Console.WriteLine("CPF = " + pessoa.FormateCPF());
            Console.WriteLine("Telefone = " + pessoa.FormateTelefone());
        }
    }
}