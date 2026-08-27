
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration
    {
        /// <summary>
        ///
        /// </summary>
        Advertising,
        /// <summary>
        ///
        /// </summary>
        AgeAssurance,
        /// <summary>
        ///
        /// </summary>
        AgeRatingOverride,
        /// <summary>
        ///
        /// </summary>
        AgeRatingOverrideV2,
        /// <summary>
        ///
        /// </summary>
        AlcoholTobaccoOrDrugUseOrReferences,
        /// <summary>
        ///
        /// </summary>
        Contests,
        /// <summary>
        ///
        /// </summary>
        DeveloperAgeRatingInfoUrl,
        /// <summary>
        ///
        /// </summary>
        Gambling,
        /// <summary>
        ///
        /// </summary>
        GamblingSimulated,
        /// <summary>
        ///
        /// </summary>
        GunsOrOtherWeapons,
        /// <summary>
        ///
        /// </summary>
        HealthOrWellnessTopics,
        /// <summary>
        ///
        /// </summary>
        HorrorOrFearThemes,
        /// <summary>
        ///
        /// </summary>
        KidsAgeBand,
        /// <summary>
        ///
        /// </summary>
        KoreaAgeRatingOverride,
        /// <summary>
        ///
        /// </summary>
        LootBox,
        /// <summary>
        ///
        /// </summary>
        MatureOrSuggestiveThemes,
        /// <summary>
        ///
        /// </summary>
        MedicalOrTreatmentInformation,
        /// <summary>
        ///
        /// </summary>
        MessagingAndChat,
        /// <summary>
        ///
        /// </summary>
        ParentalControls,
        /// <summary>
        ///
        /// </summary>
        ProfanityOrCrudeHumor,
        /// <summary>
        ///
        /// </summary>
        SexualContentGraphicAndNudity,
        /// <summary>
        ///
        /// </summary>
        SexualContentOrNudity,
        /// <summary>
        ///
        /// </summary>
        SocialMedia,
        /// <summary>
        ///
        /// </summary>
        SocialMediaAgeRestricted,
        /// <summary>
        ///
        /// </summary>
        UnrestrictedWebAccess,
        /// <summary>
        ///
        /// </summary>
        UserGeneratedContent,
        /// <summary>
        ///
        /// </summary>
        ViolenceCartoonOrFantasy,
        /// <summary>
        ///
        /// </summary>
        ViolenceRealistic,
        /// <summary>
        ///
        /// </summary>
        ViolenceRealisticProlongedGraphicOrSadistic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration value)
        {
            return value switch
            {
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.Advertising => "advertising",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.AgeAssurance => "ageAssurance",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.AgeRatingOverride => "ageRatingOverride",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.AgeRatingOverrideV2 => "ageRatingOverrideV2",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.AlcoholTobaccoOrDrugUseOrReferences => "alcoholTobaccoOrDrugUseOrReferences",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.Contests => "contests",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.DeveloperAgeRatingInfoUrl => "developerAgeRatingInfoUrl",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.Gambling => "gambling",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.GamblingSimulated => "gamblingSimulated",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.GunsOrOtherWeapons => "gunsOrOtherWeapons",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.HealthOrWellnessTopics => "healthOrWellnessTopics",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.HorrorOrFearThemes => "horrorOrFearThemes",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.KidsAgeBand => "kidsAgeBand",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.KoreaAgeRatingOverride => "koreaAgeRatingOverride",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.LootBox => "lootBox",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.MatureOrSuggestiveThemes => "matureOrSuggestiveThemes",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.MedicalOrTreatmentInformation => "medicalOrTreatmentInformation",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.MessagingAndChat => "messagingAndChat",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ParentalControls => "parentalControls",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ProfanityOrCrudeHumor => "profanityOrCrudeHumor",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.SexualContentGraphicAndNudity => "sexualContentGraphicAndNudity",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.SexualContentOrNudity => "sexualContentOrNudity",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.SocialMedia => "socialMedia",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.SocialMediaAgeRestricted => "socialMediaAgeRestricted",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.UnrestrictedWebAccess => "unrestrictedWebAccess",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.UserGeneratedContent => "userGeneratedContent",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ViolenceCartoonOrFantasy => "violenceCartoonOrFantasy",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ViolenceRealistic => "violenceRealistic",
                AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ViolenceRealisticProlongedGraphicOrSadistic => "violenceRealisticProlongedGraphicOrSadistic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "advertising" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.Advertising,
                "ageAssurance" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.AgeAssurance,
                "ageRatingOverride" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.AgeRatingOverride,
                "ageRatingOverrideV2" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.AgeRatingOverrideV2,
                "alcoholTobaccoOrDrugUseOrReferences" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.AlcoholTobaccoOrDrugUseOrReferences,
                "contests" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.Contests,
                "developerAgeRatingInfoUrl" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.DeveloperAgeRatingInfoUrl,
                "gambling" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.Gambling,
                "gamblingSimulated" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.GamblingSimulated,
                "gunsOrOtherWeapons" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.GunsOrOtherWeapons,
                "healthOrWellnessTopics" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.HealthOrWellnessTopics,
                "horrorOrFearThemes" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.HorrorOrFearThemes,
                "kidsAgeBand" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.KidsAgeBand,
                "koreaAgeRatingOverride" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.KoreaAgeRatingOverride,
                "lootBox" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.LootBox,
                "matureOrSuggestiveThemes" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.MatureOrSuggestiveThemes,
                "medicalOrTreatmentInformation" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.MedicalOrTreatmentInformation,
                "messagingAndChat" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.MessagingAndChat,
                "parentalControls" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ParentalControls,
                "profanityOrCrudeHumor" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ProfanityOrCrudeHumor,
                "sexualContentGraphicAndNudity" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.SexualContentGraphicAndNudity,
                "sexualContentOrNudity" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.SexualContentOrNudity,
                "socialMedia" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.SocialMedia,
                "socialMediaAgeRestricted" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.SocialMediaAgeRestricted,
                "unrestrictedWebAccess" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.UnrestrictedWebAccess,
                "userGeneratedContent" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.UserGeneratedContent,
                "violenceCartoonOrFantasy" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ViolenceCartoonOrFantasy,
                "violenceRealistic" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ViolenceRealistic,
                "violenceRealisticProlongedGraphicOrSadistic" => AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration.ViolenceRealisticProlongedGraphicOrSadistic,
                _ => null,
            };
        }
    }
}