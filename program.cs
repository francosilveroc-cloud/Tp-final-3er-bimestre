public class Program
{
    public static void Main(string[] args)
    {

        Liquidacion liquidacion = new Liquidacion();


        Vendedor vendedor1 = new Vendedor(
            "Pablito",
            "12345678",
            500000,
            50000
        );

        Vendedor vendedor2 = new Vendedor(
            "Pelotita",
            "23456789",
            600000,
            70000
        );


        Directivo directivo1 = new Directivo(
            "Bruneldo",
            "34567890",
            800000,
            150000
        );

        Directivo directivo2 = new Directivo(
            "Champaña",
            "45678901",
            900000,
            200000
        );

        liquidacion.AgregarEmpleado(vendedor1);
        liquidacion.AgregarEmpleado(vendedor2);
        liquidacion.AgregarEmpleado(directivo1);
        liquidacion.AgregarEmpleado(directivo2);

 
        liquidacion.MostrarLiquidacion();
    }
}