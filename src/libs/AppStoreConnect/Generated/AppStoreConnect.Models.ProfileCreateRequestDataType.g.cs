
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfileCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        Profiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileCreateRequestDataType value)
        {
            return value switch
            {
                ProfileCreateRequestDataType.Profiles => "profiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "profiles" => ProfileCreateRequestDataType.Profiles,
                _ => null,
            };
        }
    }
}