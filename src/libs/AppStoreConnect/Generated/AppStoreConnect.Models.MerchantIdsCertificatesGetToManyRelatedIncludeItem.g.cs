
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MerchantIdsCertificatesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        PassTypeId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MerchantIdsCertificatesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsCertificatesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                MerchantIdsCertificatesGetToManyRelatedIncludeItem.PassTypeId => "passTypeId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsCertificatesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "passTypeId" => MerchantIdsCertificatesGetToManyRelatedIncludeItem.PassTypeId,
                _ => null,
            };
        }
    }
}