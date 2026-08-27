
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem.ReadyForTesting => "READY_FOR_TESTING",
                BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem.Superseded => "SUPERSEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem? ToEnum(string value)
        {
            return value switch
            {
                "READY_FOR_TESTING" => BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem.ReadyForTesting,
                "SUPERSEDED" => BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem.Superseded,
                _ => null,
            };
        }
    }
}