namespace LP3.BlazorServer.Shared.Extensions
{
    using MiProyectoAcademico.Domain.Entities;
    using MiProyectoAcademico.Shared.Dtos;

    public static class EstudiantesExtension
    {
        public static EstudianteDto ToDto(this Estudiante estudiante)
        {
            return new EstudianteDto
            {
                Id = estudiante.Id,
                Nombre = estudiante.Nombre,
                Apellido = estudiante.Apellido,
                Matricula = estudiante.Matricula,
                Email = estudiante.Email,
                FechaIngreso = estudiante.FechaIngreso
            };
        }
    }
}