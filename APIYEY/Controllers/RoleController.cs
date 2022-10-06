using Buisness;
using DI_Commun.Model;
using DI_Services;
using Microsoft.AspNetCore.Mvc;

namespace APIYEY.Controllers
{
    [ApiController]
    [Route("roles")]
    public class RoleController : Controller
    {
        private readonly IRoleService _service;

        public RoleController(IRoleService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Role> GetAll()
        {
            return this._service.GetAll();
        }

        [HttpGet("{Id}")]
        public Role GetById(int Id)
        {
            return this._service.GetById(Id);
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteById(int Id)
        {
            return this._service.Delete(this._service.GetById(Id)) ? Ok() : BadRequest();
        }

        [HttpPut]
        public IActionResult PutById([FromBody] Role role)
        {
            return this._service.Update(role) ? Ok() : BadRequest();
        }

        [HttpPost]
        public Role PostById([FromBody] Role role)
        {
            return this._service.Add(role);
        }

        [HttpPatch]
        public IActionResult PatchById([FromBody] Role role)
        {
            return this._service.Update(role) ? Ok() : BadRequest();
        }
    }
}
