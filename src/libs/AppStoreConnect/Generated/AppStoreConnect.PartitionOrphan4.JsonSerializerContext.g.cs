
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan4SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4CBDE18151FF909C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_633E23C82B8ACD7F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4B89BC76916E43AA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_55D55DA0910EEEE3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B9F7A80D7DC08347.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5EF08BE1C3574FB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_519C9E3543B390AC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B0A2B07F1758714E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8606729ADDDB6E9D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8EE1E0A52DFBD115.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_957268FFECD32D08.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4C3FD1B78739873A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_81668437369B7B7C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4A50D7F988DD58EF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1FD992CC8B836A68.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3F748C2020F09D3C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05E8709B8C213FCC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E59E9BB15A4781E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_07C24DB8FAA30A9E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BDC450D1DA4BC309.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_81CAE6A9C0212894.MetadataScope,                    static () => global::AppStoreConnect.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan4SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan4SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan4SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseResponseIncludedItemDiscriminatorType), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseResponseIncludedItemDiscriminatorTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseResponseIncludedItemDiscriminatorType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseResponseIncludedItemDiscriminatorTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseCreateRequestDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseCreateRequestDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardReleaseJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardReleaseNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterDetail), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterDetailJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterDetail?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterDetailNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboard), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboard?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesGetInstanceIncludeItem), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesGetInstanceIncludeItemJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesGetInstanceIncludeItem?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesGetInstanceIncludeItemNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}