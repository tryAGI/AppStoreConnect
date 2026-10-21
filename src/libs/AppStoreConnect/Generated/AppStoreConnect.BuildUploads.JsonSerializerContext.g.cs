
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BuildUploadsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B27CF19CBDE081FB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2145B23035F187A1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_58062D9AF9741CE2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BA486A7F11AE4ECD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2C483941DA1E218C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F8135A09A4F4E119.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1ECD86AEA0C26765.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9CAC82F6CE3ECE38.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A1C4E37888FE2B98.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EDCF6BFF35C6423D.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BuildUploadsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BuildUploadsSourceGenerationContext Default => DefaultHolder.Instance;
        private BuildUploadsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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