using System;
using Microsoft.AspNetCore.Mvc;
using UsersCase.Data.Dtos;

namespace UsersCase.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
