using System;
using System.Collections.Generic;

public class Liquidacion
{
    // ENCAPSULAMIENTO:
    private List<Empleado> empleados;

    public Liquidacion()
    {
        empleados = new List<Empleado>();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        empleados.Add(empleado);
    }

    public void MostrarLiquidacion()
    {
        Console.WriteLine("===== LIQUIDACION DE HABERES =====");
        Console.WriteLine();

        foreach (Empleado empleado in empleados)
        {
            // POLIMORFISMO:
            double pago = empleado.CalcularPagoFinal();

            Console.WriteLine("Nombre: " + empleado.GetNombre());
            Console.WriteLine("DNI: " + empleado.GetDni());
            Console.WriteLine("Sueldo base: $" + empleado.GetSueldoBase());
            Console.WriteLine("Monto a depositar: $" + pago);
            Console.WriteLine("-------------------------------");
        }
    }
}