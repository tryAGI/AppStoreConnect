#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem158JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem158>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem158 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionMessagesResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionMessagesResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.RetentionMessagesResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.RetentionMessageVersion? retentionMessageVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.RetentionMessagesResponseIncludedItemDiscriminatorType.RetentionMessageVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionMessageVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionMessageVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.RetentionMessageVersion)}");
                retentionMessageVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.Subscription? subscriptions = default;
            if (discriminator?.Type == global::AppStoreConnect.RetentionMessagesResponseIncludedItemDiscriminatorType.Subscriptions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.Subscription), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.Subscription> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.Subscription)}");
                subscriptions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem158(
                discriminator?.Type,
                retentionMessageVersions,

                subscriptions
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem158 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsRetentionMessageVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionMessageVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionMessageVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.RetentionMessageVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRetentionMessageVersions(), typeInfo);
            }
            else if (value.IsSubscriptions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.Subscription), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.Subscription?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.Subscription).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSubscriptions(), typeInfo);
            }
        }
    }
}