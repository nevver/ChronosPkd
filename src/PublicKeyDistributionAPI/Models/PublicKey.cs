using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicKeyDistributionAPI.Models
{
    public class PublicKey
    {
        public int id { get; set; }
        public string user { get; set; }
        public string key { get; set; }
    }
}
