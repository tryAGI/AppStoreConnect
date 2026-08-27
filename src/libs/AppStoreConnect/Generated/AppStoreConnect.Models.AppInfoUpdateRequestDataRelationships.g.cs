
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppInfoUpdateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryCategory")]
        public global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategory? PrimaryCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primarySubcategoryOne")]
        public global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOne? PrimarySubcategoryOne { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primarySubcategoryTwo")]
        public global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwo? PrimarySubcategoryTwo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondaryCategory")]
        public global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategory? SecondaryCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondarySubcategoryOne")]
        public global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOne? SecondarySubcategoryOne { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondarySubcategoryTwo")]
        public global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwo? SecondarySubcategoryTwo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="primaryCategory"></param>
        /// <param name="primarySubcategoryOne"></param>
        /// <param name="primarySubcategoryTwo"></param>
        /// <param name="secondaryCategory"></param>
        /// <param name="secondarySubcategoryOne"></param>
        /// <param name="secondarySubcategoryTwo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppInfoUpdateRequestDataRelationships(
            global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategory? primaryCategory,
            global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOne? primarySubcategoryOne,
            global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwo? primarySubcategoryTwo,
            global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategory? secondaryCategory,
            global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOne? secondarySubcategoryOne,
            global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwo? secondarySubcategoryTwo)
        {
            this.PrimaryCategory = primaryCategory;
            this.PrimarySubcategoryOne = primarySubcategoryOne;
            this.PrimarySubcategoryTwo = primarySubcategoryTwo;
            this.SecondaryCategory = secondaryCategory;
            this.SecondarySubcategoryOne = secondarySubcategoryOne;
            this.SecondarySubcategoryTwo = secondarySubcategoryTwo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoUpdateRequestDataRelationships" /> class.
        /// </summary>
        public AppInfoUpdateRequestDataRelationships()
        {
        }

    }
}