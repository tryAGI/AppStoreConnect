
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_CA8EB6DE9D7861F4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28E28395E883FFFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E692D63665D7629A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EB0C338B42B40C34.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8B5216ECCDB1807F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_74E192C44F6593D9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7137B3AE6779DBA4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7133E33A9809B2E1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_19504D29A2C91F79.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2453D710B976E1DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_281679CFC43AB098.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_41D34AA7A8E393F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_00AED312A9DAE1AB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_CA8EB6DE9D7861F4 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_CA8EB6DE9D7861F4 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_CA8EB6DE9D7861F4(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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