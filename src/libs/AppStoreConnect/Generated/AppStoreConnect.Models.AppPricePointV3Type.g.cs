
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPricePointV3Type
    {
        /// <summary>
        ///
        /// </summary>
        AppPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPricePointV3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointV3Type value)
        {
            return value switch
            {
                AppPricePointV3Type.AppPricePoints => "appPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointV3Type? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoints" => AppPricePointV3Type.AppPricePoints,
                _ => null,
            };
        }
    }
}