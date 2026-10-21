
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class NominationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0409717235C9A852.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DB96591399339E9A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8B4282727A9A7923.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CF47D9E72D3E1015.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0B78C25D58626AFE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_614E39FE0FA755BD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C692A643FA374C3A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E1D2038EBCEB56BF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_63D35A720707ABE8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3D00C74F1CEA1A88.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85D671A194BA4913.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5FA49EAFE80F5491.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_64C6C0DFA6E94056.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_424434D7A537E316.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DB1D7669BDA8442F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_98BB6A153F61B458.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8A3FD545F57810E4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4DDF801B4EEF1F0D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B84393E9C353D5CB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6273931793345D17.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_32CE93009BE24820.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly NominationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static NominationsSourceGenerationContext Default => DefaultHolder.Instance;
        private NominationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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