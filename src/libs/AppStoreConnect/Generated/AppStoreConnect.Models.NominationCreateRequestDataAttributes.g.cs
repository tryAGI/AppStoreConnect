
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NominationCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.NominationCreateRequestDataAttributesTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.NominationCreateRequestDataAttributesType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Submitted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishStartDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishStartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishEndDate")]
        public global::System.DateTime? PublishEndDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceFamilies")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DeviceFamily>? DeviceFamilies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locales")]
        public global::System.Collections.Generic.IList<string>? Locales { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supplementalMaterialsUris")]
        public global::System.Collections.Generic.IList<string>? SupplementalMaterialsUris { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasInAppEvents")]
        public bool? HasInAppEvents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("launchInSelectMarketsFirst")]
        public bool? LaunchInSelectMarketsFirst { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preOrderEnabled")]
        public bool? PreOrderEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="submitted"></param>
        /// <param name="publishStartDate"></param>
        /// <param name="publishEndDate"></param>
        /// <param name="deviceFamilies"></param>
        /// <param name="locales"></param>
        /// <param name="supplementalMaterialsUris"></param>
        /// <param name="hasInAppEvents"></param>
        /// <param name="launchInSelectMarketsFirst"></param>
        /// <param name="notes"></param>
        /// <param name="preOrderEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NominationCreateRequestDataAttributes(
            string name,
            global::AppStoreConnect.NominationCreateRequestDataAttributesType type,
            string description,
            bool submitted,
            global::System.DateTime publishStartDate,
            global::System.DateTime? publishEndDate,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DeviceFamily>? deviceFamilies,
            global::System.Collections.Generic.IList<string>? locales,
            global::System.Collections.Generic.IList<string>? supplementalMaterialsUris,
            bool? hasInAppEvents,
            bool? launchInSelectMarketsFirst,
            string? notes,
            bool? preOrderEnabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Submitted = submitted;
            this.PublishStartDate = publishStartDate;
            this.PublishEndDate = publishEndDate;
            this.DeviceFamilies = deviceFamilies;
            this.Locales = locales;
            this.SupplementalMaterialsUris = supplementalMaterialsUris;
            this.HasInAppEvents = hasInAppEvents;
            this.LaunchInSelectMarketsFirst = launchInSelectMarketsFirst;
            this.Notes = notes;
            this.PreOrderEnabled = preOrderEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationCreateRequestDataAttributes" /> class.
        /// </summary>
        public NominationCreateRequestDataAttributes()
        {
        }

    }
}