namespace ejercicio7fechas
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Que fecha desea (dd/mm/yyyy) : ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos dias deseas: ");
            int dias = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fecha con los dias sumados: {fecha.AddDays(dias)}");
            Console.WriteLine($"Fecha con los dias restados: {fecha.AddDays(-dias)}");

        }
    }
}
