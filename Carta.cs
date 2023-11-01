class Carta
{
    public string Nombre { get; set; }
    public string Pinta { get; set; }
    public int Val { get; set; }

    public void Print()
    {
        Console.WriteLine($"Nombre: {Nombre}, Pinta: {Pinta}, Valor: {Val}");
    }

}