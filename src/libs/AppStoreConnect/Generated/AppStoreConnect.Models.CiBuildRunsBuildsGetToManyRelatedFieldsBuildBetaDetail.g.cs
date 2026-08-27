
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail.AutoNotifyEnabled => "autoNotifyEnabled",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail.Build => "build",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail.ExternalBuildState => "externalBuildState",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail.InternalBuildState => "internalBuildState",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail? ToEnum(string value)
        {
            return value switch
            {
                "autoNotifyEnabled" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail.AutoNotifyEnabled,
                "build" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail.Build,
                "externalBuildState" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail.ExternalBuildState,
                "internalBuildState" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail.InternalBuildState,
                _ => null,
            };
        }
    }
}