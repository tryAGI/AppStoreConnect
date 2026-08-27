#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem161JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem161>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem161 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroupVersionResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroupVersionResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionGroupVersionResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.SubscriptionGroupLocalizationV2? subscriptionGroupLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionGroupVersionResponseIncludedItemDiscriminatorType.SubscriptionGroupLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroupLocalizationV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionGroupLocalizationV2)}");
                subscriptionGroupLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionGroup? subscriptionGroups = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionGroupVersionResponseIncludedItemDiscriminatorType.SubscriptionGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionGroup)}");
                subscriptionGroups = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem161(
                discriminator?.Type,
                subscriptionGroupLocalizations,

                subscriptionGroups
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem161 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSubscriptionGroupLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroupLocalizationV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionGroupLocalizations!, typeInfo);
            }
            else if (value.IsSubscriptionGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionGroups!, typeInfo);
            }
        }
    }
}