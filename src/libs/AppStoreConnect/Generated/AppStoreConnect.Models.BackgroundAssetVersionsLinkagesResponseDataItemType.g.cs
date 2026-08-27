
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BackgroundAssetVersionsLinkagesResponseDataItemType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersions" => BackgroundAssetVersionsLinkagesResponseDataItemType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}