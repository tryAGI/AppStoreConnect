
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_8139B8373F9BD81A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_939792C1EB15C997.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AF7911A006954DC8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E847F9FFA0869504.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_21DE3703F0C0106A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3776D092CF9F3C57.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_22CE966D272DB2D7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1EBC908110D8C39D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C8B495F98291661F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1D5C7A849D58B27B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4589261A65D18BB7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FDDEFFDE2BE66F7D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DD05FAF7E1865A06.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4BB7E71CD98358DA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_8139B8373F9BD81A Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_8139B8373F9BD81A Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_8139B8373F9BD81A(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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