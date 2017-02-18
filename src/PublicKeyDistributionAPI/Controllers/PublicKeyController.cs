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

        [HttpGet("byId")]
        public IActionResult GetById(int id)
        {
            var item = _publicKeyRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
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

            _publicKeyRepository.Add(pk);

            return new StatusCodeResult(200);
        }

    }



}

