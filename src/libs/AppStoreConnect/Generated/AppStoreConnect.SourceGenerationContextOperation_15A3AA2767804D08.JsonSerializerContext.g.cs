
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_15A3AA2767804D08 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28E28395E883FFFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_12DD292C928E93F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AC04A0D95B1F22C3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5DD25C6F48C85EFB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02C6C2792B75EC4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_91DC5CEE98911F8A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27C7FD3588489CFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_78772F068465FB22.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F0DE8BB7EEABBDED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0501272107B22CAB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4C7BDE92C185F97F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_91CD50866C79CD66.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_15A3AA2767804D08 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_15A3AA2767804D08 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_15A3AA2767804D08(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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