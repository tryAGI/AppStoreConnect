
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationUpdateRequestDataAttributesType
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
    public static class NominationUpdateRequestDataAttributesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationUpdateRequestDataAttributesType value)
        {
            return value switch
            {
                NominationUpdateRequestDataAttributesType.AppEnhancements => "APP_ENHANCEMENTS",
                NominationUpdateRequestDataAttributesType.AppLaunch => "APP_LAUNCH",
                NominationUpdateRequestDataAttributesType.NewContent => "NEW_CONTENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationUpdateRequestDataAttributesType? ToEnum(string value)
        {
            return value switch
            {
                "APP_ENHANCEMENTS" => NominationUpdateRequestDataAttributesType.AppEnhancements,
                "APP_LAUNCH" => NominationUpdateRequestDataAttributesType.AppLaunch,
                "NEW_CONTENT" => NominationUpdateRequestDataAttributesType.NewContent,
                _ => null,
            };
        }
    }
}