class Program
{
    static void Main(string[] args)
    {
   
        Jugador jugador1 = new Jugador(
            "Lionel Messi",
            "12345678A",
            new DateTime(1987, 6, 24),
            10);

       
        Console.WriteLine("Información del Jugador:");
        jugador1.MostrarInformacion();
    }
}