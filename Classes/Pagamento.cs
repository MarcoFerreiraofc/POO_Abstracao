using System;

namespace POO_Abstracao.classes
{
    public class Pagamento
    {
        
        private DateTime data;
        protected double valor;
        public bool Cancelar(string resposta){
            if(resposta == "s"){
                return true;
            }
            return false;
        }
        public void ReceberValor(float valorRecebido){
            this.valor = valorRecebido;
        }
        public void ExibirValor(){
            Console.WriteLine("Seu valor a pagar é: "+this.valor);
        }
        
    }
}