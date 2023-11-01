class Program
{
    static void Main(string[] args)
    {
        // Carta cartaEjemplo = new Carta
        // {
        //     Nombre = "As",
        //     Pinta = "Corazones",
        //     Val = 1
        // };

        // cartaEjemplo.Print();

        Mazo mazo = new Mazo();
        mazo.Barajar();

        foreach (Carta carta in mazo.Cartas)
        {
            carta.Print();
        }

        Jugador jugador1 = new Jugador("Jugador 1");
        jugador1.Robar(mazo);
        jugador1.Robar(mazo);
        jugador1.Robar(mazo);

        jugador1.ImprimirMano();

        jugador1.Descartar(1);

        jugador1.ImprimirMano();
    }
}