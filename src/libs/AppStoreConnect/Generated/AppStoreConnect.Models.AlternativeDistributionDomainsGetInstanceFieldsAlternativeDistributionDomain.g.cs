
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomain
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
    public static class AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomain value)
        {
            return value switch
            {
                AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomain.CreatedDate => "createdDate",
                AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomain.Domain => "domain",
                AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomain.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomain? ToEnum(string value)
        {
            return value switch
            {
                "createdDate" => AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomain.CreatedDate,
                "domain" => AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomain.Domain,
                "referenceName" => AlternativeDistributionDomainsGetInstanceFieldsAlternativeDistributionDomain.ReferenceName,
                _ => null,
            };
        }
    }
}