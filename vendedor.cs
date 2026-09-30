// HERENCIA:
public class Vendedor : Empleado
{
    private double comision;


    public Vendedor(string nombre, string dni, double sueldoBase, double comision)
        : base(nombre, dni, sueldoBase)
    {
        this.comision = comision;
    }

    public double GetComision()
    {
        return comision;
    }

    // POLIMORFISMO:
    public override double CalcularPagoFinal()
    {
        return GetSueldoBase() + comision;
    }
}