namespace edu.PR.Ejercicio2._2901
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           DateTime fechaActual= DateTime.Now;

            Console.WriteLine("Dia: " + fechaActual.Day);
            Console.WriteLine("Mes: " + fechaActual.Month);
            Console.WriteLine("Año: " + fechaActual.Year);
            Console.WriteLine("Hora: " + fechaActual.Hour);
            Console.WriteLine("Minutos: " + fechaActual.Minute);
            Console.WriteLine("Segundos: " + fechaActual.Second);
            Console.WriteLine("Dia de la semana: " + fechaActual.DayOfWeek);
            Console.WriteLine("Dia del año: " + fechaActual.DayOfYear);
           


        }
    }
}