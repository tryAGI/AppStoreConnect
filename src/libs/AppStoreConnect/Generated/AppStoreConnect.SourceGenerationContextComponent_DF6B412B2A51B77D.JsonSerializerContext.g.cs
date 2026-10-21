
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_DF6B412B2A51B77D : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_DF6B412B2A51B77D Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_DF6B412B2A51B77D Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_DF6B412B2A51B77D(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie), static () => new global::AppStoreConnect.JsonConverters.InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitieJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie?), static () => new global::AppStoreConnect.JsonConverters.InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitieNullableJsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie2.Create_InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableInAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie2.Create_NullableInAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie2(options);
                }
                #pragma warning restore CS0618
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}