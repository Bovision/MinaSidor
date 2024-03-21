using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MinaSidor.Core.Dtos.Auth;

[ValidateNever] // Remove data annotations validation
public record ChangePasswordDto(string Current, string New);
