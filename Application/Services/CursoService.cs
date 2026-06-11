using LP3.BlazorServer.Data.Repositories;
using LP3.BlazorServer.Shared.Dtos;
using LP3.BlazorServer.Shared.Extensions;


public class CursoService(ICursoRepository cursoRepository) : ICursoService
{
    public async Task<ICollection<CursoDto>> GetAll()
    {
        var cursos = await cursoRepository.ListAsync();
        return cursos.Select(c => c.ToDto()).ToList();
    }

    public async Task<CursoDto?> GetByIdAsync(int id)
    {
        var curso = await cursoRepository.GetByIdAsync(id);
        return curso?.ToDto();
    }

    public async Task<CursoDto?> GetByCodigoAsync(string codigo)
    {
        var curso = await cursoRepository.GetByCodigoAsync(codigo);
        return curso?.ToDto();
    }

    public async Task<bool> CreateAsync(CursoFormDto dto)
    {
        try
        {
            var curso = dto.ToEntity();
            await cursoRepository.AddAsync(curso);
            return true;
        }
        catch
        {
            return false;
        }
    }



    public async Task<bool> UpdateAsync(int id, CursoFormDto dto)
    {
        try
        {
            var curso = await cursoRepository.GetByIdAsync(id);
            if (curso == null) return false;

            curso.Codigo   = dto.Codigo;
            curso.Nombre   = dto.Nombre;
            curso.Creditos = dto.Creditos;
            curso.Activo   = dto.Activo;

            await cursoRepository.Update(curso);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(int id)
    {
        try
        {
            var curso = await cursoRepository.GetByIdAsync(id);
            if (curso == null) return false;

            await cursoRepository.Remove(curso);
            return true;
        }
        catch
        {
            return false;
        }
    }
}