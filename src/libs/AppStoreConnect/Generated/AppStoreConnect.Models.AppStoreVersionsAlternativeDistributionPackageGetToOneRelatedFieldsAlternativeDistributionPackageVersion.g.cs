
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionPackage,
        /// <summary>
        /// 
        /// </summary>
        Deltas,
        /// <summary>
        /// 
        /// </summary>
        FileChecksum,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        UrlExpirationDate,
        /// <summary>
        /// 
        /// </summary>
        Variants,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion value)
        {
            return value switch
            {
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.Deltas => "deltas",
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.FileChecksum => "fileChecksum",
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.State => "state",
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.Url => "url",
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.UrlExpirationDate => "urlExpirationDate",
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.Variants => "variants",
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.AlternativeDistributionPackage,
                "deltas" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.Deltas,
                "fileChecksum" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.FileChecksum,
                "state" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.State,
                "url" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.Url,
                "urlExpirationDate" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.UrlExpirationDate,
                "variants" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.Variants,
                "version" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion.Version,
                _ => null,
            };
        }
    }
}