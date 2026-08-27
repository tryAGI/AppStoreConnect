
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionRelationshipsAlternativeDistributionPackageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionPackages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsAlternativeDistributionPackageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsAlternativeDistributionPackageDataType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsAlternativeDistributionPackageDataType.AlternativeDistributionPackages => "alternativeDistributionPackages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsAlternativeDistributionPackageDataType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackages" => AppStoreVersionRelationshipsAlternativeDistributionPackageDataType.AlternativeDistributionPackages,
                _ => null,
            };
        }
    }
}