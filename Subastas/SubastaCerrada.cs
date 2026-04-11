public class SubastaCerrada : SubastaStrategy
{
    private Dictionary<string, decimal> ofertas = new();

    public void RealizarOferta(Subasta subasta, UsuarioDTO usuario, decimal monto)
    {
        if (ofertas.ContainsKey(usuario.IdUsuario))
            throw new Exception("Ya ofertaste");

        ofertas[usuario.IdUsuario] = monto;
    }

    public void Cerrar(Subasta subasta)
    {
        var mejor = ofertas.OrderByDescending(o => o.Value).FirstOrDefault();

        if (!string.IsNullOrEmpty(mejor.Key))
        {
            subasta.PrecioActual = mejor.Value;
            subasta.Ganador = new UsuarioDTO { IdUsuario = mejor.Key };
        }

        subasta.Activa = false;
    }
}