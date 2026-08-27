
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta
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
    public static class AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDeltaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta value)
        {
            return value switch
            {
                AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta.AlternativeDistributionKeyBlob => "alternativeDistributionKeyBlob",
                AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta.FileChecksum => "fileChecksum",
                AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta.Url => "url",
                AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta.UrlExpirationDate => "urlExpirationDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeyBlob" => AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta.AlternativeDistributionKeyBlob,
                "fileChecksum" => AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta.FileChecksum,
                "url" => AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta.Url,
                "urlExpirationDate" => AlternativeDistributionPackageDeltasGetInstanceFieldsAlternativeDistributionPackageDelta.UrlExpirationDate,
                _ => null,
            };
        }
    }
}