
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationAttributesType
    {
        /// <summary>
        ///
        /// </summary>
        AppEnhancements,
        /// <summary>
        ///
        /// </summary>
        AppLaunch,
        /// <summary>
        ///
        /// </summary>
        NewContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationAttributesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationAttributesType value)
        {
            return value switch
            {
                NominationAttributesType.AppEnhancements => "APP_ENHANCEMENTS",
                NominationAttributesType.AppLaunch => "APP_LAUNCH",
                NominationAttributesType.NewContent => "NEW_CONTENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationAttributesType? ToEnum(string value)
        {
            return value switch
            {
                "APP_ENHANCEMENTS" => NominationAttributesType.AppEnhancements,
                "APP_LAUNCH" => NominationAttributesType.AppLaunch,
                "NEW_CONTENT" => NominationAttributesType.NewContent,
                _ => null,
            };
        }
    }
}