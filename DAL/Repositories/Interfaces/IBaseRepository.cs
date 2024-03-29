﻿using DAL.Entities.Models;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class
{
    //Task<IEnumerable<TEntity>> GetAllAsync(
    //    Expression<Func<TEntity, bool>>? filter,
    //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy,
    //    string includeProperties);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(int id);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(int id);
}
