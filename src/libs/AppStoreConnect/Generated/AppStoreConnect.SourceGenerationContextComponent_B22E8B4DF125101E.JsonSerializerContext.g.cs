
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_B22E8B4DF125101E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27D82D5C13E63ACE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3852D5C99441DFB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3EEC1707BE9911A3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B1153695911883A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6AF1A6DB9F4F1A6C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7CCA5C1848913DC1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_814C730632B2EE7A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8985F1E779E1DA54.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8F002E2440B26919.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_97D140A7AE1AA859.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A1ACDC219AEBB569.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DB9B2469AB6F6F04.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FB991B724BADE2D7.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_B22E8B4DF125101E Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_B22E8B4DF125101E Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_B22E8B4DF125101E(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem65JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem65JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem65))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_IncludedItem652.Create_IncludedItem652(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem65?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableIncludedItem652.Create_NullableIncludedItem652(options);
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