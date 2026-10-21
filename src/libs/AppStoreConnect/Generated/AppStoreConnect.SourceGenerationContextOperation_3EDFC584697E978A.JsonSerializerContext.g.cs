
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_3EDFC584697E978A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28E28395E883FFFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E0FFA6AC99EF4E41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9EB9E80C501C1387.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A91938CC95FB46DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FF84A7A65C7AC6BD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27F9F6CCDD0B7804.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5D91829DBD87B9F4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5E05E41ECA9706B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BE64E282A779935D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D3E7596FB71524F4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EA88AFB835CEA322.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27F9ADB7E21A1A35.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_3EDFC584697E978A Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_3EDFC584697E978A Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_3EDFC584697E978A(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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