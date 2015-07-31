using SIG.Models;
using SIG.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIG.Services
{
    public interface IUserProfileService
    {
        UserProfile GetBy(int id);
        void Update(EditProfileViewModel model);
    }
}