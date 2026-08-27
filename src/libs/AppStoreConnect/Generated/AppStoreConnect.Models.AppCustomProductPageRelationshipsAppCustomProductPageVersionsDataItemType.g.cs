
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}