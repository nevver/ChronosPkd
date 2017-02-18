using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicKeyDistributionAPI.Models
{
    public interface IPublicKeyRepository
    {
        void Add(PublicKey pk);
        PublicKey Find(int id);
        PublicKey Find(string user);
    }
}
