
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppClipDefaultExperienceLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C1AE7968BCA3D139.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A8E628959A3958B5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_742397F0D6574070.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F7EA4B982685000C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F39C7A0B1D4D4A78.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CB97A5571B7F4BDB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FF04EBBB352B6BC7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2F2DCC16ECA15086.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A99CA57EC7E1A71A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_123A67BC14CF8807.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_19176854AFDA51BE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4F4EA17A326D243F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_86515BF8FD2EDEAE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1DFC2F247E73DF5A.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppClipDefaultExperienceLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppClipDefaultExperienceLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppClipDefaultExperienceLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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