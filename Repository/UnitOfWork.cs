using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ExampleDbContext _context;
        private IRepository<Table1> _table1s;
        private IRepository<Table2> _table2s;

        public UnitOfWork(ExampleDbContext context)
        {
            this._context = context;
        }

        public IRepository<Table1> Table1s
        {
            get
            {
                return _table1s == null ?
                    _table1s = new Repository<Table1>(_context) :
                    _table1s;
            }
        }

        public IRepository<Table2> Table2s
        {
            get
            {
                return _table2s == null ?
                    _table2s = new Repository<Table2>(_context) :
                    _table2s;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
