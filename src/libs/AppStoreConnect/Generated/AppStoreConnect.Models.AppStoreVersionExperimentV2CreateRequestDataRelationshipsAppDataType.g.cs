
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentV2CreateRequestDataRelationshipsAppDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentV2CreateRequestDataRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentV2CreateRequestDataRelationshipsAppDataType value)
        {
            return value switch
            {
                AppStoreVersionExperimentV2CreateRequestDataRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentV2CreateRequestDataRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppStoreVersionExperimentV2CreateRequestDataRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}