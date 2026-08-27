
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NominationAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.NominationAttributesTypeJsonConverter))]
        public global::AppStoreConnect.NominationAttributesType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModifiedDate")]
        public global::System.DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedDate")]
        public global::System.DateTime? SubmittedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.NominationAttributesStateJsonConverter))]
        public global::AppStoreConnect.NominationAttributesState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishStartDate")]
        public global::System.DateTime? PublishStartDate { get; set; }

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
        /// Initializes a new instance of the <see cref="NominationAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="createdDate"></param>
        /// <param name="lastModifiedDate"></param>
        /// <param name="submittedDate"></param>
        /// <param name="state"></param>
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
        public NominationAttributes(
            string? name,
            global::AppStoreConnect.NominationAttributesType? type,
            string? description,
            global::System.DateTime? createdDate,
            global::System.DateTime? lastModifiedDate,
            global::System.DateTime? submittedDate,
            global::AppStoreConnect.NominationAttributesState? state,
            global::System.DateTime? publishStartDate,
            global::System.DateTime? publishEndDate,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DeviceFamily>? deviceFamilies,
            global::System.Collections.Generic.IList<string>? locales,
            global::System.Collections.Generic.IList<string>? supplementalMaterialsUris,
            bool? hasInAppEvents,
            bool? launchInSelectMarketsFirst,
            string? notes,
            bool? preOrderEnabled)
        {
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.SubmittedDate = submittedDate;
            this.State = state;
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
        /// Initializes a new instance of the <see cref="NominationAttributes" /> class.
        /// </summary>
        public NominationAttributes()
        {
        }

    }
}