public class Empleado
{
    // ENCAPSULAMIENTO:
    private string nombre;
    private string dni;
    private double sueldoBase;

    // Constructor
    public Empleado(string nombre, string dni, double sueldoBase)
    {
        this.nombre = nombre;
        this.dni = dni;
        this.sueldoBase = sueldoBase;
    }

    // Métodos para acceder a los datos privados.
    public string GetNombre()
    {
        return nombre;
    }

    public string GetDni()
    {
        return dni;
    }

    public double GetSueldoBase()
    {
        return sueldoBase;
    }

   
    public virtual double CalcularPagoFinal()
    {
        return sueldoBase;
    }
}