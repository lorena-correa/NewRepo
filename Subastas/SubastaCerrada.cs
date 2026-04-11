public class SubastaCerrada : SubastaStrategy
{
    private Dictionary<UsuarioDTO, decimal> ofertas = new();

    public void RealizarOferta(Subasta subasta, UsuarioDTO usuario, decimal monto)
    {
        if (ofertas.ContainsKey(usuario)) throw new Exception("Ya ofertaste");
        ofertas[usuario] = monto;
    }

    public void Cerrar(Subasta subasta)
    {
        var mejor = ofertas.OrderByDescending(e => e.Value).FirstOrDefault();

        subasta.Ganador = mejor.Key;
        subasta.PrecioActual = mejor.Value;
        subasta.Activa = false;
    }
}