// HERENCIA:
public class Directivo : Empleado
{
    private double bono;

    public Directivo(string nombre, string dni, double sueldoBase, double bono)
        : base(nombre, dni, sueldoBase)
    {
        this.bono = bono;
    }

    public double GetBono()
    {
        return bono;
    }

    // POLIMORFISMO:
    public override double CalcularPagoFinal()
    {
        return GetSueldoBase() + bono;
    }
}