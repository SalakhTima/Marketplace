﻿using DAL.Entities.Contexts;
using DAL.Entities.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> 
    where TEntity : class
{
    private readonly MarketplaceDbContext _context;

    public BaseRepository(MarketplaceDbContext context)
    {
        _context = context; 
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        _context.Set<TEntity>().Remove(entity!);
        await _context.SaveChangesAsync();
    }

    //public virtual async Task<IEnumerable<TEntity>> GetAllAsync(
    //    Expression<Func<TEntity, bool>>? filter = null,
    //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
    //    string includeProperties = "")
    //{
    //    IQueryable<TEntity> query = _context
    //        .Set<TEntity>()
    //        .AsNoTracking();

    //    if (filter != null)
    //    {
    //        query.Where(filter);
    //    }

    //    if (!string.IsNullOrEmpty(includeProperties))
    //    {
    //        foreach (var includeProperty in includeProperties.Split(','))
    //        {
    //            query = query.Include(includeProperty);
    //        }
    //    }

    //    return orderBy == null ? 
    //        await query.ToListAsync() : 
    //        orderBy(query);
    //}        

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>()
            .AsNoTracking()
            .ToListAsync();
    }

    public virtual async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _context.Set<TEntity>()
            .FindAsync(id);
    }

    public virtual async Task UpdateAsync(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
    }
}
