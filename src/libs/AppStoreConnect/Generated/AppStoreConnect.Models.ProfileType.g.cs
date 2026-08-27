
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfileType
    {
        /// <summary>
        ///
        /// </summary>
        Profiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileType value)
        {
            return value switch
            {
                ProfileType.Profiles => "profiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileType? ToEnum(string value)
        {
            return value switch
            {
                "profiles" => ProfileType.Profiles,
                _ => null,
            };
        }
    }
}