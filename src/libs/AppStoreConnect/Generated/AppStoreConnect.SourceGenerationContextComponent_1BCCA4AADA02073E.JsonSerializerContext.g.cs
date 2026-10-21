
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_1BCCA4AADA02073E
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
            collector.AddEnum(typeof(global::AppStoreConnect.AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment), static () => new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment?), static () => new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentNullableJsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment2.Create_AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableAppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment2.Create_NullableAppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment2(options);
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