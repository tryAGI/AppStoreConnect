
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfileAttributesProfileState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Invalid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileAttributesProfileStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileAttributesProfileState value)
        {
            return value switch
            {
                ProfileAttributesProfileState.Active => "ACTIVE",
                ProfileAttributesProfileState.Invalid => "INVALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileAttributesProfileState? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ProfileAttributesProfileState.Active,
                "INVALID" => ProfileAttributesProfileState.Invalid,
                _ => null,
            };
        }
    }
}