
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan0SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3A5600A5884625DB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E0C93B8EF22376A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2F6B0FCC4E3CF992.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_78779721AA326E79.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F70DFAA6704D3261.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4ADC571B9FFA0367.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2CE455674E07447A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6B85D359DD6A8E49.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_145DD6ECDA0C5988.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EC5DD60116279E54.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7A927DEB1C2DA555.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BB9347E53B76AABA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_160326C5E58FC359.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DC49DD1D5D6BF40A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_692F856A8E4728DC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6944BFA3C311F092.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9A39B9F5A449592E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DF99F4FC24C1241.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DC8256F848415F32.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F5E4EB4EDF618FF3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFC1CD7FDA1E9110.MetadataScope,                    static () => global::AppStoreConnect.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan0SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan0SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan0SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseResponseIncludedItemDiscriminatorTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseResponseIncludedItemDiscriminatorTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseCreateRequestDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseCreateRequestDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterDetailDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterDetailDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataType), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementReleaseJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease?), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementReleaseNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleasesGetInstanceFieldsGameCenterDetail), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesGetInstanceFieldsGameCenterDetailJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleasesGetInstanceFieldsGameCenterDetail?), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesGetInstanceFieldsGameCenterDetailNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement?), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleasesGetInstanceIncludeItem), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesGetInstanceIncludeItemJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterAchievementReleasesGetInstanceIncludeItem?), static () => new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesGetInstanceIncludeItemNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}