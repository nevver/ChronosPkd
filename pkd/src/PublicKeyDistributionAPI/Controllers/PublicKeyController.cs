using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublicKeyDistributionAPI.Models;

namespace PublicKeyDistributionAPI.Controllers
{
    [Route("api/[controller]")]
    public class PublicKeyController : Controller
    {
        private readonly IPublicKeyRepository _publicKeyRepository;

        public PublicKeyController(IPublicKeyRepository publicKeyRepository)
        {
            _publicKeyRepository = publicKeyRepository;
        }

        [HttpGet("byUser")]
        public IActionResult GetByUser(string user)
        {
            var item = _publicKeyRepository.Find(user);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] PublicKey pk)
        {
            if (pk == null)
            {
                return BadRequest();
            }

           Boolean response =  _publicKeyRepository.Add(pk);

            if (response == true)
            {
                return new StatusCodeResult(200);
            }
            else
            {
                return new StatusCodeResult(400);
            }

        }

    }



}

