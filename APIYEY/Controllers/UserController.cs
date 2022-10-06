using Microsoft.AspNetCore.Mvc;
using DI_Commun.Model;
using DI_Services;
using Buisness;

namespace APIYEY.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : Controller
    {

        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<User> GetAll()
        {
            return this._service.GetAll();
        }

        [HttpGet("{Id}")]
        public User GetById(int Id)
        {
            return this._service.GetById(Id);
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteById(int Id)
        {
            return this._service.Delete(this._service.GetById(Id)) ? Ok() : BadRequest();
        }

        [HttpPut]
        public IActionResult PutById([FromBody] User user)
        {
            return this._service.Update(user) ? Ok() : BadRequest();
        }

        [HttpPost]
        public User PostById([FromBody] User user)
        {
            return this._service.Add(user);
        }

        [HttpPatch]
        public IActionResult PatchById([FromBody] User user)
        {
            return this._service.Update(user) ? Ok() : BadRequest();
        }

        [HttpPost("{userId}/roles/{roleId}")]
        public IActionResult AddRoleToUser(int userId, int roleId)
        {
            return this._service.AddRole(userId, roleId) ? Ok() : BadRequest();
        }
    }
}
