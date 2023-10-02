using Microsoft.AspNetCore.Identity;

namespace UsersCase.Models
{
    public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public Usuario() : base() { }

    }
}
    