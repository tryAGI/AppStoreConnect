#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem38JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem38>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem38 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization)}");
                appStoreVersionExperimentTreatmentLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersionExperiment? appStoreVersionExperiments = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperiment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperiment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionExperiment)}");
                appStoreVersionExperiments = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem38(
                discriminator?.Type,
                appStoreVersionExperimentTreatmentLocalizations,

                appStoreVersionExperiments
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem38 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsAppStoreVersionExperimentTreatmentLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppStoreVersionExperimentTreatmentLocalizations(), typeInfo);
            }
            else if (value.IsAppStoreVersionExperiments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperiment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperiment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersionExperiment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppStoreVersionExperiments(), typeInfo);
            }
        }
    }
}