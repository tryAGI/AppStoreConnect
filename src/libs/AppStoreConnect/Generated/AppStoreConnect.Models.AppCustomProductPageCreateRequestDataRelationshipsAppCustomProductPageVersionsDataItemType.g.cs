
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}