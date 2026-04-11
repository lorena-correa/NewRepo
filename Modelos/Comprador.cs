public class Comprador: Usuario
{
    public Comprador(string idUsuario): base(idUsuario) {}

    public override void RealizarOferta(decimal monto)
    {
        Console.WriteLine($"{idUsuario} ofertó {monto}");
    }
}