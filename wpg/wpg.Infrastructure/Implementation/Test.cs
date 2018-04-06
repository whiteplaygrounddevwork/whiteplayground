using System;
using System.Collections.Generic;
using System.Text;
using wpg.Core.DTO;
using wpg.Core.Interfaces;
using wpg.Infrastructure.Models;
using wpg.Infrastructure.Repository;

namespace wpg.Infrastructure.Implementation
{
    public class Test : ITest
    {
        ITesTable _ITestTable;
        IUnitOfWork _IUnitOfWork;
        public Test(ITesTable _ITestTable, IUnitOfWork _IUnitOfWork)
        {
            this._ITestTable = _ITestTable;
            this._IUnitOfWork = _IUnitOfWork;
        }

        public void savetestAble(customerDTO customer)
        {


            //_ITestTable.Add(cust);
            //_IUnitOfWork.Commit();
        }
    }
}
