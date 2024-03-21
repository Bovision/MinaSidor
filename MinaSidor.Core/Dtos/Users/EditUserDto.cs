﻿using MinaSidor.Core.Dtos.Auth;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MinaSidor.Core.Dtos.Users;

[ValidateNever] // Remove data annotations validation
public record EditUserDto(string UserName,
    string Email, string FirstName, string LastName, string? MiddleName = null) :
    RegisterDto(Email, FirstName, LastName, MiddleName);
