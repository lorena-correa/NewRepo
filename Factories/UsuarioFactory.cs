public static class UsuarioFactory
{
    public static Usuario CrearUsuario(string idUsuario, string tipo)
    {
        if (tipo == "Comprador") return new Comprador(idUsuario);

        if(tipo == "Espectador") return new Espectador(idUsuario);

        throw new Exception("Tipo invalido");
    }
}