
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetRelationshipsAppStoreVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetRelationshipsAppStoreVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetRelationshipsAppStoreVersionDataType value)
        {
            return value switch
            {
                BackgroundAssetRelationshipsAppStoreVersionDataType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetRelationshipsAppStoreVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersions" => BackgroundAssetRelationshipsAppStoreVersionDataType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}