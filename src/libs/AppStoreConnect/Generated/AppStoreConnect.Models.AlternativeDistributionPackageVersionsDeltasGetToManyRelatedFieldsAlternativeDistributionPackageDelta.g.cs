
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionKeyBlob,
        /// <summary>
        /// 
        /// </summary>
        FileChecksum,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        UrlExpirationDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDeltaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta.AlternativeDistributionKeyBlob => "alternativeDistributionKeyBlob",
                AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta.FileChecksum => "fileChecksum",
                AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta.Url => "url",
                AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta.UrlExpirationDate => "urlExpirationDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeyBlob" => AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta.AlternativeDistributionKeyBlob,
                "fileChecksum" => AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta.FileChecksum,
                "url" => AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta.Url,
                "urlExpirationDate" => AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta.UrlExpirationDate,
                _ => null,
            };
        }
    }
}