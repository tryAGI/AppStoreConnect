
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PassTypeIdsCertificatesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        PassTypeId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassTypeIdsCertificatesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsCertificatesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                PassTypeIdsCertificatesGetToManyRelatedIncludeItem.PassTypeId => "passTypeId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsCertificatesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "passTypeId" => PassTypeIdsCertificatesGetToManyRelatedIncludeItem.PassTypeId,
                _ => null,
            };
        }
    }
}