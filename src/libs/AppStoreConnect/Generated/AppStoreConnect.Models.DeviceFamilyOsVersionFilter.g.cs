
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeviceFamilyOsVersionFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceFamily")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter))]
        public global::AppStoreConnect.DeviceFamily? DeviceFamily { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumOsInclusive")]
        public string? MinimumOsInclusive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximumOsInclusive")]
        public string? MaximumOsInclusive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFamilyOsVersionFilter" /> class.
        /// </summary>
        /// <param name="deviceFamily"></param>
        /// <param name="minimumOsInclusive"></param>
        /// <param name="maximumOsInclusive"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeviceFamilyOsVersionFilter(
            global::AppStoreConnect.DeviceFamily? deviceFamily,
            string? minimumOsInclusive,
            string? maximumOsInclusive)
        {
            this.DeviceFamily = deviceFamily;
            this.MinimumOsInclusive = minimumOsInclusive;
            this.MaximumOsInclusive = maximumOsInclusive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFamilyOsVersionFilter" /> class.
        /// </summary>
        public DeviceFamilyOsVersionFilter()
        {
        }

    }
}