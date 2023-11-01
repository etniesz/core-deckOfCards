class Mazo
{
	public List<Carta> Cartas { get; set; }

	public Mazo()
	{
		Cartas = new List<Carta>();
		InicializarMazo();
	}

	public void InicializarMazo()
	{
		Cartas = new List<Carta>();
		string[] pintas = { "Tréboles", "Picas", "Corazones", "Diamantes" };
		string[] nombres = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Reina", "Rey" };

		foreach (var pinta in pintas)
		{
			for (int i = 0; i < nombres.Length; i++)
			{
				Cartas.Add(new Carta() { Nombre = nombres[i], Pinta = pinta, Val = i + 1 });
			}
		}
	}

	public Carta Repartir()
	{
		if (Cartas.Count > 0)
		{
			Carta cartaRepartida = Cartas[Cartas.Count - 1];
			Cartas.RemoveAt(Cartas.Count - 1);
			return cartaRepartida;
		}
		else
		{
			Console.WriteLine("No quedan cartas en el mazo.");
			return null;
		}
	}

	public void Barajar()
	{
		Random rng = new Random();
		int n = Cartas.Count;
		while (n > 1)
		{
			n--;
			int k = rng.Next(n + 1);
			Carta carta = Cartas[k];
			Cartas[k] = Cartas[n];
			Cartas[n] = carta;
		}
	}

	public void Reiniciar()
	{
		Cartas.Clear();
		InicializarMazo();
	}
}
