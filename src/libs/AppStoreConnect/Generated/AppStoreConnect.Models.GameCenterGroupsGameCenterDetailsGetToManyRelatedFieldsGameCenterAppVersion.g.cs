
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
        /// <summary>
        /// 
        /// </summary>
        CompatibilityVersions,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}