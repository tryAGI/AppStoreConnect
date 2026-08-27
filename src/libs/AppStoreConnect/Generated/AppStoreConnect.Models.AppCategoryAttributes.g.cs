
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCategoryAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platforms")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.Platform>? Platforms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCategoryAttributes" /> class.
        /// </summary>
        /// <param name="platforms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCategoryAttributes(
            global::System.Collections.Generic.IList<global::AppStoreConnect.Platform>? platforms)
        {
            this.Platforms = platforms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCategoryAttributes" /> class.
        /// </summary>
        public AppCategoryAttributes()
        {
        }

    }
}