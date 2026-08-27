
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildUploadsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildUploadFiles,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BuildUploadsResponseIncludedItemDiscriminatorType.BuildUploadFiles => "buildUploadFiles",
                BuildUploadsResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploadFiles" => BuildUploadsResponseIncludedItemDiscriminatorType.BuildUploadFiles,
                "builds" => BuildUploadsResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}