
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppEventsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7BB65ED6550AA094.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_62734F7FEF6937BF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5805DC2DF9AB39C2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5A1D5F6E3065899A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5194F9C020C24907.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8301DC1EDEC7E93B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6568F873198D395A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C348D53CC10B13FC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_92956C922ED26419.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9B5FE049D7324032.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BCC8C6D9233B0B0E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9A781C36E06ED74F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_17161B15D4D5F285.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76EADFF39014A54A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7E6B6868599593EE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5FF3591E7636C331.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppEventsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppEventsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppEventsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

    }
}