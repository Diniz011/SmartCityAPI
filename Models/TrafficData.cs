public class TrafficData
{
    public int Id { get; set; }
    public string Location { get; set; } = string.Empty; // Inicializa como string vazia por padrão
    public int VehicleCount { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now; // Ou algum valor padrão
}
