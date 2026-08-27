
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship
    {
        /// <summary>
        ///
        /// </summary>
        Authorized,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationshipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship value)
        {
            return value switch
            {
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship.Authorized => "AUTHORIZED",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship.Other => "OTHER",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship? ToEnum(string value)
        {
            return value switch
            {
                "AUTHORIZED" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship.Authorized,
                "OTHER" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship.Other,
                "OWNER" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship.Owner,
                _ => null,
            };
        }
    }
}