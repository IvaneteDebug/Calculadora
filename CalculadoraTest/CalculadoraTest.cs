using Xunit;

namespace Calculadora.Test
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(20, Calculadora.Somar(10, 10));
            Assert.Equal(40, Calculadora.Somar(20, 20));
            Assert.Equal(70, Calculadora.Somar(50, 20));
            Assert.Equal(30, Calculadora.Somar(50, -20));
            Assert.Equal(-780, Calculadora.Somar(-300, -480));
            Assert.Equal(-433, Calculadora.Somar(490, -923));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, Calculadora.Subtrair(10, 10));
            Assert.Equal(50, Calculadora.Subtrair(70, 20));
            Assert.Equal(30, Calculadora.Subtrair(50, 20));
            Assert.Equal(-70, Calculadora.Subtrair(-50, 20));
            Assert.Equal(-590, Calculadora.Subtrair(-500, 90));
            Assert.Equal(-137, Calculadora.Subtrair(-97, 40));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(100, Calculadora.Multiplicar(10, 10));
            Assert.Equal(400, Calculadora.Multiplicar(20, 20));
            Assert.Equal(1000, Calculadora.Multiplicar(50, 20));
            Assert.Equal(-3900, Calculadora.Multiplicar(13, -300));
            Assert.Equal(-522000, Calculadora.Multiplicar(900, -580));
            Assert.Equal(-8750, Calculadora.Multiplicar(35, -250));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, Calculadora.Dividir(10, 10));
            Assert.Equal(4, Calculadora.Dividir(20, 5));
            Assert.Equal(0, Calculadora.Dividir(50, 500));
            Assert.Equal(0, Calculadora.Dividir(-50, -500));
            Assert.Equal(2, Calculadora.Dividir(-700, -280));
            Assert.Equal(0, Calculadora.Dividir(-7, -290));
        }
    }
}