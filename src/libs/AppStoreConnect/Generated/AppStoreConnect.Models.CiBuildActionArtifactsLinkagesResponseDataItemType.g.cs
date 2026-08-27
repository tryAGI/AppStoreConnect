
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionArtifactsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        CiArtifacts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionArtifactsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionArtifactsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiBuildActionArtifactsLinkagesResponseDataItemType.CiArtifacts => "ciArtifacts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionArtifactsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciArtifacts" => CiBuildActionArtifactsLinkagesResponseDataItemType.CiArtifacts,
                _ => null,
            };
        }
    }
}