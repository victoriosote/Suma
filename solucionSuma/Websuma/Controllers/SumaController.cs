using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Websuma.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SumaController : Controller
    {
        [HttpGet]
        public int suma(int a, int b)
        {
            return a + b;
        }
    }
}
