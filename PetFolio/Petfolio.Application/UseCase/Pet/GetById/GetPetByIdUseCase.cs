using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCase.Pet.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Pipoca",
            Type = Communication.Enuns.PetType.cat,
            Birthday = DateTime.Now,
        };
    }
}
