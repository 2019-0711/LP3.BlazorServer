

namespace LP3.BlazorServer.Shared.Dtos
{
    public class EstudianteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; }
    }
}