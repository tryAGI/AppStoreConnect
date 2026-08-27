
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetUpdateRequestDataType value)
        {
            return value switch
            {
                BackgroundAssetUpdateRequestDataType.BackgroundAssets => "backgroundAssets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssets" => BackgroundAssetUpdateRequestDataType.BackgroundAssets,
                _ => null,
            };
        }
    }
}