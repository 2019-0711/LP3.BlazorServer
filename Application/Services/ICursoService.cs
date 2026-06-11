using LP3.BlazorServer.Shared.Dtos;

public interface ICursoService
{
    Task<ICollection<CursoDto>> GetAll();

    Task<CursoDto?> GetByIdAsync(int id);

    Task<CursoDto?> GetByCodigoAsync(string codigo);

    Task<bool> CreateAsync(CursoFormDto dto);

    Task<bool> UpdateAsync(int id, CursoFormDto dto);
    Task<bool> DeleteAsync(int id);
}