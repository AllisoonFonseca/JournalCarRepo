using JournalCar.API.Domain;
using JournalCar.API.Model.Domain;
using JournalCar.API.Model.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JournalCar.API.CustomActionFilters;

namespace JournalCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserDomain userDomain;
        private readonly ILogger<UserController> logger;

        public UserController(IUserDomain userDomain, ILogger<UserController> logger)
        {
            this.userDomain = userDomain;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await userDomain.GetAll());
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var user = await userDomain.Get(id);

                if (user == null) { return NotFound(); }
                return Ok(user);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequestDTO user)
        {
            try
            {
                var newUser = await userDomain.Create(user);
                return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return StatusCode(500, ex.Message);
            }
            
        }
        
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Deactivate([FromRoute] Guid id)
        {
            try { 
                var isSucceed = await userDomain.Deactivate(id);
                if (!isSucceed) { return NotFound(); }
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return StatusCode(500, ex.Message);
            }
        }
        
        [HttpPut]
        [ValidateModel]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UserUpdateRequestDTO userUpdateRequest)
        {
            try { 
                var updatedUser = await userDomain.Update(id, userUpdateRequest);
                if (updatedUser == null) { return NotFound(); }
                return Ok(updatedUser);
            }
                catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return StatusCode(500, ex.Message);
            }

        }
    }
}
