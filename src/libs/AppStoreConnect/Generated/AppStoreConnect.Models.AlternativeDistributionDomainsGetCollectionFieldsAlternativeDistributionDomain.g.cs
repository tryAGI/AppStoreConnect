
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomain
    {
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        Domain,
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomain value)
        {
            return value switch
            {
                AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomain.CreatedDate => "createdDate",
                AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomain.Domain => "domain",
                AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomain.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomain? ToEnum(string value)
        {
            return value switch
            {
                "createdDate" => AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomain.CreatedDate,
                "domain" => AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomain.Domain,
                "referenceName" => AlternativeDistributionDomainsGetCollectionFieldsAlternativeDistributionDomain.ReferenceName,
                _ => null,
            };
        }
    }
}