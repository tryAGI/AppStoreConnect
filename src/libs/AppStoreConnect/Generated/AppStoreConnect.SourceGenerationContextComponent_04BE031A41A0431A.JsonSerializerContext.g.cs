
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_04BE031A41A0431A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_119FC66C77314AC7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_17DEDA4D86F0A301.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2A7677B9548AEE8F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2B54D533BB85BB57.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_414B13A705D6D4C8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_54D11E2B3F62C6D0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9EC4163A52CCD8E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A7101C541E5C186B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CDDC21628780DB21.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D86D710140AC8C8E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E6C4E4E80D35A395.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E95C5D0E57388367.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E99C87893CAFEA4F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED170F5F7D4B1A5D.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_04BE031A41A0431A Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_04BE031A41A0431A Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_04BE031A41A0431A(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
                if (type == typeof(global::AppStoreConnect.BuildRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_BuildRelationships.Create_BuildRelationships(options);
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