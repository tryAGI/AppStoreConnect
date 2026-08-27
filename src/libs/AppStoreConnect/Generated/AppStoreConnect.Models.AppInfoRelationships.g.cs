
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppInfoRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.AppInfoRelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ageRatingDeclaration")]
        public global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclaration? AgeRatingDeclaration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appInfoLocalizations")]
        public global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizations? AppInfoLocalizations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryCategory")]
        public global::AppStoreConnect.AppInfoRelationshipsPrimaryCategory? PrimaryCategory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primarySubcategoryOne")]
        public global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOne? PrimarySubcategoryOne { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primarySubcategoryTwo")]
        public global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwo? PrimarySubcategoryTwo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondaryCategory")]
        public global::AppStoreConnect.AppInfoRelationshipsSecondaryCategory? SecondaryCategory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondarySubcategoryOne")]
        public global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOne? SecondarySubcategoryOne { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondarySubcategoryTwo")]
        public global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwo? SecondarySubcategoryTwo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territoryAgeRatings")]
        public global::AppStoreConnect.AppInfoRelationshipsTerritoryAgeRatings? TerritoryAgeRatings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="ageRatingDeclaration"></param>
        /// <param name="appInfoLocalizations"></param>
        /// <param name="primaryCategory"></param>
        /// <param name="primarySubcategoryOne"></param>
        /// <param name="primarySubcategoryTwo"></param>
        /// <param name="secondaryCategory"></param>
        /// <param name="secondarySubcategoryOne"></param>
        /// <param name="secondarySubcategoryTwo"></param>
        /// <param name="territoryAgeRatings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppInfoRelationships(
            global::AppStoreConnect.AppInfoRelationshipsApp? app,
            global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclaration? ageRatingDeclaration,
            global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizations? appInfoLocalizations,
            global::AppStoreConnect.AppInfoRelationshipsPrimaryCategory? primaryCategory,
            global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOne? primarySubcategoryOne,
            global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwo? primarySubcategoryTwo,
            global::AppStoreConnect.AppInfoRelationshipsSecondaryCategory? secondaryCategory,
            global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOne? secondarySubcategoryOne,
            global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwo? secondarySubcategoryTwo,
            global::AppStoreConnect.AppInfoRelationshipsTerritoryAgeRatings? territoryAgeRatings)
        {
            this.App = app;
            this.AgeRatingDeclaration = ageRatingDeclaration;
            this.AppInfoLocalizations = appInfoLocalizations;
            this.PrimaryCategory = primaryCategory;
            this.PrimarySubcategoryOne = primarySubcategoryOne;
            this.PrimarySubcategoryTwo = primarySubcategoryTwo;
            this.SecondaryCategory = secondaryCategory;
            this.SecondarySubcategoryOne = secondarySubcategoryOne;
            this.SecondarySubcategoryTwo = secondarySubcategoryTwo;
            this.TerritoryAgeRatings = territoryAgeRatings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoRelationships" /> class.
        /// </summary>
        public AppInfoRelationships()
        {
        }

    }
}