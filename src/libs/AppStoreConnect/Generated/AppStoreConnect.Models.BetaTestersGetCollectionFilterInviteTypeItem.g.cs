
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTestersGetCollectionFilterInviteTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        PublicLink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTestersGetCollectionFilterInviteTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetCollectionFilterInviteTypeItem value)
        {
            return value switch
            {
                BetaTestersGetCollectionFilterInviteTypeItem.Email => "EMAIL",
                BetaTestersGetCollectionFilterInviteTypeItem.PublicLink => "PUBLIC_LINK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetCollectionFilterInviteTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "EMAIL" => BetaTestersGetCollectionFilterInviteTypeItem.Email,
                "PUBLIC_LINK" => BetaTestersGetCollectionFilterInviteTypeItem.PublicLink,
                _ => null,
            };
        }
    }
}