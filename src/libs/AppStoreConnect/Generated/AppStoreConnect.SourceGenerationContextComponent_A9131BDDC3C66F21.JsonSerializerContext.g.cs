
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A9131BDDC3C66F21
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_26EE55593B28816D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_49C8FB23BA355A72.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FB7EACFA256B6C93.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem155JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem155JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem155))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_IncludedItem1552.Create_IncludedItem1552(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem155?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableIncludedItem1552.Create_NullableIncludedItem1552(options);
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