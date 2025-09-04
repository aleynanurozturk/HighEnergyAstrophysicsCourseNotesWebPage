using Microsoft.AspNetCore.Identity;

namespace HighEnergyAstrophysicsCourseNotesWebPage.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
