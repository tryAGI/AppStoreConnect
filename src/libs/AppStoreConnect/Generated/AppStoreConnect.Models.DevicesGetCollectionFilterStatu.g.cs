
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum DevicesGetCollectionFilterStatu
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DevicesGetCollectionFilterStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DevicesGetCollectionFilterStatu value)
        {
            return value switch
            {
                DevicesGetCollectionFilterStatu.Disabled => "DISABLED",
                DevicesGetCollectionFilterStatu.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DevicesGetCollectionFilterStatu? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => DevicesGetCollectionFilterStatu.Disabled,
                "ENABLED" => DevicesGetCollectionFilterStatu.Enabled,
                _ => null,
            };
        }
    }
}