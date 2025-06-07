using Microsoft.EntityFrameworkCore;
using ZawartoscLodowki.Application.Contracts;
using ZawartoscLodowki.Domain;
using ZawartoscLodowki.Persistance.DatabaseContext;

namespace ZawartoscLodowki.Persistance.Repositories;

public class GenericRepository<T>(AppDbContext context) : IGenericRepository<T>
    where T : BaseEntity
{
    protected readonly AppDbContext Context = context;

    public async Task<List<T>> GetAllAsync()
    {
        return await Context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await Context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e=> e.Id == id);
    }

    public async Task<int> CreateAsync(T entity)
    {
        await Context.AddAsync(entity);
        await Context.SaveChangesAsync();
        return entity.Id;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        try
        {
            context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }
    }

    public async Task<bool> DeleteAsync(T entity)
    {
        try
        {
            Context.Remove(entity);
            await Context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }
    }
}