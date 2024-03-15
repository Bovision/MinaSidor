using MinaSidor.Core.Dtos.Auth;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MinaSidor.Core.Dtos.Users;

[ValidateNever] // Remove data annotations validations
public record RegisterUsersDto(IEnumerable<RegisterDto> Users);
