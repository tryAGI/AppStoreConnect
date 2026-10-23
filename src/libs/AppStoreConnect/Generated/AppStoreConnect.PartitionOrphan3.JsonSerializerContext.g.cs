
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan3SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_099734AB92844CB2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3BBA32F3E6D4C04C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_63C91DF2E8D9790E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CCF6F420EF594213.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E664F8E1B2DF5A7E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F46482AF27430B9B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F43B298F63AF0516.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C8F4746B4455A800.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FFEB0E2D7F2F7E3F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ACE649B909976CBF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5D24D337086590D4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1295842C9C928EC3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_707C4A022443F9DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B5F4B2C13D488BA7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_295B7E023235EBA1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_642457226737A92A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7C2D4E60A53E4105.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FFB66F1D5AB4DB65.MetadataScope,                    static () => global::AppStoreConnect.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan3SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan3SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan3SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionCompatibleVersionsLinkagesResponseDataItemType), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionCompatibleVersionsLinkagesResponseDataItemTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionCompatibleVersionsLinkagesResponseDataItemType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionCompatibleVersionsLinkagesResponseDataItemTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemType), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItemJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem?), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItemNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItem), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItemJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItem?), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItemNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersionJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersion?), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsGameCenterEnabledVersionNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsApp), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsAppJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsApp?), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFieldsAppNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItem), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItemJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItem?), static () => new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItemNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}