using Petfolio.Communication.Enuns;

namespace Petfolio.Communication.Responses;
public class ResponseShortPetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType type { get; set; }
}
