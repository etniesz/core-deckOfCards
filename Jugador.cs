class Jugador
{
    public string Nombre { get; set; }
    public List<Carta> Mano { get; set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
        Mano = new List<Carta>();
    }

    public Carta Robar(Mazo mazo)
    {
        Carta cartaRobada = mazo.Repartir();
        if (cartaRobada != null)
        {
            Mano.Add(cartaRobada);
        }
        return cartaRobada;
    }

    public Carta Descartar(int indice)
    {
        if (indice >= 0 && indice < Mano.Count)
        {
            Carta cartaDescartada = Mano[indice];
            Mano.RemoveAt(indice);
            return cartaDescartada;
        }
        else
        {
            Console.WriteLine("Índice de descarte no válido.");
            return null;
        }
    }

    public void ImprimirMano()
    {
        Console.WriteLine($"Mano de {Nombre}:");
        foreach (Carta carta in Mano)
        {
            carta.Print();
        }
    }
}