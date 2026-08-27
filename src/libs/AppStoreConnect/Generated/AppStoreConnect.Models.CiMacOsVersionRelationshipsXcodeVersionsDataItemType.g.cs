
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiMacOsVersionRelationshipsXcodeVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        CiXcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiMacOsVersionRelationshipsXcodeVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionRelationshipsXcodeVersionsDataItemType value)
        {
            return value switch
            {
                CiMacOsVersionRelationshipsXcodeVersionsDataItemType.CiXcodeVersions => "ciXcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionRelationshipsXcodeVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciXcodeVersions" => CiMacOsVersionRelationshipsXcodeVersionsDataItemType.CiXcodeVersions,
                _ => null,
            };
        }
    }
}