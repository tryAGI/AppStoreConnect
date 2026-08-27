
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunActionsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        CiBuildActions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunActionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunActionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiBuildRunActionsLinkagesResponseDataItemType.CiBuildActions => "ciBuildActions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunActionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciBuildActions" => CiBuildRunActionsLinkagesResponseDataItemType.CiBuildActions,
                _ => null,
            };
        }
    }
}