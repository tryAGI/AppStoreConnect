
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCategoryRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subcategories")]
        public global::AppStoreConnect.AppCategoryRelationshipsSubcategories? Subcategories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public global::AppStoreConnect.AppCategoryRelationshipsParent? Parent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCategoryRelationships" /> class.
        /// </summary>
        /// <param name="subcategories"></param>
        /// <param name="parent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCategoryRelationships(
            global::AppStoreConnect.AppCategoryRelationshipsSubcategories? subcategories,
            global::AppStoreConnect.AppCategoryRelationshipsParent? parent)
        {
            this.Subcategories = subcategories;
            this.Parent = parent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCategoryRelationships" /> class.
        /// </summary>
        public AppCategoryRelationships()
        {
        }

    }
}