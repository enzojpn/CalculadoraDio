using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraImp
    {
        private List<string> historico { get; set; }

public CalculadoraImp()
{
    historico = new List<string>();
}
        public int soma(int a, int b)
        {
            int resultado = a + b;
            adicionaListaHistorico("res sum: " + resultado);
            return resultado;
        }
        public int subtracao(int a, int b)
        {
            int resultado = a - b;
            adicionaListaHistorico("res sub: " + resultado);
            return resultado;
        }
        public int multiplicacao(int a, int b)
        {
            int resultado = a * b;
            adicionaListaHistorico("res pls: " + resultado);
            return resultado;
        }
        public int divisao(int a, int b)
        {
            int resultado = a / b;
            adicionaListaHistorico("res div: " + resultado);
            return resultado;
        }

        public List<string> historicoResultados()
        {
            return historico;
        }

        private void adicionaListaHistorico(string resultado)
        {

            if (historico.Count > 3)
            {
                historico.RemoveRange(3, historico.Count - 3);
            }
            historico.Add(resultado);
        }


    }
}