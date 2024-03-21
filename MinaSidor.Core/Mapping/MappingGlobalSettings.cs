

using Mapster;

namespace MinaSidor.Core.Mapping;

public static class MappingGlobalSettings
{
    public static void Apply()
    {

        TypeAdapterConfig.GlobalSettings.Default
            .AddDestinationTransform((string? dest) => string.IsNullOrWhiteSpace(dest) ? null : dest);
    }
}
