
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailsGetInstanceFieldsBuildBetaDetail
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
    public static class BuildBetaDetailsGetInstanceFieldsBuildBetaDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsGetInstanceFieldsBuildBetaDetail value)
        {
            return value switch
            {
                BuildBetaDetailsGetInstanceFieldsBuildBetaDetail.AutoNotifyEnabled => "autoNotifyEnabled",
                BuildBetaDetailsGetInstanceFieldsBuildBetaDetail.Build => "build",
                BuildBetaDetailsGetInstanceFieldsBuildBetaDetail.ExternalBuildState => "externalBuildState",
                BuildBetaDetailsGetInstanceFieldsBuildBetaDetail.InternalBuildState => "internalBuildState",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsGetInstanceFieldsBuildBetaDetail? ToEnum(string value)
        {
            return value switch
            {
                "autoNotifyEnabled" => BuildBetaDetailsGetInstanceFieldsBuildBetaDetail.AutoNotifyEnabled,
                "build" => BuildBetaDetailsGetInstanceFieldsBuildBetaDetail.Build,
                "externalBuildState" => BuildBetaDetailsGetInstanceFieldsBuildBetaDetail.ExternalBuildState,
                "internalBuildState" => BuildBetaDetailsGetInstanceFieldsBuildBetaDetail.InternalBuildState,
                _ => null,
            };
        }
    }
}