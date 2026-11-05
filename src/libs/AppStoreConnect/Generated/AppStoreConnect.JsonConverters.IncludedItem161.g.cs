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
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionOffersResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionOffersResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.RetentionOffersResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.RetentionOfferPrice? retentionOfferPrices = default;
            if (discriminator?.Type == global::AppStoreConnect.RetentionOffersResponseIncludedItemDiscriminatorType.RetentionOfferPrices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionOfferPrice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionOfferPrice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.RetentionOfferPrice)}");
                retentionOfferPrices = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.Subscription? subscriptions = default;
            if (discriminator?.Type == global::AppStoreConnect.RetentionOffersResponseIncludedItemDiscriminatorType.Subscriptions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.Subscription), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.Subscription> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.Subscription)}");
                subscriptions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem161(
                discriminator?.Type,
                retentionOfferPrices,

                subscriptions
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
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsRetentionOfferPrices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionOfferPrice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionOfferPrice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.RetentionOfferPrice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRetentionOfferPrices(), typeInfo);
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