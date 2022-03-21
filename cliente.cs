using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPizzaria
{
    class cliente
    {
        public string nome, endereço;
        public float telefone;       
        public int pagamento;

        public cliente() 
        {
        }
        
        public string getCliente()
        {
            string infoCliente = "Nome: " + nome + "\n" +"endereço de entrega: " + endereço + "\n" + "Telefone de contato: " + telefone;
            return infoCliente;
        }
        public string getFormapagamento(int x)
        {
            string msg = "";
            switch (x)
            {
                case 1:
                    msg = "Cartão de débito ou crédito";
                        break;
                case 2:
                    msg = "Dinheiro";
                    break;
            }
            return msg;
        }
       

    }
}
