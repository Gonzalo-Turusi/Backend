﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity? Get(int id);
        TEntity? Add(TEntity data);
        TEntity? Delete(int id);
        TEntity? Update(int id, TEntity data);
        void Save();
    }
}
