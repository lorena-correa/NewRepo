public class SubastaAscendente : SubastaStrategy
{
    public void RealizarOferta(Subasta subasta, UsuarioDTO usuario, decimal monto)
    {
        if (monto <= subasta.PrecioActual)
        {
            throw new Exception("La oferta debe ser mayor que el precio actual.");
        }

        subasta.PrecioActual = monto;
        subasta.Ganador = usuario;
    }
}