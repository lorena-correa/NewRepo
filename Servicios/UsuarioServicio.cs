using System.Text.Json;

public class UsuarioServicio
{
    private string ruta = "Usuarios.json";

    public List<UsuarioDTO> ObtenerUsuarios()
    {
        if (!File.Exists(ruta)) return new List<UsuarioDTO>();

        string json = File.ReadAllText(ruta);
        return JsonSerializer.Deserialize<List<UsuarioDTO>>(json) ?? new List<UsuarioDTO>();


    }

    public void GuardarUsuarios(UsuarioDTO usuario)
    {
        var usuarios = ObtenerUsuarios();

        usuarios.Add(usuario);

        string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions {WriteIndented = true});

        File.WriteAllText(ruta, json);
    }
}