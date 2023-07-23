using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Repositories.Abstract
{
	public interface IRepository<TEntity> where TEntity : class
	{
		IQueryable<TEntity> Get();
		TEntity Add(TEntity entity);
		TEntity Update(TEntity entity);
		void Remove(TEntity entity);
	}
}

