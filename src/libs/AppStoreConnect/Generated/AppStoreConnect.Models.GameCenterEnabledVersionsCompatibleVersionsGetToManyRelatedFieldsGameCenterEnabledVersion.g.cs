
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        CompatibleVersions,
        /// <summary>
        /// 
        /// </summary>
        IconAsset,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        VersionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion value)
        {
            return value switch
            {
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.App => "app",
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.CompatibleVersions => "compatibleVersions",
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.IconAsset => "iconAsset",
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.Platform => "platform",
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.App,
                "compatibleVersions" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.CompatibleVersions,
                "iconAsset" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.IconAsset,
                "platform" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.Platform,
                "versionString" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.VersionString,
                _ => null,
            };
        }
    }
}