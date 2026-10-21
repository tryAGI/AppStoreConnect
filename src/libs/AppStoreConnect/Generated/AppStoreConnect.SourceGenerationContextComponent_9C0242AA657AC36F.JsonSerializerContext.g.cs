
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9C0242AA657AC36F
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2B9A38576E025CA5.MetadataScope,
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_9C0242AA657AC36F.Create_SourceGenerationContextMetadataType_9C0242AA657AC36F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_57D5DE316285983F.Create_SourceGenerationContextMetadataType_57D5DE316285983F(options);
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