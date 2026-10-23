
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan1SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1AC680CB9B1D0E50.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F2D1FE10A4E7C761.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_331EF3F388DD7CA5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C40CD2485FDAA873.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_42296ACAFB1A1B23.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_410F27C7977B22AB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_07AC1D8D650EBD47.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EC88F210F3F7DEEA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D3A1DD7058080B4C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2EA33A1BF898BCEE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_73E2E8FC0A66E3EE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3D4F0672BF6029A0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E50A1FD910539032.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C2ABCDA80C6DC6DA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76D9E3B1BFDB5F50.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6830BB67C0256329.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F9B1A062754FC3AB.MetadataScope,                    static () => global::AppStoreConnect.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan1SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan1SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan1SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseCreateRequestDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseCreateRequestDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseCreateRequestDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseCreateRequestDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseCreateRequestDataRelationshipsGameCenterDetailDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseCreateRequestDataRelationshipsGameCenterDetailDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionReleaseJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease?), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionReleaseNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion?), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceIncludeItem), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleasesGetInstanceIncludeItemJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceIncludeItem?), static () => new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleasesGetInstanceIncludeItemNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}