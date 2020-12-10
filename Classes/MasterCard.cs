using System;
using POO_Abstracao.Classes;
namespace POO_Abstracao.Classes
{
    public class MasterCard: Cartao
    {
        private int parcelas;

        public void ExibirLimite(){
            System.Console.WriteLine(this.limite);
        }
        public string ComprarComDesconto(){
            return"";
        }
    }
}