using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Calculadora;

namespace CalculadoraTest
{
    public class CalculadoraTest
    {

        private CalculadoraImp _calculadora = new CalculadoraImp();

        [Fact]
        public void Somar5Com10Retorna15()
        {
            int resultado = _calculadora.soma(5, 10);

            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Subtrair5de10Retorna5()
        {
            int resultado = _calculadora.subtracao(10, 5);

            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Multiplicar5por2Retornar10()
        {
            int resultado = _calculadora.multiplicacao(2, 5);

            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Dividir10por2Retorna5()
        {
            int resultado = _calculadora.divisao(10, 2);

            Assert.Equal(5, resultado);
        }

        [Fact]
        public void AoFazer3OperacoesConsultarHistoricoDevoverListaCom3elementos()
        {

            _calculadora.soma(2, 2);
            _calculadora.subtracao(2, 2);
            _calculadora.multiplicacao(2, 2);
            var listaHistorticoResultados = _calculadora.historicoResultados();

            Assert.Equal(3, listaHistorticoResultados.Count);

        }
    }
}