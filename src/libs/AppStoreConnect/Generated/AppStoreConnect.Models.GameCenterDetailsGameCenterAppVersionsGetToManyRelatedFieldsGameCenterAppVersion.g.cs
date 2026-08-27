
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion
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
    public static class GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}