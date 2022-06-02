using dotnet_rpg.Data;
using dotnet_rpg.Dtos.User;
using dotnet_rpg.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;

        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await authRepository.Register(new User { Username = request.Username }, request.Password);

            if(!response.Success)
                return BadRequest(response);

            return Ok(response);
        }


        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<int>>> Login(UserLoginDto request)
        {
            var response = await authRepository.Login(request.Username, request.Password);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }



    }

}
