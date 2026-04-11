using appSubastaTrabajo.Modelos;

public class SubastaCerrada : SubastaStrategy
{
    public override void RealizarOferta(Subasta subasta, UsuarioDTO usuario, decimal monto)
    {
        if (!subasta.Activa)
            throw new Exception("La subasta está cerrada");

        if (subasta.Ofertas.Any(o => o.Usuario.IdUsuario == usuario.IdUsuario))
            throw new Exception("Ya ofertaste");

        subasta.Ofertas.Add(new Oferta
        {
            Usuario = usuario,
            Monto = monto
        });
    }
}