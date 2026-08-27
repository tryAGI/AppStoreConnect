
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPricePointsV3ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPricePointsV3ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointsV3ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppPricePointsV3ResponseIncludedItemDiscriminatorType.Apps => "apps",
                AppPricePointsV3ResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointsV3ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppPricePointsV3ResponseIncludedItemDiscriminatorType.Apps,
                "territories" => AppPricePointsV3ResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}