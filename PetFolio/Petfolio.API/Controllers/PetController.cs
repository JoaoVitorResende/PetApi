using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCase.Pet.GetAll;
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
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var response = new RegisterPetUseCase().Execute(request);
        return Created(string.Empty, response);
    }
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        var usecase = new UpdatePetUseCase();
        usecase.Execute(id, request);
        return NoContent();
    }
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllPetsJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllPetsUseCase();
        var response = useCase.Execute();
        if(response.Pets.Any())
            return Ok(response);
        return NoContent();
    }
}
