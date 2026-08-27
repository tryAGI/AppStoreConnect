
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiXcodeVersionType
    {
        /// <summary>
        ///
        /// </summary>
        CiXcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiXcodeVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionType value)
        {
            return value switch
            {
                CiXcodeVersionType.CiXcodeVersions => "ciXcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionType? ToEnum(string value)
        {
            return value switch
            {
                "ciXcodeVersions" => CiXcodeVersionType.CiXcodeVersions,
                _ => null,
            };
        }
    }
}