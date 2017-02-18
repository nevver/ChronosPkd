using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PublicKeyDistributionAPI.Models
{
    public class PublicKey
    {
        [Key]
        public string user { get; set; }
        public string key { get; set; }
    }
}
