using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using UniversityApiBE.Dtos.UserDto;

namespace UniversityApiBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IMapper _mapper;
        public UsersController(IGenericRepository<User> studentRepository, IMapper mapper)
        {
            _userRepository = studentRepository;
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

            var users = await _userRepository.GetAllAsync();

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
            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return _mapper.Map<UserDto>(user);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUser(int id, UserDto user)
        //{
        //    if (id != user.Id)
        //    {
        //        return BadRequest();
        //    }

        //    user.UpdatedAt = DateTime.Now;
        //    user.UpdatedBy = "Admin";



        //    _context.Entry(_mapper.Map<User>(user)).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<UserCreateDto>> PostUser(UserCreateDto userCreateDto)
        //{
        //    var user = _mapper.Map<User>(userCreateDto);

        //    if (_context.Users == null)
        //  {
        //      return Problem("Entity set 'UniversityDBContext.Users'  is null.");
        //  }

        //    _context.Users.Add(user);
        //    await _context.SaveChangesAsync();

        //    //return CreatedAtAction("GetUser", new { id = userCreateDto.Id }, userCreateDto);
        //    return userCreateDto;
        //}

        // DELETE: api/Users/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUser(int id)
        //{
        //    if (_context.Users == null)
        //    {
        //        return NotFound();
        //    }
        //    var user = await _context.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Users.Remove(user);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool UserExists(int id)
        //{
        //    return (_context.Users?.Any(entity => entity.Id == id)).GetValueOrDefault();
        //}
    }
}
