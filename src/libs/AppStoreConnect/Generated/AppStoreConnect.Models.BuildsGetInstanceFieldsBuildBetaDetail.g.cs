
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetInstanceFieldsBuildBetaDetail
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
    public static class BuildsGetInstanceFieldsBuildBetaDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsBuildBetaDetail value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsBuildBetaDetail.AutoNotifyEnabled => "autoNotifyEnabled",
                BuildsGetInstanceFieldsBuildBetaDetail.Build => "build",
                BuildsGetInstanceFieldsBuildBetaDetail.ExternalBuildState => "externalBuildState",
                BuildsGetInstanceFieldsBuildBetaDetail.InternalBuildState => "internalBuildState",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsBuildBetaDetail? ToEnum(string value)
        {
            return value switch
            {
                "autoNotifyEnabled" => BuildsGetInstanceFieldsBuildBetaDetail.AutoNotifyEnabled,
                "build" => BuildsGetInstanceFieldsBuildBetaDetail.Build,
                "externalBuildState" => BuildsGetInstanceFieldsBuildBetaDetail.ExternalBuildState,
                "internalBuildState" => BuildsGetInstanceFieldsBuildBetaDetail.InternalBuildState,
                _ => null,
            };
        }
    }
}