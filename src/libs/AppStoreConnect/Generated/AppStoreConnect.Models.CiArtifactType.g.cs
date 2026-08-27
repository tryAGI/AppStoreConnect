
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiArtifactType
    {
        /// <summary>
        ///
        /// </summary>
        CiArtifacts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiArtifactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiArtifactType value)
        {
            return value switch
            {
                CiArtifactType.CiArtifacts => "ciArtifacts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiArtifactType? ToEnum(string value)
        {
            return value switch
            {
                "ciArtifacts" => CiArtifactType.CiArtifacts,
                _ => null,
            };
        }
    }
}