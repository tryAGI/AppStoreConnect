
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationCreateRequestDataAttributesType
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
    public static class NominationCreateRequestDataAttributesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationCreateRequestDataAttributesType value)
        {
            return value switch
            {
                NominationCreateRequestDataAttributesType.AppEnhancements => "APP_ENHANCEMENTS",
                NominationCreateRequestDataAttributesType.AppLaunch => "APP_LAUNCH",
                NominationCreateRequestDataAttributesType.NewContent => "NEW_CONTENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationCreateRequestDataAttributesType? ToEnum(string value)
        {
            return value switch
            {
                "APP_ENHANCEMENTS" => NominationCreateRequestDataAttributesType.AppEnhancements,
                "APP_LAUNCH" => NominationCreateRequestDataAttributesType.AppLaunch,
                "NEW_CONTENT" => NominationCreateRequestDataAttributesType.NewContent,
                _ => null,
            };
        }
    }
}