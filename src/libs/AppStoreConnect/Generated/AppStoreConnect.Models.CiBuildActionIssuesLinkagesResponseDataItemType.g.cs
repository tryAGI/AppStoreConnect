
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildActionIssuesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        CiIssues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionIssuesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionIssuesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiBuildActionIssuesLinkagesResponseDataItemType.CiIssues => "ciIssues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionIssuesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciIssues" => CiBuildActionIssuesLinkagesResponseDataItemType.CiIssues,
                _ => null,
            };
        }
    }
}