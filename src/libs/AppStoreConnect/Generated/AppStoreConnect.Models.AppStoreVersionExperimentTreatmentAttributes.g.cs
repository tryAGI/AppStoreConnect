
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionExperimentTreatmentAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appIcon")]
        public global::AppStoreConnect.ImageAsset? AppIcon { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appIconName")]
        public string? AppIconName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotedDate")]
        public global::System.DateTime? PromotedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="appIcon"></param>
        /// <param name="appIconName"></param>
        /// <param name="promotedDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionExperimentTreatmentAttributes(
            string? name,
            global::AppStoreConnect.ImageAsset? appIcon,
            string? appIconName,
            global::System.DateTime? promotedDate)
        {
            this.Name = name;
            this.AppIcon = appIcon;
            this.AppIconName = appIconName;
            this.PromotedDate = promotedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentAttributes" /> class.
        /// </summary>
        public AppStoreVersionExperimentTreatmentAttributes()
        {
        }

    }
}