using Calculadora;

namespace Calculadora.Tests;

public class OperacionesTests
{
    [Fact]
    public void Sumar_DosNumeros_RegresaLaSuma()
    {
        Assert.Equal(5, Operaciones.Sumar(2, 3));
    }

    [Fact]
    public void Restar_DosNumeros_RegresaLaResta()
    {
        Assert.Equal(3, Operaciones.Restar(7, 4));
    }

    [Theory]
    [InlineData(6, 5, 30)]
    [InlineData(-2, 4, -8)]
    [InlineData(0, 9, 0)]
    public void Multiplicar_DosNumeros_RegresaElProducto(int a, int b, int esperado)
    {
        Assert.Equal(esperado, Operaciones.Multiplicar(a, b));
    }

    [Fact]
    public void Dividir_DosNumeros_RegresaElCociente()
    {
        Assert.Equal(4, Operaciones.Dividir(8, 2));
    }

    [Fact]
    public void Dividir_EntreCero_LanzaExcepcion()
    {
        Assert.Throws<DivideByZeroException>(() => Operaciones.Dividir(1, 0));
    }
}
