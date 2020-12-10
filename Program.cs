using System;
using POO_Abstracao.classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Clear();

           
            float valorRecebido;
            string opcao;
            int receberCodigo;
            string refazer;

          
            Pagamento pagamento1 = new Pagamento();
            Boleto boleto1 = new Boleto();            
            
            do{
                Console.WriteLine("Qual é o valor desejado para pagar");
                valorRecebido = float.Parse(Console.ReadLine());
                pagamento1.ReceberValor(valorRecebido);
                Console.WriteLine("");

                Console.WriteLine("Gostaria de pagar por boleto(b) ou por cartão(c)? 'b' ou 'c'");
                opcao = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Digite o seu código de barras: ");
                receberCodigo = int.Parse(Console.ReadLine());
                boleto1.RegistrarCodigoDeBarras(receberCodigo);
                Console.WriteLine("");

                Console.WriteLine(boleto1.Desconto(valorRecebido));
                

                Console.WriteLine("Gostaria de fazer outro pagamento?");
                refazer = Console.ReadLine();

            }while(refazer == "s" || refazer == "S");

            Console.WriteLine("Ótimo! Obrigado pela preferência.");
        }
    }
}