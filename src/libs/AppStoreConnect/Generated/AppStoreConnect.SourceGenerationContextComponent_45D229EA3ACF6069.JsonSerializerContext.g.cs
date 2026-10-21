
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_45D229EA3ACF6069 : global::System.Text.Json.Serialization.JsonSerializerContext
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
            internal static readonly SourceGenerationContextComponent_45D229EA3ACF6069 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_45D229EA3ACF6069 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_45D229EA3ACF6069(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode), static () => new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCodeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode?), static () => new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCodeNullableJsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode2.Create_SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableSubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode2.Create_NullableSubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode2(options);
                }
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