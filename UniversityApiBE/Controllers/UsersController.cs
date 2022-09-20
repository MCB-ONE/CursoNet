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
        private readonly IGenericService<User> _userRepository;
        private readonly IMapper _mapper;
        public UsersController(IGenericService<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        // GET: api/Users
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UserDto>), 200)]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsersAll()
        {
            //if (_userRepository.Users == null)
            //{
            //    return NotFound();
            //}
            var spec = new UserWithStudentSpecification();

            var users = await _userRepository.GetAllIdWithSpecAsync(spec);

            return _mapper.Map<List<UserDto>>(users); 
        }

        //GET: api/Users/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserDto), 200)]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            //if (_context.Users == null)
            //{
            //    return NotFound();
            //}

            // spec => deve incluir la lógica de la condición de la consulta y las relaciones entre las entidades
            // ejemplo de relación => relación entre user y student
            var spec = new UserWithStudentSpecification(id);

            var user = await _userRepository.GetByIdWithSpecAsync(spec);

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
                return BadRequest("El id de la request y el id del usuario a actualizar no coinciden");
            }

            userUpdateDto.UpdatedAt = DateTime.Now;
            userUpdateDto.UpdatedBy = "Admin";

           var result = await _userRepository.Update(_mapper.Map<User>(userUpdateDto));
            
            if(result == 0)
            {
                throw new Exception("El usuario no se ha podido actualizar.");
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

            var result = await _userRepository.Add(user);

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

            var result = await _userRepository.Delete(id);

            if (result == 0)
            {
                throw (new Exception($"No se a podido eliminar el usuario con id {id}"));

            }
            return NoContent();
        }
    }
}
