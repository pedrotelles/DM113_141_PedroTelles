using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EstoqueCliente.ServicoEstoque;
namespace EstoqueClienteV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();
            ServicoEstoqueClient proxy = new ServicoEstoqueClient("WS2007HttpBinding_IServicoEstoque");
            //Adicionar Produto 11

            Console.WriteLine("Teste 1: Estoque atual do produto 1:");
            Console.WriteLine("Estoque atual: " + proxy.ConsultarEstoque("1000").ToString());
            Console.WriteLine();

            Console.WriteLine("Teste 2: Adicionar 20 itens no estoque do produto 1");
            if (proxy.AdicionarEstoque("1000", 20))
            {
                Console.WriteLine("Adicionado 10 itens no estoque do Produto 2");
            }
            Console.WriteLine();

            Console.WriteLine("Teste 3: Estoque atual do produto 1:");
            Console.WriteLine("Estoque atual: " + proxy.ConsultarEstoque("1000").ToString());
            Console.WriteLine();

            Console.WriteLine("Teste 4: Estoque atual do produto 5:");
            Console.WriteLine("Estoque atual: " + proxy.ConsultarEstoque("5000").ToString());
            Console.WriteLine();

            Console.WriteLine("Teste 5: Remover 10 unidades do produto 5:");
            if (proxy.RemoverEstoque("5000", 10))
            {
                Console.WriteLine("Removido 10 itens no estoque do Produto 5");
            }
            Console.WriteLine();

            Console.WriteLine("Teste 6: Estoque atual do produto 5:");
            Console.WriteLine("Estoque atual: " + proxy.ConsultarEstoque("5000").ToString());
            Console.WriteLine();

            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
