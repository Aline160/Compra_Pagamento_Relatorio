using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Dinheiro
    {
        public static decimal desconto = 0.05M;
        public Guid CodigoBarra { get; set; }
        public Guid Id { get; set; }
        public DateTime data { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Troco { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorFinal { get; set; }
        public bool Efetuada { get; set; }
        public bool Confirmacao { get; set; }
        public Dinheiro(decimal valorCompra, decimal valorRecebido)


        {
            ValorCompra = valorCompra;
            ValorRecebido = valorRecebido;
            data = DateTime.Now;
            Confirmacao = false;
        }
        public bool EstaPago()
        {
            return Confirmacao;
        }

        public void PagarAVista()
        {
            if (ValorCompra > ValorRecebido)
            {
                decimal diferenca = ValorCompra - ValorRecebido;
                Console.WriteLine("Valor não é suficiente para pagar, faltam: :( " + diferenca);
                Efetuada = false;

            }
            else if (ValorRecebido >= ValorCompra)
            {
                Desconto = (desconto * ValorCompra);
                ValorFinal = ValorCompra - Desconto;
                Troco = ValorRecebido - ValorFinal;
                Efetuada = true;
                Console.WriteLine("Teve um desconto de: " + Desconto);
                Console.WriteLine("Valor Final com Desconto: " + ValorFinal);
                Confirmacao = true;
            }
        }
    }
}