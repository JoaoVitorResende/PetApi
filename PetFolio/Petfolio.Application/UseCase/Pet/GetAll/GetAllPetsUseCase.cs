using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCase.Pet.GetAll;
public class GetAllPetsUseCase
{
    public ResponseAllPetsJson Execute()
    {
        return new ResponseAllPetsJson() 
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Test",
                    type = Communication.Enuns.PetType.cat
                }
            }
        };
    }
}
