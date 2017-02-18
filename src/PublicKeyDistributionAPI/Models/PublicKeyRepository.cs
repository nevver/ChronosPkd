using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicKeyDistributionAPI.Models
{
    public class PublicKeyRepository : IPublicKeyRepository
    {
        private readonly PublicKeyContext _context;

        public PublicKeyRepository(PublicKeyContext context)
        {
            _context = context;
            Add(
                new PublicKey {
                user = "alice@dot.net",
                key = "23j4k32m4e4oimd43idm3i"}
                );
        }
        public void Add(PublicKey pk)
        {
            _context.PublicKeys.Add(pk);
            _context.SaveChanges();
        }

        public PublicKey Find(int id)
        {
            return _context.PublicKeys.FirstOrDefault(u => u.id == id);
        }
        public PublicKey Find(string user)
        {
            return _context.PublicKeys.FirstOrDefault(u => u.user == user);
        }

    }
}
