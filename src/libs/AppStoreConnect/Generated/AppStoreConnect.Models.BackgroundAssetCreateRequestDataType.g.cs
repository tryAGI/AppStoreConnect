
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetCreateRequestDataType value)
        {
            return value switch
            {
                BackgroundAssetCreateRequestDataType.BackgroundAssets => "backgroundAssets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssets" => BackgroundAssetCreateRequestDataType.BackgroundAssets,
                _ => null,
            };
        }
    }
}