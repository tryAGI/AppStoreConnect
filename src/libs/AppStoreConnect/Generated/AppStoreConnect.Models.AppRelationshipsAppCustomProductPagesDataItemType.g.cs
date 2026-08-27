
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsAppCustomProductPagesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsAppCustomProductPagesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsAppCustomProductPagesDataItemType value)
        {
            return value switch
            {
                AppRelationshipsAppCustomProductPagesDataItemType.AppCustomProductPages => "appCustomProductPages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsAppCustomProductPagesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPages" => AppRelationshipsAppCustomProductPagesDataItemType.AppCustomProductPages,
                _ => null,
            };
        }
    }
}