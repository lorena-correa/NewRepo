using System.Text.Json;

public class SubastaServicio
{
    private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Subastas.json");

    public List<SubastaDTO> ObtenerSubastas()
    {
        if (!File.Exists(ruta)) return new List<SubastaDTO>();

        string json = File.ReadAllText(ruta);

        return JsonSerializer.Deserialize<List<SubastaDTO>>(json) ?? new List<SubastaDTO>();
    }

    public void GuardarSubasta(SubastaDTO subasta)
    {
        var subastas = ObtenerSubastas();
        subastas.Add(subasta);
        string json = JsonSerializer.Serialize(subastas, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(ruta, json);
    }
}