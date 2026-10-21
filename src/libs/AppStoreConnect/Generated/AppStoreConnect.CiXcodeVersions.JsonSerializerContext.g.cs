
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class CiXcodeVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5DC730E441D5681.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FA1B1D479348655F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_614CFF214343E42D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_99679B9E4AAA90D6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_53BC5550CD95D371.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_398A0E2BB58DAF35.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7B6229BE0C7A3E82.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2A61494EDD18CC0C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED95D2E69B3C644C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_920D86442A06E00F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_34528DA11447D11A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2A2DA867630ACA9E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_416186661BC1FB82.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly CiXcodeVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static CiXcodeVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private CiXcodeVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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