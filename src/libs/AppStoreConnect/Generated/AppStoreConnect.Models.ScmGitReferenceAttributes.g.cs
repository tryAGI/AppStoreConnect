
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScmGitReferenceAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonicalName")]
        public string? CanonicalName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDeleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiGitRefKindJsonConverter))]
        public global::AppStoreConnect.CiGitRefKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmGitReferenceAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="canonicalName"></param>
        /// <param name="isDeleted"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScmGitReferenceAttributes(
            string? name,
            string? canonicalName,
            bool? isDeleted,
            global::AppStoreConnect.CiGitRefKind? kind)
        {
            this.Name = name;
            this.CanonicalName = canonicalName;
            this.IsDeleted = isDeleted;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmGitReferenceAttributes" /> class.
        /// </summary>
        public ScmGitReferenceAttributes()
        {
        }

    }
}