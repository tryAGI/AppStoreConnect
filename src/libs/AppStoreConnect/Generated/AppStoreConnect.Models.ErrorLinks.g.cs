
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("about")]
        public string? About { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("associated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.OneOfJsonConverter<string, global::AppStoreConnect.ErrorLinksAssociated>))]
        public global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>? Associated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLinks" /> class.
        /// </summary>
        /// <param name="about"></param>
        /// <param name="associated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorLinks(
            string? about,
            global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>? associated)
        {
            this.About = about;
            this.Associated = associated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLinks" /> class.
        /// </summary>
        public ErrorLinks()
        {
        }

    }
}