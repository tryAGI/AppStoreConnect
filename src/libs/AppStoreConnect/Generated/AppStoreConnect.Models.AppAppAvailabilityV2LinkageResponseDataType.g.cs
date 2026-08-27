
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAppAvailabilityV2LinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppAvailabilityV2LinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppAvailabilityV2LinkageResponseDataType value)
        {
            return value switch
            {
                AppAppAvailabilityV2LinkageResponseDataType.AppAvailabilities => "appAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppAvailabilityV2LinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAvailabilities" => AppAppAvailabilityV2LinkageResponseDataType.AppAvailabilities,
                _ => null,
            };
        }
    }
}