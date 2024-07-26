using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Table1> Table1s { get; }
        public IRepository<Table2> Table2s { get; }

        public void Save();
    }
}
