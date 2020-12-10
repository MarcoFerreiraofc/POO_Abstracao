using System;

namespace POO_Abstracao.classes
{
    public class Boleto:Pagamento
    {
        private int codigoDeBarras;
        private double valorFinalBoleto;
        private double valorMultiplicadoBoleto;
        private double porcentagemBoleto = 0.12;
     
        public void RegistrarCodigoDeBarras(int receberCodigoDeBarras){
            codigoDeBarras = receberCodigoDeBarras;
        }
        public string Desconto(double valorRecebido){
            valorMultiplicadoBoleto = valorRecebido * porcentagemBoleto;
            valorFinalBoleto = valorRecebido - valorMultiplicadoBoleto;
            
            return "Valor a pagar SEM o desconto do boleto: "+valorRecebido+"\n Valor a pagar COM o desconto do boleto: "+valorFinalBoleto;
        }
    }
}