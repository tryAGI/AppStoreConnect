
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPricesV2ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPricePoints,
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPricesV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricesV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppPricesV2ResponseIncludedItemDiscriminatorType.AppPricePoints => "appPricePoints",
                AppPricesV2ResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricesV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoints" => AppPricesV2ResponseIncludedItemDiscriminatorType.AppPricePoints,
                "territories" => AppPricesV2ResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}