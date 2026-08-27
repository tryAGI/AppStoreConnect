
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionPackages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionAlternativeDistributionPackageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType value)
        {
            return value switch
            {
                AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType.AlternativeDistributionPackages => "alternativeDistributionPackages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackages" => AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType.AlternativeDistributionPackages,
                _ => null,
            };
        }
    }
}