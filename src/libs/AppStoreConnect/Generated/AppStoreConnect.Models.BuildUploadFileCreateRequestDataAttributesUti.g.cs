
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildUploadFileCreateRequestDataAttributesUti
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
    public static class BuildUploadFileCreateRequestDataAttributesUtiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadFileCreateRequestDataAttributesUti value)
        {
            return value switch
            {
                BuildUploadFileCreateRequestDataAttributesUti.ComAppleBinaryPropertyList => "com.apple.binary-property-list",
                BuildUploadFileCreateRequestDataAttributesUti.ComAppleIpa => "com.apple.ipa",
                BuildUploadFileCreateRequestDataAttributesUti.ComApplePkg => "com.apple.pkg",
                BuildUploadFileCreateRequestDataAttributesUti.ComAppleXmlPropertyList => "com.apple.xml-property-list",
                BuildUploadFileCreateRequestDataAttributesUti.ComPkwareZipArchive => "com.pkware.zip-archive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadFileCreateRequestDataAttributesUti? ToEnum(string value)
        {
            return value switch
            {
                "com.apple.binary-property-list" => BuildUploadFileCreateRequestDataAttributesUti.ComAppleBinaryPropertyList,
                "com.apple.ipa" => BuildUploadFileCreateRequestDataAttributesUti.ComAppleIpa,
                "com.apple.pkg" => BuildUploadFileCreateRequestDataAttributesUti.ComApplePkg,
                "com.apple.xml-property-list" => BuildUploadFileCreateRequestDataAttributesUti.ComAppleXmlPropertyList,
                "com.pkware.zip-archive" => BuildUploadFileCreateRequestDataAttributesUti.ComPkwareZipArchive,
                _ => null,
            };
        }
    }
}