
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppBetaTestersLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppBetaTestersLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppBetaTestersLinkagesRequestDataItemType value)
        {
            return value switch
            {
                AppBetaTestersLinkagesRequestDataItemType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppBetaTestersLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => AppBetaTestersLinkagesRequestDataItemType.BetaTesters,
                _ => null,
            };
        }
    }
}