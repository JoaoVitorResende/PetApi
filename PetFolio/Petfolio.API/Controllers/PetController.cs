using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCase.Pet.Register;
using Petfolio.Application.UseCase.Pet.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;
namespace Petfolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var response = new RegisterPetUseCase().Execute(request);
        return Created(string.Empty, response);
    }
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        var usecase = new UpdatePetUseCase();
        usecase.Execute(id, request);
        return NoContent();
    }
}
