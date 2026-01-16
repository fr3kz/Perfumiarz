using Microsoft.AspNetCore.Identity;

namespace PerfumeService.Models;

public class UserModel : IdentityUser
{
    public bool IsPremium { get; set; }
}