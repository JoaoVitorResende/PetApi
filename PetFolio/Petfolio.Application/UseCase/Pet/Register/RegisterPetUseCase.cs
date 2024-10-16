﻿using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;
namespace Petfolio.Application.UseCase.Pet.Register;
public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisteredPetJson {
            Id = 7,
            Name = request.Name,
        };
    }
}
