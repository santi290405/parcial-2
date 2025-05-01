public class Jugador : Persona
{

    public int NumFed { get; set; }


    public Jugador(string nombre, string nif, DateTime fechaNac, int numFed)
        : base(nombre, nif, fechaNac)
    {
        NumFed = numFed;
    }

  
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Número de Federado: {NumFed}");
    }
}

