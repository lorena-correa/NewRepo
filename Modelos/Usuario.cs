public abstract class Usuario
{
    public string idUsuario { get; set; }

    public Usuario(string idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public abstract void RealizarOferta(decimal monto);
}