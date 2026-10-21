
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_04A68FAD9151DD3A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC4837D7F2491B37.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_49F51AC1EBAD400C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8C34FBED8840BA16.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_930E2B28FE5160A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B0DA52CFC9BF9618.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AE8366E577452077.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3435B5B4AAAD5C7D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6AF42AC7B92F39F6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6A5EA98EE33C6396.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DCE9771F3D4209B7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_384164B6B9276F9C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4F9A6A935740592C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B1D6D647A0ED81F5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ECAFE55C5636F9AB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CD58BB8979A6A567.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_04A68FAD9151DD3A Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_04A68FAD9151DD3A Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_04A68FAD9151DD3A(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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