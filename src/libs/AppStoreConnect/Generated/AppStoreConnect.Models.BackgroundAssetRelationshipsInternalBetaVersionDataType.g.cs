
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetRelationshipsInternalBetaVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetRelationshipsInternalBetaVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetRelationshipsInternalBetaVersionDataType value)
        {
            return value switch
            {
                BackgroundAssetRelationshipsInternalBetaVersionDataType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetRelationshipsInternalBetaVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersions" => BackgroundAssetRelationshipsInternalBetaVersionDataType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}