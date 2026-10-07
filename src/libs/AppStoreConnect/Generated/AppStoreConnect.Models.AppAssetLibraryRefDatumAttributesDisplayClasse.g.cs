
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributesDisplayClasse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayClassId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryDisplayClassJsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryDisplayClass? DisplayClassId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceFamily")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter))]
        public global::AppStoreConnect.DeviceFamily? DeviceFamily { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenDimensions")]
        public global::System.Collections.Generic.IList<string>? ScreenDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesDisplayClasse" /> class.
        /// </summary>
        /// <param name="displayClassId"></param>
        /// <param name="deviceFamily"></param>
        /// <param name="screenDimensions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributesDisplayClasse(
            global::AppStoreConnect.AppAssetLibraryDisplayClass? displayClassId,
            global::AppStoreConnect.DeviceFamily? deviceFamily,
            global::System.Collections.Generic.IList<string>? screenDimensions)
        {
            this.DisplayClassId = displayClassId;
            this.DeviceFamily = deviceFamily;
            this.ScreenDimensions = screenDimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesDisplayClasse" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributesDisplayClasse()
        {
        }

    }
}