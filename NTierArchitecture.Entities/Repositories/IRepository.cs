﻿using System.Linq.Expressions;

namespace NTierArchitecture.Entities.Repositories
{
	public interface IRepository<T>
	{
		Task AddAsync(T entity, CancellationToken cancellationToken = default);
		void Update(T entity);
		void Remove(T entity);
		Task<T> GetByIdAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);  //p=>p.name == şeklinde yapabilmemize yarar.
		IQueryable<T> GetAll();
		IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
		Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
	}
}
