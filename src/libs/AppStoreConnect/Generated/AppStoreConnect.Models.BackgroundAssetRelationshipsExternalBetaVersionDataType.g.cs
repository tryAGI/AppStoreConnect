
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetRelationshipsExternalBetaVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetRelationshipsExternalBetaVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetRelationshipsExternalBetaVersionDataType value)
        {
            return value switch
            {
                BackgroundAssetRelationshipsExternalBetaVersionDataType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetRelationshipsExternalBetaVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersions" => BackgroundAssetRelationshipsExternalBetaVersionDataType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}