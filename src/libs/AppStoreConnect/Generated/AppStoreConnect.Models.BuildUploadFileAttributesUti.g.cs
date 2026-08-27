
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadFileAttributesUti
    {
        /// <summary>
        ///
        /// </summary>
        ComAppleBinaryPropertyList,
        /// <summary>
        ///
        /// </summary>
        ComAppleIpa,
        /// <summary>
        ///
        /// </summary>
        ComApplePkg,
        /// <summary>
        ///
        /// </summary>
        ComAppleXmlPropertyList,
        /// <summary>
        ///
        /// </summary>
        ComPkwareZipArchive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadFileAttributesUtiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadFileAttributesUti value)
        {
            return value switch
            {
                BuildUploadFileAttributesUti.ComAppleBinaryPropertyList => "com.apple.binary-property-list",
                BuildUploadFileAttributesUti.ComAppleIpa => "com.apple.ipa",
                BuildUploadFileAttributesUti.ComApplePkg => "com.apple.pkg",
                BuildUploadFileAttributesUti.ComAppleXmlPropertyList => "com.apple.xml-property-list",
                BuildUploadFileAttributesUti.ComPkwareZipArchive => "com.pkware.zip-archive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadFileAttributesUti? ToEnum(string value)
        {
            return value switch
            {
                "com.apple.binary-property-list" => BuildUploadFileAttributesUti.ComAppleBinaryPropertyList,
                "com.apple.ipa" => BuildUploadFileAttributesUti.ComAppleIpa,
                "com.apple.pkg" => BuildUploadFileAttributesUti.ComApplePkg,
                "com.apple.xml-property-list" => BuildUploadFileAttributesUti.ComAppleXmlPropertyList,
                "com.pkware.zip-archive" => BuildUploadFileAttributesUti.ComPkwareZipArchive,
                _ => null,
            };
        }
    }
}