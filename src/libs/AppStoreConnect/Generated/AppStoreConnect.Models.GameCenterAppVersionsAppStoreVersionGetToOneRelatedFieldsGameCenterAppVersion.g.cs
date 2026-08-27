
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion
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
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}