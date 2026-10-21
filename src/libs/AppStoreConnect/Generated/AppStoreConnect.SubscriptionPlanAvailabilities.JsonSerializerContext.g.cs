
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SubscriptionPlanAvailabilitiesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_97E410AE8753FE7A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0F3438D77FDFD17F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B9EA7ED82920B2FC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02BAED26F491688C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_80FB3248ED12C2B0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D4806821AF197D14.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F7E73E5710008FC5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3F9FF61C46D012F7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1E2EB42D2A049398.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_82AE836D4DCC7853.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85FBEBDA53191387.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_998ACDA2D5E178E2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4C835FFC6A65E6FA.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SubscriptionPlanAvailabilitiesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SubscriptionPlanAvailabilitiesSourceGenerationContext Default => DefaultHolder.Instance;
        private SubscriptionPlanAvailabilitiesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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