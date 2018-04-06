using System;
using System.Collections.Generic;
using System.Text;
using wpg.Infrastructure.Models;

namespace wpg.Infrastructure.Repository.Implementation
{
    public class TesTable : Repository<Customer>, ITesTable
    {
        private readonly wpg_devContext _IDBContext;

        public TesTable(wpg_devContext context) : base(context)
        {
            _IDBContext = context;
        }


    }
}
