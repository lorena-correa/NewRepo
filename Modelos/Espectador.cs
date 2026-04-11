public class Espectador : Usuario
{
    public Espectador(string idUsuario) : base(idUsuario) { }

    public override void RealizarOferta(decimal monto)
    {
        throw new Exception("No puede ofertar");
    }
}