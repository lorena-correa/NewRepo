public class SubastaDescendente : SubastaStrategy
{
    public void RealizarOferta(Subasta subasta, UsuarioDTO usuario, decimal monto)
    {
        subasta.Ganador = usuario;
        subasta.Activa = false;
    }
}