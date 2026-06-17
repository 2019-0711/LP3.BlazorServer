namespace LP3.BlazorServer.Shared.Dtos
{
    public class CursoDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int Creditos { get; set; }
        public bool Activo { get; set; }
    }
}