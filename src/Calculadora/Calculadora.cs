namespace Calculadora;

public static class Operaciones
{
    public static int Sumar(int a, int b) => a + b;

    public static int Restar(int a, int b) => a - b;

    public static int Multiplicar(int a, int b) => a * b;

    public static int Dividir(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("No se puede dividir entre cero.");

        return a / b;
    }
}
