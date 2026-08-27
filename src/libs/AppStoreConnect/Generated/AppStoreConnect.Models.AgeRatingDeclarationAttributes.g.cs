
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgeRatingDeclarationAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advertising")]
        public bool? Advertising { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alcoholTobaccoOrDrugUseOrReferences")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferencesJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences? AlcoholTobaccoOrDrugUseOrReferences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesContestsJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesContests? Contests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gambling")]
        public bool? Gambling { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gamblingSimulated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGamblingSimulatedJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated? GamblingSimulated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gunsOrOtherWeapons")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGunsOrOtherWeaponsJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons? GunsOrOtherWeapons { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("healthOrWellnessTopics")]
        public bool? HealthOrWellnessTopics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kidsAgeBand")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.KidsAgeBandJsonConverter))]
        public global::AppStoreConnect.KidsAgeBand? KidsAgeBand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lootBox")]
        public bool? LootBox { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medicalOrTreatmentInformation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMedicalOrTreatmentInformationJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation? MedicalOrTreatmentInformation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messagingAndChat")]
        public bool? MessagingAndChat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentalControls")]
        public bool? ParentalControls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profanityOrCrudeHumor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesProfanityOrCrudeHumorJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor? ProfanityOrCrudeHumor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ageAssurance")]
        public bool? AgeAssurance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexualContentGraphicAndNudity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentGraphicAndNudityJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity? SexualContentGraphicAndNudity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexualContentOrNudity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentOrNudityJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity? SexualContentOrNudity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialMedia")]
        public bool? SocialMedia { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialMediaAgeRestricted")]
        public bool? SocialMediaAgeRestricted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("horrorOrFearThemes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesHorrorOrFearThemesJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes? HorrorOrFearThemes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matureOrSuggestiveThemes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMatureOrSuggestiveThemesJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes? MatureOrSuggestiveThemes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unrestrictedWebAccess")]
        public bool? UnrestrictedWebAccess { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userGeneratedContent")]
        public bool? UserGeneratedContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violenceCartoonOrFantasy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceCartoonOrFantasyJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy? ViolenceCartoonOrFantasy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violenceRealisticProlongedGraphicOrSadistic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadisticJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic? ViolenceRealisticProlongedGraphicOrSadistic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violenceRealistic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic? ViolenceRealistic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ageRatingOverride")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride? AgeRatingOverride { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ageRatingOverrideV2")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideV2JsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2? AgeRatingOverrideV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("koreaAgeRatingOverride")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesKoreaAgeRatingOverrideJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride? KoreaAgeRatingOverride { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developerAgeRatingInfoUrl")]
        public string? DeveloperAgeRatingInfoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgeRatingDeclarationAttributes" /> class.
        /// </summary>
        /// <param name="advertising"></param>
        /// <param name="alcoholTobaccoOrDrugUseOrReferences"></param>
        /// <param name="contests"></param>
        /// <param name="gambling"></param>
        /// <param name="gamblingSimulated"></param>
        /// <param name="gunsOrOtherWeapons"></param>
        /// <param name="healthOrWellnessTopics"></param>
        /// <param name="kidsAgeBand"></param>
        /// <param name="lootBox"></param>
        /// <param name="medicalOrTreatmentInformation"></param>
        /// <param name="messagingAndChat"></param>
        /// <param name="parentalControls"></param>
        /// <param name="profanityOrCrudeHumor"></param>
        /// <param name="ageAssurance"></param>
        /// <param name="sexualContentGraphicAndNudity"></param>
        /// <param name="sexualContentOrNudity"></param>
        /// <param name="socialMedia"></param>
        /// <param name="socialMediaAgeRestricted"></param>
        /// <param name="horrorOrFearThemes"></param>
        /// <param name="matureOrSuggestiveThemes"></param>
        /// <param name="unrestrictedWebAccess"></param>
        /// <param name="userGeneratedContent"></param>
        /// <param name="violenceCartoonOrFantasy"></param>
        /// <param name="violenceRealisticProlongedGraphicOrSadistic"></param>
        /// <param name="violenceRealistic"></param>
        /// <param name="ageRatingOverrideV2"></param>
        /// <param name="koreaAgeRatingOverride"></param>
        /// <param name="developerAgeRatingInfoUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgeRatingDeclarationAttributes(
            bool? advertising,
            global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences? alcoholTobaccoOrDrugUseOrReferences,
            global::AppStoreConnect.AgeRatingDeclarationAttributesContests? contests,
            bool? gambling,
            global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated? gamblingSimulated,
            global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons? gunsOrOtherWeapons,
            bool? healthOrWellnessTopics,
            global::AppStoreConnect.KidsAgeBand? kidsAgeBand,
            bool? lootBox,
            global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation? medicalOrTreatmentInformation,
            bool? messagingAndChat,
            bool? parentalControls,
            global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor? profanityOrCrudeHumor,
            bool? ageAssurance,
            global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity? sexualContentGraphicAndNudity,
            global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity? sexualContentOrNudity,
            bool? socialMedia,
            bool? socialMediaAgeRestricted,
            global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes? horrorOrFearThemes,
            global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes? matureOrSuggestiveThemes,
            bool? unrestrictedWebAccess,
            bool? userGeneratedContent,
            global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy? violenceCartoonOrFantasy,
            global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic? violenceRealisticProlongedGraphicOrSadistic,
            global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic? violenceRealistic,
            global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2? ageRatingOverrideV2,
            global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride? koreaAgeRatingOverride,
            string? developerAgeRatingInfoUrl)
        {
            this.Advertising = advertising;
            this.AlcoholTobaccoOrDrugUseOrReferences = alcoholTobaccoOrDrugUseOrReferences;
            this.Contests = contests;
            this.Gambling = gambling;
            this.GamblingSimulated = gamblingSimulated;
            this.GunsOrOtherWeapons = gunsOrOtherWeapons;
            this.HealthOrWellnessTopics = healthOrWellnessTopics;
            this.KidsAgeBand = kidsAgeBand;
            this.LootBox = lootBox;
            this.MedicalOrTreatmentInformation = medicalOrTreatmentInformation;
            this.MessagingAndChat = messagingAndChat;
            this.ParentalControls = parentalControls;
            this.ProfanityOrCrudeHumor = profanityOrCrudeHumor;
            this.AgeAssurance = ageAssurance;
            this.SexualContentGraphicAndNudity = sexualContentGraphicAndNudity;
            this.SexualContentOrNudity = sexualContentOrNudity;
            this.SocialMedia = socialMedia;
            this.SocialMediaAgeRestricted = socialMediaAgeRestricted;
            this.HorrorOrFearThemes = horrorOrFearThemes;
            this.MatureOrSuggestiveThemes = matureOrSuggestiveThemes;
            this.UnrestrictedWebAccess = unrestrictedWebAccess;
            this.UserGeneratedContent = userGeneratedContent;
            this.ViolenceCartoonOrFantasy = violenceCartoonOrFantasy;
            this.ViolenceRealisticProlongedGraphicOrSadistic = violenceRealisticProlongedGraphicOrSadistic;
            this.ViolenceRealistic = violenceRealistic;
            this.AgeRatingOverrideV2 = ageRatingOverrideV2;
            this.KoreaAgeRatingOverride = koreaAgeRatingOverride;
            this.DeveloperAgeRatingInfoUrl = developerAgeRatingInfoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgeRatingDeclarationAttributes" /> class.
        /// </summary>
        public AgeRatingDeclarationAttributes()
        {
        }

    }
}