using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MD5hash.Models;

namespace MD5hash.Controllers
{
    [Produces("application/json")]
    [Route("api/MD5")]
    public class MD5Controller : Controller
    {
        private static Hashes cuHash = new Hashes();

        // GET: api/MD5/5
       [HttpGet]
        public IActionResult Get()
        {
            if(cuHash.Hash == null)
            {
                return BadRequest();
            }
            return Ok(cuHash);
        }

        // POST: api/MD5
        [HttpPost]
        public IActionResult Post([FromBody] Hashes text)
        {
            cuHash.Hash = MD5Hashing.CalculateMD5Hash(text.Hash);
            text = cuHash;
            return Ok(text);
        }

    }
}
