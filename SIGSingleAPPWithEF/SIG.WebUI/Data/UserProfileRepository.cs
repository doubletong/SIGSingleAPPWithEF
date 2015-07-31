using SIG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data
{
    public class UserProfileRepository : EfRepository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(DbContext context, bool sharedContext) : base(context, sharedContext) { }
    }
}
