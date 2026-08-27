
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PreviewFrameImage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::AppStoreConnect.ImageAsset? Image { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::AppStoreConnect.AppMediaPreviewFrameImageState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewFrameImage" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewFrameImage(
            global::AppStoreConnect.ImageAsset? image,
            global::AppStoreConnect.AppMediaPreviewFrameImageState? state)
        {
            this.Image = image;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewFrameImage" /> class.
        /// </summary>
        public PreviewFrameImage()
        {
        }

    }
}