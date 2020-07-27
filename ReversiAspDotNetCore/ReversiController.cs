using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReversiAspDotNetCore
{
    public class ReversiController : ControllerBase
    {
        public ActionResult<string> Main(string query)
        {
            return "Hello ASP.NET Core Controller World! :" + query;
        }
    }
}
