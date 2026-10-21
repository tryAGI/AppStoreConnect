
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SubscriptionVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F67F7C2E73DF8FA9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_23E9542C95B7E00B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7681F36509FE9324.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2663843363057DB9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F75AEE4387ABB5E4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F4842010ADAD63AC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C76312C75F9C1FE4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_733B1CC54AC99966.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DFBC258FF53A2CE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D1646718E75C2F2B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8B1171B5D26814BD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EAD6E63B7698C873.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_864E3EA431578623.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4ABE9C485631536E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_434E0EA0BB878D26.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA343A61D24C9807.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A33C502E19F48533.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7E342627CA489F44.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_22FA39680E536F25.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SubscriptionVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SubscriptionVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private SubscriptionVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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