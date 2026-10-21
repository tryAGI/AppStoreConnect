
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_DCBB7D21231F9B35 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1DFEAA9F3D93D9AA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DE596FFED2AAC568.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_84BFD173D6683B5A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4674F7371C5F377B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_16843BB5C86547E3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A118E6DB1596B3CF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7F5D5C29C5AE25F2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7A2D9F7391E0339E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_79F0598642DAD5BB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2B6E08D31BBF500F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_94844AC66DCB8F15.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2158CCFED7FE532D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_82553FB57B27D47B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9BD1CCECAE31A71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_857968F9EAF7BA1E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C0D158657EEB1C14.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5828110185BB70B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_DCBB7D21231F9B35 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_DCBB7D21231F9B35 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_DCBB7D21231F9B35(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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