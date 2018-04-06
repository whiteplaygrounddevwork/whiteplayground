using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using wpg.Core.DTO;
using wpg.Core.Interfaces;

namespace wpg.Controllers
{
    [Route("api/[controller]")]

    public class TestController : Controller
    {
        public ITest _ITest;
        public TestController(ITest _ITest)
        {
            this._ITest = _ITest;
        }

        [Route("Index")]
      //  [Authorize("Bearer")]
        public string Index()
        {

            customerDTO cust = new customerDTO();
            cust.Id = 4;
            cust.Name = "NewTest1";

            _ITest.savetestAble(cust);
            return "Done";
        }
    }
}