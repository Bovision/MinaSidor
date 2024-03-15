using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MinaSidor.Core.Dtos.Users;

[ValidateNever] // Remove data annotations validation
public record ChangeRolesDto(bool? IsAgent = null, bool? IsOfficeAdmin = null, bool? IsAdministrator = null);
