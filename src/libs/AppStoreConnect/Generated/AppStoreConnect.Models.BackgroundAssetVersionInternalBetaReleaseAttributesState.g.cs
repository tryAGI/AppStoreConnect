
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionInternalBetaReleaseAttributesState
    {
        /// <summary>
        ///
        /// </summary>
        ReadyForTesting,
        /// <summary>
        ///
        /// </summary>
        Superseded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionInternalBetaReleaseAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionInternalBetaReleaseAttributesState value)
        {
            return value switch
            {
                BackgroundAssetVersionInternalBetaReleaseAttributesState.ReadyForTesting => "READY_FOR_TESTING",
                BackgroundAssetVersionInternalBetaReleaseAttributesState.Superseded => "SUPERSEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionInternalBetaReleaseAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "READY_FOR_TESTING" => BackgroundAssetVersionInternalBetaReleaseAttributesState.ReadyForTesting,
                "SUPERSEDED" => BackgroundAssetVersionInternalBetaReleaseAttributesState.Superseded,
                _ => null,
            };
        }
    }
}