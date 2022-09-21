using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications.UserSpecifications;
using Microsoft.AspNetCore.Mvc;
using UniversityApiBE.Dtos.Users;
using UniversityApiBE.Error;

namespace UniversityApiBE.Controllers
{
    public class UsersController : BaseApIController
    {
        private readonly IGenericService<User> _userService;
        private readonly IMapper _mapper;
        public UsersController(IGenericService<User> userRepository, IMapper mapper)
        {
            _userService = userRepository;
            _mapper = mapper;
        }

        // GET: api/Users
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UserDto>), 200)]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsersAll()
        {
            var spec = new UserWithStudentSpecification();

            var users = await _userService.GetAllIdWithSpecAsync(spec);
            if (users == null)
            {
                return NotFound(new CodeErrorResponse(404, $"No se han encontrado usuarios."));
            }

            return _mapper.Map<List<UserDto>>(users); 
        }

        //GET: api/Users/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserDto), 200)]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {

            // spec => deve incluir la lógica de la condición de la consulta y las relaciones entre las entidades
            // ejemplo de relación => relación entre user y student
            var spec = new UserWithStudentSpecification(id);

            var user = await _userService.GetByIdWithSpecAsync(spec);

            if (user == null)
            {
                return NotFound(new CodeErrorResponse(404, $"Usuario con id {id} no existe."));
            }

            return _mapper.Map<UserDto>(user);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> PutUser(int id, UserUpdateDto userUpdateDto)
        {
            if (id != userUpdateDto.Id)
            {
                return BadRequest(new CodeErrorResponse(400, $"El id ({id}) de la request y el id ({userUpdateDto.Id}) del usuario a actualizar no coinciden"));
            }

            userUpdateDto.UpdatedAt = DateTime.Now;
            userUpdateDto.UpdatedBy = "Admin";

           var result = await _userService.Update(_mapper.Map<User>(userUpdateDto));
            
            if(result == 0)
            {
                throw new Exception("El usuario no se ha podido actualizar.");
                return BadRequest(new CodeErrorResponse(400, $"El id ({id}) de la request y el id ({userUpdateDto.Id}) del usuario a actualizar no coinciden"));
            }

            var userUpdated = _mapper.Map<UserDto>(userUpdateDto);

            return Ok(userUpdated);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserDto>> PostUser(UserCreateDto userCreateDto)
        {
            var user = _mapper.Map<User>(userCreateDto);

            var result = await _userService.Add(user);

            if (result == 0)
            {
                throw new Exception("Error al crear el usuario");
            }

            var userDto = _mapper.Map<UserDto>(user);


            return CreatedAtAction("GetUser", new { id = userDto.Id }, userDto);

            //return Ok(userCreateDto);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {

            var result = await _userService.Delete(id);

            if (result == 0)
            {
                throw (new Exception($"No se a podido eliminar el usuario con id {id}"));

            }
            return NoContent();
        }
    }
}
