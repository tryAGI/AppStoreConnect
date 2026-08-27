
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAvailabilityV2CreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAvailabilityV2CreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilityV2CreateRequestDataType value)
        {
            return value switch
            {
                AppAvailabilityV2CreateRequestDataType.AppAvailabilities => "appAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilityV2CreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAvailabilities" => AppAvailabilityV2CreateRequestDataType.AppAvailabilities,
                _ => null,
            };
        }
    }
}