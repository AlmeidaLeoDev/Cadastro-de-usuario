using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Usuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Pressione C para cadastrar um usuário e S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower(); //a letra vai ser passada para "opcao" depois será transformada em string e transformada em minúscula
                if (opcao == "c")
                {
                     Console.WriteLine("Digite o seu nome completo: ");
                     string nome = Console.ReadLine();
                     Console.WriteLine("Pressione M para masculino e F para feminino: ");
                     char genero = Console.ReadKey(true).KeyChar;
                     Console.WriteLine("Digite a data de nascimento no formato dd/mm/aaaa: ");
                     DateTime data = Convert.ToDateTime(Console.ReadLine()); //irá ocorrer a conversão do que o usuário digitar para "DateTime"
                     Console.WriteLine("Digite o nome da sua rua: ");
                     string nomeDaRua = Console.ReadLine();
                     Console.WriteLine("Digite o número da casa: ");
                     UInt32 numeroDaCasa = Convert.ToUInt32(Console.ReadLine()); //irá ocorrer a conversão do que o usuário digitar para "UInt32"
                     Console.Clear();
                }
                else if(opcao == "s")
                {
                     Console.WriteLine("Encerrando o programa");
                }
                else
                {
                     Console.WriteLine("Opção desconhecida");
                }
            }while (opcao != "s"); //condição vai ser executada enquanto for diferente de "S"

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
