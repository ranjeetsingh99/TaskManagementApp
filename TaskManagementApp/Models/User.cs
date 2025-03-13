using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TaskManagementApp.Models;


public class User : IdentityUser
{
    [Required]
    [StringLength(20)]
    public string FirstName { get; set; } = string.Empty;

    [StringLength(20)]
    public string LastName { get; set; } = string.Empty;

    public DateTime? DateOfBirth { get; set; }

    [Url]
    public string? ProfileImageUrl { get; set; }
    
    public DateTime CreatedAt { get; private set; }  

    public DateTime UpdatedAt{ get; set; }
}
