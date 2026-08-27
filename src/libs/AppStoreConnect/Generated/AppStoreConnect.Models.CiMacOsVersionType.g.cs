
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiMacOsVersionType
    {
        /// <summary>
        ///
        /// </summary>
        CiMacOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiMacOsVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionType value)
        {
            return value switch
            {
                CiMacOsVersionType.CiMacOsVersions => "ciMacOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionType? ToEnum(string value)
        {
            return value switch
            {
                "ciMacOsVersions" => CiMacOsVersionType.CiMacOsVersions,
                _ => null,
            };
        }
    }
}