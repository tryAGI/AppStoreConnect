
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_550072EF1B3CC290
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::AppStoreConnect.AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization), static () => new global::AppStoreConnect.JsonConverters.AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalizationJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization?), static () => new global::AppStoreConnect.JsonConverters.AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalizationNullableJsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization2.Create_AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableAppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization2.Create_NullableAppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization2(options);
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