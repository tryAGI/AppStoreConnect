
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAvailabilityV2Type
    {
        /// <summary>
        /// 
        /// </summary>
        AppAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAvailabilityV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilityV2Type value)
        {
            return value switch
            {
                AppAvailabilityV2Type.AppAvailabilities => "appAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilityV2Type? ToEnum(string value)
        {
            return value switch
            {
                "appAvailabilities" => AppAvailabilityV2Type.AppAvailabilities,
                _ => null,
            };
        }
    }
}