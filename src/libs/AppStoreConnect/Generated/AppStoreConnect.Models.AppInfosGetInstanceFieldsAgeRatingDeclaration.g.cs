
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosGetInstanceFieldsAgeRatingDeclaration
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
    public static class AppInfosGetInstanceFieldsAgeRatingDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosGetInstanceFieldsAgeRatingDeclaration value)
        {
            return value switch
            {
                AppInfosGetInstanceFieldsAgeRatingDeclaration.Advertising => "advertising",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.AgeAssurance => "ageAssurance",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.AgeRatingOverride => "ageRatingOverride",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.AgeRatingOverrideV2 => "ageRatingOverrideV2",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.AlcoholTobaccoOrDrugUseOrReferences => "alcoholTobaccoOrDrugUseOrReferences",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.Contests => "contests",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.DeveloperAgeRatingInfoUrl => "developerAgeRatingInfoUrl",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.Gambling => "gambling",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.GamblingSimulated => "gamblingSimulated",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.GunsOrOtherWeapons => "gunsOrOtherWeapons",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.HealthOrWellnessTopics => "healthOrWellnessTopics",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.HorrorOrFearThemes => "horrorOrFearThemes",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.KidsAgeBand => "kidsAgeBand",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.KoreaAgeRatingOverride => "koreaAgeRatingOverride",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.LootBox => "lootBox",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.MatureOrSuggestiveThemes => "matureOrSuggestiveThemes",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.MedicalOrTreatmentInformation => "medicalOrTreatmentInformation",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.MessagingAndChat => "messagingAndChat",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.ParentalControls => "parentalControls",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.ProfanityOrCrudeHumor => "profanityOrCrudeHumor",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.SexualContentGraphicAndNudity => "sexualContentGraphicAndNudity",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.SexualContentOrNudity => "sexualContentOrNudity",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.SocialMedia => "socialMedia",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.SocialMediaAgeRestricted => "socialMediaAgeRestricted",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.UnrestrictedWebAccess => "unrestrictedWebAccess",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.UserGeneratedContent => "userGeneratedContent",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.ViolenceCartoonOrFantasy => "violenceCartoonOrFantasy",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.ViolenceRealistic => "violenceRealistic",
                AppInfosGetInstanceFieldsAgeRatingDeclaration.ViolenceRealisticProlongedGraphicOrSadistic => "violenceRealisticProlongedGraphicOrSadistic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosGetInstanceFieldsAgeRatingDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "advertising" => AppInfosGetInstanceFieldsAgeRatingDeclaration.Advertising,
                "ageAssurance" => AppInfosGetInstanceFieldsAgeRatingDeclaration.AgeAssurance,
                "ageRatingOverride" => AppInfosGetInstanceFieldsAgeRatingDeclaration.AgeRatingOverride,
                "ageRatingOverrideV2" => AppInfosGetInstanceFieldsAgeRatingDeclaration.AgeRatingOverrideV2,
                "alcoholTobaccoOrDrugUseOrReferences" => AppInfosGetInstanceFieldsAgeRatingDeclaration.AlcoholTobaccoOrDrugUseOrReferences,
                "contests" => AppInfosGetInstanceFieldsAgeRatingDeclaration.Contests,
                "developerAgeRatingInfoUrl" => AppInfosGetInstanceFieldsAgeRatingDeclaration.DeveloperAgeRatingInfoUrl,
                "gambling" => AppInfosGetInstanceFieldsAgeRatingDeclaration.Gambling,
                "gamblingSimulated" => AppInfosGetInstanceFieldsAgeRatingDeclaration.GamblingSimulated,
                "gunsOrOtherWeapons" => AppInfosGetInstanceFieldsAgeRatingDeclaration.GunsOrOtherWeapons,
                "healthOrWellnessTopics" => AppInfosGetInstanceFieldsAgeRatingDeclaration.HealthOrWellnessTopics,
                "horrorOrFearThemes" => AppInfosGetInstanceFieldsAgeRatingDeclaration.HorrorOrFearThemes,
                "kidsAgeBand" => AppInfosGetInstanceFieldsAgeRatingDeclaration.KidsAgeBand,
                "koreaAgeRatingOverride" => AppInfosGetInstanceFieldsAgeRatingDeclaration.KoreaAgeRatingOverride,
                "lootBox" => AppInfosGetInstanceFieldsAgeRatingDeclaration.LootBox,
                "matureOrSuggestiveThemes" => AppInfosGetInstanceFieldsAgeRatingDeclaration.MatureOrSuggestiveThemes,
                "medicalOrTreatmentInformation" => AppInfosGetInstanceFieldsAgeRatingDeclaration.MedicalOrTreatmentInformation,
                "messagingAndChat" => AppInfosGetInstanceFieldsAgeRatingDeclaration.MessagingAndChat,
                "parentalControls" => AppInfosGetInstanceFieldsAgeRatingDeclaration.ParentalControls,
                "profanityOrCrudeHumor" => AppInfosGetInstanceFieldsAgeRatingDeclaration.ProfanityOrCrudeHumor,
                "sexualContentGraphicAndNudity" => AppInfosGetInstanceFieldsAgeRatingDeclaration.SexualContentGraphicAndNudity,
                "sexualContentOrNudity" => AppInfosGetInstanceFieldsAgeRatingDeclaration.SexualContentOrNudity,
                "socialMedia" => AppInfosGetInstanceFieldsAgeRatingDeclaration.SocialMedia,
                "socialMediaAgeRestricted" => AppInfosGetInstanceFieldsAgeRatingDeclaration.SocialMediaAgeRestricted,
                "unrestrictedWebAccess" => AppInfosGetInstanceFieldsAgeRatingDeclaration.UnrestrictedWebAccess,
                "userGeneratedContent" => AppInfosGetInstanceFieldsAgeRatingDeclaration.UserGeneratedContent,
                "violenceCartoonOrFantasy" => AppInfosGetInstanceFieldsAgeRatingDeclaration.ViolenceCartoonOrFantasy,
                "violenceRealistic" => AppInfosGetInstanceFieldsAgeRatingDeclaration.ViolenceRealistic,
                "violenceRealisticProlongedGraphicOrSadistic" => AppInfosGetInstanceFieldsAgeRatingDeclaration.ViolenceRealisticProlongedGraphicOrSadistic,
                _ => null,
            };
        }
    }
}