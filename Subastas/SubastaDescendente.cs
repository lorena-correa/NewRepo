using appSubastaTrabajo.Modelos;

public class SubastaDescendente : SubastaStrategy
{
    public override void RealizarOferta(Subasta subasta, UsuarioDTO usuario, decimal monto)
    {
        if (monto >= subasta.PrecioActual)
        {
            throw new Exception("La oferta debe ser menor que el precio actual.");
        }

        subasta.PrecioActual = monto;

        subasta.Ofertas.Add(new Oferta
        {
            Usuario = usuario,
            Monto = monto
        });

        subasta.Ganador = usuario;
    }
}