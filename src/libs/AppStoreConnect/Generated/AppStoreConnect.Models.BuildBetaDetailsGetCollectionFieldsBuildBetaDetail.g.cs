
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailsGetCollectionFieldsBuildBetaDetail
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
    public static class BuildBetaDetailsGetCollectionFieldsBuildBetaDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsGetCollectionFieldsBuildBetaDetail value)
        {
            return value switch
            {
                BuildBetaDetailsGetCollectionFieldsBuildBetaDetail.AutoNotifyEnabled => "autoNotifyEnabled",
                BuildBetaDetailsGetCollectionFieldsBuildBetaDetail.Build => "build",
                BuildBetaDetailsGetCollectionFieldsBuildBetaDetail.ExternalBuildState => "externalBuildState",
                BuildBetaDetailsGetCollectionFieldsBuildBetaDetail.InternalBuildState => "internalBuildState",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsGetCollectionFieldsBuildBetaDetail? ToEnum(string value)
        {
            return value switch
            {
                "autoNotifyEnabled" => BuildBetaDetailsGetCollectionFieldsBuildBetaDetail.AutoNotifyEnabled,
                "build" => BuildBetaDetailsGetCollectionFieldsBuildBetaDetail.Build,
                "externalBuildState" => BuildBetaDetailsGetCollectionFieldsBuildBetaDetail.ExternalBuildState,
                "internalBuildState" => BuildBetaDetailsGetCollectionFieldsBuildBetaDetail.InternalBuildState,
                _ => null,
            };
        }
    }
}