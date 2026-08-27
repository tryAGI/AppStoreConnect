
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetCollectionFieldsBuildBetaDetail
    {
        /// <summary>
        ///
        /// </summary>
        AutoNotifyEnabled,
        /// <summary>
        ///
        /// </summary>
        Build,
        /// <summary>
        ///
        /// </summary>
        ExternalBuildState,
        /// <summary>
        ///
        /// </summary>
        InternalBuildState,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsGetCollectionFieldsBuildBetaDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsBuildBetaDetail value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsBuildBetaDetail.AutoNotifyEnabled => "autoNotifyEnabled",
                BuildsGetCollectionFieldsBuildBetaDetail.Build => "build",
                BuildsGetCollectionFieldsBuildBetaDetail.ExternalBuildState => "externalBuildState",
                BuildsGetCollectionFieldsBuildBetaDetail.InternalBuildState => "internalBuildState",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsBuildBetaDetail? ToEnum(string value)
        {
            return value switch
            {
                "autoNotifyEnabled" => BuildsGetCollectionFieldsBuildBetaDetail.AutoNotifyEnabled,
                "build" => BuildsGetCollectionFieldsBuildBetaDetail.Build,
                "externalBuildState" => BuildsGetCollectionFieldsBuildBetaDetail.ExternalBuildState,
                "internalBuildState" => BuildsGetCollectionFieldsBuildBetaDetail.InternalBuildState,
                _ => null,
            };
        }
    }
}