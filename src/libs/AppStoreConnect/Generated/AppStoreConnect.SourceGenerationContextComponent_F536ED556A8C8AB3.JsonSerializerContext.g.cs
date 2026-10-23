
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F536ED556A8C8AB3
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_47927F47633DFF65.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_72E2869181FFEB7F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A1AE05904CC95C01.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.AppPriceV2InlineCreate, global::AppStoreConnect.TerritoryInlineCreate>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch1179.Create_SourceGenerationContextMetadataType_F536ED556A8C8AB3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.OneOf<global::AppStoreConnect.AppPriceV2InlineCreate, global::AppStoreConnect.TerritoryInlineCreate>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch1191.Create_SourceGenerationContextMetadataType_FD4299C508ACE9BF(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}