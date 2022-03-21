using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente usuário = new cliente();
            pedido p = new pedido();
            
            //obtenção de informações do cliente
            Console.WriteLine("Informe seu nome: ");
            usuário.nome = Console.ReadLine();
            Console.WriteLine("Qual seu endereço " + usuário.nome + "?");
            usuário.endereço = Console.ReadLine();
            Console.WriteLine("Qual seu numero de contato " + usuário.nome + "?");
            usuário.telefone = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a forma de pagamento? \n1 - Cartão Débito ou Crédito \n2 - Dinheiro" );
            usuário.pagamento = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código do sabor da sua pizza: ");
            Console.WriteLine("1 - Portuguesa | 59,99 \n2 - Frango c/catupiry | 63,00 \n3 - Calabresa | 59,99");
            p.pizza = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código da sua bebida: ");
            Console.WriteLine("1 - Coca Cola 6,00 \n2 - Guaraná 4,50 \n3 - Pepsi 5,00" );
            p.bebida = int.Parse(Console.ReadLine());

            
            //condições para obtenção do valor final do pedido
            if (p.pizza == 1 || p.pizza == 3 && p.bebida == 1)
            {
                p.pizza = 59.99;
                p.bebida = 6.00;
            }
            else if (p.pizza == 1 || p.pizza == 3 && p.bebida == 2)
            {
                p.pizza = 59.99;
                p.bebida = 4.50;
            }
            else if (p.pizza == 1 || p.pizza == 3 && p.bebida == 3)
            {
                p.pizza = 59.99;
                p.bebida = 5.00;
            }
            else if (p.pizza == 2 && p.bebida == 1)
            {
                p.pizza = 59.99;
                p.bebida = 6.00;
            }
            else if (p.pizza == 2 && p.bebida == 2)
            {
                p.pizza = 59.99;
                p.bebida = 4.50;
            }
            else if(p.pizza == 2 && p.bebida == 3)
            {
                p.pizza = 59.99;
                p.bebida = 5.00;
            }

            //informações do pedido
            Console.WriteLine("Informações do pedido \n" + usuário.getCliente() + "\n" + "Valor do Pedido: " + p.getValor(p.pizza,p.bebida) + "\n" + "Forma de pagamento: " + usuário.getFormapagamento(usuário.pagamento));
            Console.ReadLine();

        }
    }
}
