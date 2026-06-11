using Microsoft.EntityFrameworkCore;
using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Data.Repositories;

#pragma warning disable CS9107 // Parameter is captured into the state of the enclosing type and its value is also passed to the base constructor. The value might be captured by the base class as well.
public class CursoRepository(ApplicationDbContext context) : Repository<Curso>(context), ICursoRepository
#pragma warning restore CS9107 // Parameter is captured into the state of the enclosing type and its value is also passed to the base constructor. The value might be captured by the base class as well.
{
	public async Task<Curso?> GetByCodigoAsync(string codigo)
	{
		return await context.Cursos
			.AsNoTracking()
			.FirstOrDefaultAsync(e => e.Codigo == codigo);
	}
}
