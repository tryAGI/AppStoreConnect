
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_572DE548C5E5430C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A36F54AF3D92BD64.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_14712D9981EC7F49.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_928570160452FB72.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CFD7ADF5BAFE0893.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_060D6AA920C55851.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5AB6374165096432.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A64197AE83701D2B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D1D6948C73D3DA46.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5F02210754334C3D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_297C4D1AE7B6B685.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E190D15F3937D3F3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4941ECB67D6ED11D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9B6EF82E6A2184A6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CD6FC78186A3D8F2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B5A0B5271481EC4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_572DE548C5E5430C Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_572DE548C5E5430C Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_572DE548C5E5430C(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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