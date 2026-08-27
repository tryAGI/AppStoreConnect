
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration
    {
        /// <summary>
        ///
        /// </summary>
        DeviceFamily,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        SupportsAudioDescriptions,
        /// <summary>
        ///
        /// </summary>
        SupportsCaptions,
        /// <summary>
        ///
        /// </summary>
        SupportsDarkInterface,
        /// <summary>
        ///
        /// </summary>
        SupportsDifferentiateWithoutColorAlone,
        /// <summary>
        ///
        /// </summary>
        SupportsLargerText,
        /// <summary>
        ///
        /// </summary>
        SupportsReducedMotion,
        /// <summary>
        ///
        /// </summary>
        SupportsSufficientContrast,
        /// <summary>
        ///
        /// </summary>
        SupportsVoiceControl,
        /// <summary>
        ///
        /// </summary>
        SupportsVoiceover,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration value)
        {
            return value switch
            {
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.DeviceFamily => "deviceFamily",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.State => "state",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsAudioDescriptions => "supportsAudioDescriptions",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsCaptions => "supportsCaptions",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsDarkInterface => "supportsDarkInterface",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsDifferentiateWithoutColorAlone => "supportsDifferentiateWithoutColorAlone",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsLargerText => "supportsLargerText",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsReducedMotion => "supportsReducedMotion",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsSufficientContrast => "supportsSufficientContrast",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsVoiceControl => "supportsVoiceControl",
                AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsVoiceover => "supportsVoiceover",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "deviceFamily" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.DeviceFamily,
                "state" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.State,
                "supportsAudioDescriptions" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsAudioDescriptions,
                "supportsCaptions" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsCaptions,
                "supportsDarkInterface" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsDarkInterface,
                "supportsDifferentiateWithoutColorAlone" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsDifferentiateWithoutColorAlone,
                "supportsLargerText" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsLargerText,
                "supportsReducedMotion" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsReducedMotion,
                "supportsSufficientContrast" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsSufficientContrast,
                "supportsVoiceControl" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsVoiceControl,
                "supportsVoiceover" => AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration.SupportsVoiceover,
                _ => null,
            };
        }
    }
}