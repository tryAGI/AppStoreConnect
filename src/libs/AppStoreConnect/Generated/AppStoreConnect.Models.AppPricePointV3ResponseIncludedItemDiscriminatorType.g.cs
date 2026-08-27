
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPricePointV3ResponseIncludedItemDiscriminatorType
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
    public static class AppPricePointV3ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointV3ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppPricePointV3ResponseIncludedItemDiscriminatorType.Apps => "apps",
                AppPricePointV3ResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointV3ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppPricePointV3ResponseIncludedItemDiscriminatorType.Apps,
                "territories" => AppPricePointV3ResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}