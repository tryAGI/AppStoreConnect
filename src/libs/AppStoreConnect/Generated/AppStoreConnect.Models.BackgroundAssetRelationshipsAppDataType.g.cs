
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetRelationshipsAppDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetRelationshipsAppDataType value)
        {
            return value switch
            {
                BackgroundAssetRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BackgroundAssetRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}