﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen.Api.Repository
{
    public interface IRepository<T>
    {
        Task<int> Create(T entity);
        Task<IEnumerable<T>> Read();
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
    }
}
