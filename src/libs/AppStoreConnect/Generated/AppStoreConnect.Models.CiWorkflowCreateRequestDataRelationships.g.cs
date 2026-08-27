
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiWorkflowCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProduct Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepository Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xcodeVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersion XcodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("macOsVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersion MacOsVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="repository"></param>
        /// <param name="xcodeVersion"></param>
        /// <param name="macOsVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiWorkflowCreateRequestDataRelationships(
            global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProduct product,
            global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepository repository,
            global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersion xcodeVersion,
            global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersion macOsVersion)
        {
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.XcodeVersion = xcodeVersion ?? throw new global::System.ArgumentNullException(nameof(xcodeVersion));
            this.MacOsVersion = macOsVersion ?? throw new global::System.ArgumentNullException(nameof(macOsVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowCreateRequestDataRelationships" /> class.
        /// </summary>
        public CiWorkflowCreateRequestDataRelationships()
        {
        }

    }
}