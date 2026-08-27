
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship
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
    public static class AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationshipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship value)
        {
            return value switch
            {
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship.Authorized => "AUTHORIZED",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship.Other => "OTHER",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship? ToEnum(string value)
        {
            return value switch
            {
                "AUTHORIZED" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship.Authorized,
                "OTHER" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship.Other,
                "OWNER" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship.Owner,
                _ => null,
            };
        }
    }
}