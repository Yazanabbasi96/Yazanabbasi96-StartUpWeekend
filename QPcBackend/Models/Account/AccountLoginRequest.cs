using System.ComponentModel.DataAnnotations;

namespace QPcBackend.Models.Accounts
{
    public class AccountLoginRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
 