#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem3>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppClipAdvancedExperienceImage? appClipAdvancedExperienceImages = default;
            if (discriminator?.Type == global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppClipAdvancedExperienceImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppClipAdvancedExperienceImage)}");
                appClipAdvancedExperienceImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppClipAdvancedExperienceLocalization? appClipAdvancedExperienceLocalizations1 = default;
            if (discriminator?.Type == global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppClipAdvancedExperienceLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization)}");
                appClipAdvancedExperienceLocalizations1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppClip? appClipAdvancedExperienceLocalizations2 = default;
            if (discriminator?.Type == global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppClip), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppClip> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppClip)}");
                appClipAdvancedExperienceLocalizations2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem3(
                discriminator?.Type,
                appClipAdvancedExperienceImages,

                appClipAdvancedExperienceLocalizations1,

                appClipAdvancedExperienceLocalizations2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAppClipAdvancedExperienceImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppClipAdvancedExperienceImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppClipAdvancedExperienceImages!, typeInfo);
            }
            else if (value.IsAppClipAdvancedExperienceLocalizations1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppClipAdvancedExperienceLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppClipAdvancedExperienceLocalizations1!, typeInfo);
            }
            else if (value.IsAppClipAdvancedExperienceLocalizations2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppClip), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppClip?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppClip).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppClipAdvancedExperienceLocalizations2!, typeInfo);
            }
        }
    }
}