using System.ComponentModel.DataAnnotations;

namespace _2TDSPM.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Email { get; set; }

    public string PasswordHash { get; set; }
}