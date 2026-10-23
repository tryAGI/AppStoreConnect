
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan2SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6D213388CA36AD4C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_55B636B02605D0EE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C94C86027831D22B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_50DF145379F3ACFB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2D77CFD7C89DC3FD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_44731CB362E9BCA5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A109359BE0072D90.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_52D44DD9BD9AE30A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F40E070C01977842.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C0BC81D64FD26C7C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_801DA39013A1E22A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFE46C7BDEB05A1D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0E74EF9BA70C485C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C159DC6053B1C276.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DCFE979FCD8B30C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3DC65212C4050023.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F38FBBC03859DC41.MetadataScope,                    static () => global::AppStoreConnect.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan2SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan2SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan2SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseCreateRequestDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseCreateRequestDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseCreateRequestDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseCreateRequestDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsGameCenterDetailDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsGameCenterDetailDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionRelease), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionReleaseJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionRelease?), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionReleaseNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion?), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleasesGetInstanceIncludeItem), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleasesGetInstanceIncludeItemJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleasesGetInstanceIncludeItem?), static () => new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleasesGetInstanceIncludeItemNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}