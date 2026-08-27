
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceAttributesPlaceRelationship
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
    public static class AppClipAdvancedExperienceAttributesPlaceRelationshipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceAttributesPlaceRelationship value)
        {
            return value switch
            {
                AppClipAdvancedExperienceAttributesPlaceRelationship.Authorized => "AUTHORIZED",
                AppClipAdvancedExperienceAttributesPlaceRelationship.Other => "OTHER",
                AppClipAdvancedExperienceAttributesPlaceRelationship.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceAttributesPlaceRelationship? ToEnum(string value)
        {
            return value switch
            {
                "AUTHORIZED" => AppClipAdvancedExperienceAttributesPlaceRelationship.Authorized,
                "OTHER" => AppClipAdvancedExperienceAttributesPlaceRelationship.Other,
                "OWNER" => AppClipAdvancedExperienceAttributesPlaceRelationship.Owner,
                _ => null,
            };
        }
    }
}