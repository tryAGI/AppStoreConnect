
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion
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
    public static class GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}