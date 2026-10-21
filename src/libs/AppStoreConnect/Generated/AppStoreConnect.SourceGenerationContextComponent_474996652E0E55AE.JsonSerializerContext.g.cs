
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_474996652E0E55AE : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1D760DB55A6AA489.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4268328C7ECA9067.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_608E5460E33C49A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_77F0CC5A4ABDF2E0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8B06DC2E1EBE46D3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B3753044E3725772.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D7145F19D541EC4E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DD9F090CA9EA5EDC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F1E73CB4DD48C2AA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F4D8E1BD25A72B66.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_474996652E0E55AE Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_474996652E0E55AE Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_474996652E0E55AE(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.AppInfoRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_AppInfoRelationships.Create_AppInfoRelationships(options);
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