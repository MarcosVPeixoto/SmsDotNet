using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entities.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmsDotNet.Data;


namespace SmsDotNet.Controllers
{
        [ApiController]
        [Route("user")]
    public class UserController : ControllerBase
   {
        [HttpGet]
        [Route("")]
        public async Task <ActionResult<List<UserModel>>> Get([FromServices] DataContext context)
        {
            var user = await context.User.ToListAsync();
            return user;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<UserModel>> Post(
            [FromServices] DataContext context,
            [FromBody] UserModel model)
        {
            if (ModelState.IsValid)
            {
                context.User.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
   }
}
