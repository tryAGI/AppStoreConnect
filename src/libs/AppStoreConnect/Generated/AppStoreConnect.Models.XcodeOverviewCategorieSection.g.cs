
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeOverviewCategorieSection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevanceScore")]
        public double? RelevanceScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public global::AppStoreConnect.XcodeOverviewCategorieSectionUnit? Unit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeOverviewCategorieSectionDataset>? Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewCategorieSection" /> class.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="displayName"></param>
        /// <param name="relevanceScore"></param>
        /// <param name="sortOrder"></param>
        /// <param name="unit"></param>
        /// <param name="datasets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeOverviewCategorieSection(
            string? identifier,
            string? displayName,
            double? relevanceScore,
            int? sortOrder,
            global::AppStoreConnect.XcodeOverviewCategorieSectionUnit? unit,
            global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeOverviewCategorieSectionDataset>? datasets)
        {
            this.Identifier = identifier;
            this.DisplayName = displayName;
            this.RelevanceScore = relevanceScore;
            this.SortOrder = sortOrder;
            this.Unit = unit;
            this.Datasets = datasets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewCategorieSection" /> class.
        /// </summary>
        public XcodeOverviewCategorieSection()
        {
        }

    }
}