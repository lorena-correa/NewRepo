public class Subasta
{
    public string NombreProducto { get; set; }
    public decimal PrecioActual { get; set; }
    public bool Activa { get; set; } = true;

    public UsuarioDTO Ganador { get; set; }

    public SubastaStrategy Estrategia { get; set; }

    public void Ofertar(UsuarioDTO usuario, decimal monto)
    {
        if (!Activa)
            throw new Exception("La subasta está cerrada");

        Estrategia.RealizarOferta(this, usuario, monto);
    }
}