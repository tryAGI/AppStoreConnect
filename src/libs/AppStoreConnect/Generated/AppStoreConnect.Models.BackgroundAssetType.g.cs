
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetType value)
        {
            return value switch
            {
                BackgroundAssetType.BackgroundAssets => "backgroundAssets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssets" => BackgroundAssetType.BackgroundAssets,
                _ => null,
            };
        }
    }
}