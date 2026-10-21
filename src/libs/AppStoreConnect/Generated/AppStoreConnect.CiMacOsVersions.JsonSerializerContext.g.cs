
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class CiMacOsVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED95D2E69B3C644C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3532B2435DB01337.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_669EF2BBDA6252C7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A6C3888E5A64A5FE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A84AA96ECBCEFA52.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C738F366FD6CFBB3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85BF3C06874D4EE8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E03838F00646A83D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5DC730E441D5681.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0C23DC384215AD49.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45561ED1B102F336.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_99F1AA2D2C735991.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_30D8912EC55D7620.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly CiMacOsVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static CiMacOsVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private CiMacOsVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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