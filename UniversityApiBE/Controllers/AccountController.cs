using Core.Entities;
using UniversityApiBE.Helpers;
using Microsoft.AspNetCore.Mvc;
using UniversityApiBE.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using BussinesLogic.Data;

namespace UniversityApiBE.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        private readonly UniversityDBContext _context;

        public AccountController(JwtSettings jwtSettings, UniversityDBContext context)
        {
            _jwtSettings = jwtSettings;
            _context = context;
        }



        // Usuarios de exemplo
        // TODO: Cambiar por usuarios reales de la bdd
        private IEnumerable<User> Logins = new List<User>()
        {
            new User()
            {
                Id = 1,
                Email = "marting@imagina.com",
                Name = "Admin",
                Password = "Admin"
            },
            new User()
            {
                Id = 12,
                Email = "pepe@imagina.com",
                Name = "User1",
                Password = "pepe"
            }
        };


        // Ruta para hacer login y generar JWT a cliente
        [HttpPost]
        public IActionResult GetToken(UserLogins userLogins)
        {
            // Intentar generar el token y devolverlo
            try
            {
                var token = new UserTokens();
                // TODO Usar Linq y buscar busque en la lista de usuarios del contexto de la base de datos el usuario correcto
                var valid = Logins.Any(user => user.Name.Equals(userLogins.UserName, StringComparison.OrdinalIgnoreCase));
                /*
                 * Usando Linq, busque en la lista de usuarios del contexto de la base de datos
                 * Verifique tanto el nombre como la contraseña del usuario
                 * Obtenga la primera coincidencia
                 * */
                



                // Si usuario es valido obtenemos el usuario y generamos el token
                if (valid)
                {
                    // Obtener usuario
                    var user = Logins.FirstOrDefault(user => user.Name.Equals(userLogins.UserName, StringComparison.OrdinalIgnoreCase));

                    // GE¡enerar token
                    token = JwtHelpers.GenerateTokenKey(new UserTokens()
                    {
                        UserName = user.Name,
                        EmailId = user.Email,
                        Id = user.Id,
                        GuidId = Guid.NewGuid(),

                    }, _jwtSettings);

                }
                else
                {
                    return BadRequest("Credenciales incorrectas");
                }
                return Ok(token);
            }
            catch(Exception ex)
            {
                throw new Exception("GetToken Error", ex);
            }
        }


        // Ruta test con autenticación
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public IActionResult GetUserList()
        {
            return Ok(Logins);
        }

    }
}
