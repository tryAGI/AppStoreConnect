
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyticsReportAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AnalyticsReportAttributesCategoryJsonConverter))]
        public global::AppStoreConnect.AnalyticsReportAttributesCategory? Category { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsReportAttributes(
            string? name,
            global::AppStoreConnect.AnalyticsReportAttributesCategory? category)
        {
            this.Name = name;
            this.Category = category;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportAttributes" /> class.
        /// </summary>
        public AnalyticsReportAttributes()
        {
        }

    }
}