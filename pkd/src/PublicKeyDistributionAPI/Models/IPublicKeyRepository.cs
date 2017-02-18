using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicKeyDistributionAPI.Models
{
    public interface IPublicKeyRepository
    {
        Boolean Add(PublicKey pk);
        PublicKey Find(string user);
    }
}
