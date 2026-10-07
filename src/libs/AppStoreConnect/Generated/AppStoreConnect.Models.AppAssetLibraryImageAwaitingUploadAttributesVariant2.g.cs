
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryImageAwaitingUploadAttributesVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadOperations")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>? UploadOperations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryImageAwaitingUploadAttributesVariant2" /> class.
        /// </summary>
        /// <param name="uploadOperations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryImageAwaitingUploadAttributesVariant2(
            global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>? uploadOperations)
        {
            this.UploadOperations = uploadOperations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryImageAwaitingUploadAttributesVariant2" /> class.
        /// </summary>
        public AppAssetLibraryImageAwaitingUploadAttributesVariant2()
        {
        }

    }
}