
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ProfilesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9C5E0317C572DEC4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_21F84545AC762885.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_156FA56BFA8B8B24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_46785B8E2E4CD8EC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D9A9372FC1D70B31.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B02A60D7B29803D6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1D61789909201948.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_271FEE5100984FFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F59AE1AAAE043F25.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AEE38B75D3A8D063.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9A81F7F414C764C5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3F045F119229C897.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2791A354898FBFE0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27DE6122FB4A18B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A8959AD0B9569FA1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC653929E8221538.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9FD6FD2D0E46E5AE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ECD35AB33FFB7EC0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A890855D8CC9DE59.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_23D582BA2448F060.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1CC3737A02AD6272.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2508EFB574B6AD32.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AD3C9F81CF25902E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7541A6E0331127E8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1C20884834CEAB33.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_92344883B9D2BB35.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ProfilesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ProfilesSourceGenerationContext Default => DefaultHolder.Instance;
        private ProfilesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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