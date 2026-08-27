
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType
    {
        /// <summary>
        /// 
        /// </summary>
        Fax,
        /// <summary>
        /// 
        /// </summary>
        Landline,
        /// <summary>
        /// 
        /// </summary>
        Mobile,
        /// <summary>
        /// 
        /// </summary>
        Tollfree,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType.Fax => "FAX",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType.Landline => "LANDLINE",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType.Mobile => "MOBILE",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType.Tollfree => "TOLLFREE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType? ToEnum(string value)
        {
            return value switch
            {
                "FAX" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType.Fax,
                "LANDLINE" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType.Landline,
                "MOBILE" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType.Mobile,
                "TOLLFREE" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType.Tollfree,
                _ => null,
            };
        }
    }
}