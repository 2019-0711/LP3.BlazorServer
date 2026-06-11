using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.Dtos;

namespace LP3.BlazorServer.Shared.Extensions;

/// <summary>
/// Métodos de conversión entre Entidad y DTO.
/// </summary>
public static class CursoExtensions
{
    public static CursoDto ToDto(this Curso c)
    {
        return new()
        {
            Id = c.Id,
            Codigo = c.Codigo,
            Nombre = c.Nombre,
            Creditos = c.Creditos,
            Activo = c.Activo
        };
    }

    public static Curso ToEntity(this CursoFormDto dto)
        => new()
        {
            Codigo   = dto.Codigo,
            Nombre   = dto.Nombre,
            Creditos = dto.Creditos,
            Activo   = dto.Activo
        };
}