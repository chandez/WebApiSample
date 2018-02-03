using System.Collections.Generic;
using HttpRestApi.Core;
using HttpRestApi.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HttpRestApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private IUserRepository _userRepository;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="userRepository">User Repository.</param>
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Get Users.
        /// </summary>
        /// <returns>User object.</returns>
        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var users = _userRepository.Get();
            return users;
        }

        /// <summary>
        /// Get User by id.
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>User object</returns>
        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            var user = _userRepository.Get(id);
            return user;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST: api/Users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
