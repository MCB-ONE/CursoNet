using Core.Entities;
using UniversityApiBE.Helpers;
using Microsoft.AspNetCore.Mvc;
using UniversityApiBE.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using BussinesLogic.Data;
using Microsoft.Extensions.Localization;

namespace UniversityApiBE.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        private readonly UniversityDBContext _context;
        private readonly IStringLocalizer<AccountController> _stringLocalizer;

        public AccountController(JwtSettings jwtSettings, UniversityDBContext context, IStringLocalizer<AccountController> stringLocalizer)
        {
            _jwtSettings = jwtSettings;
            _context = context;
            _stringLocalizer = stringLocalizer;
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
        public IActionResult Login(UserLogins userLogins)
        {
            // Intentar generar el token y devolverlo
            try
            {
                var token = new UserTokens();

                // Buscar texto de Bienvenida
                var welcomeMessage = _stringLocalizer["WelcomeMessage"];
                /*
                 * Usando Linq, busque en la lista de usuarios del contexto de la base de datos
                 * Verifique tanto el nombre como la contraseña del usuario
                 * Obtenga la primera coincidencia
                 * */
                var user = _context.Users.FirstOrDefault(u => u.Email == userLogins.Email
                && u.Password == userLogins.Password);

                // Si usuario es valido obtenemos el usuario y generamos el token
                if (user != null)
                {
                    // Genenerar token
                    token = JwtHelpers.GenerateTokenKey(new UserTokens()
                    {
                        UserName = user.Name,
                        EmailId = user.Email,
                        Id = user.Id,
                        Role = user.Rol,
                        GuidId = Guid.NewGuid(),

                    }, _jwtSettings);
                }
                else
                {
                    return BadRequest("Credenciales incorrectas");
                }
                return Ok(new{
                    Token = token,
                    WelcomeMessage = welcomeMessage
                });
            }
            catch(Exception ex)
            {
                throw new Exception("GetToken Error", ex);
            }
        }


        // Ruta test con autenticación
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public IActionResult TestProtectedGetUserList()
        {
            return Ok(Logins);
        }

    }
}
