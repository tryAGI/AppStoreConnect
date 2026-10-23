
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan5SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FA854F508B16A8DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_91FCE9347FF997F8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3BCE1C0153455281.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_603AA01247E8A11F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6C8DB01195015508.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E02CDB1C82857B3C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F9EED16F4ACF64B8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_97D19B7EE9F666D2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FC8F84C0C1F6AB35.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A56A7F4BED1EEFFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3FC4ED20A9238758.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5ECCDC26A80BB081.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FCD8A4EDC430A839.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5891BA2A482D65AD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_36FADAEE282592F8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9258B597857069D0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8578B5C093B34762.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1A1524260DD16655.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B0CC858E437DBA59.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_74D2BD87B3E2EA51.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_30EBFA68782A3A71.MetadataScope,                    static () => global::AppStoreConnect.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan5SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan5SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan5SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorType), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseCreateRequestDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseCreateRequestDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterDetailDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterDetailDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetReleaseJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetailJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetailNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesGetInstanceIncludeItem), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesGetInstanceIncludeItemJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesGetInstanceIncludeItem?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesGetInstanceIncludeItemNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}