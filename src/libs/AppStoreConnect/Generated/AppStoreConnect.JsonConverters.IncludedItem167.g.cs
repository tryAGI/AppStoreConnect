#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem167JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem167>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem167 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.SubscriptionOfferCodeCustomCode? subscriptionOfferCodeCustomCodes = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeCustomCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionOfferCodeCustomCode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode)}");
                subscriptionOfferCodeCustomCodes = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode? subscriptionOfferCodeOneTimeUseCodes = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeOneTimeUseCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode)}");
                subscriptionOfferCodeOneTimeUseCodes = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionOfferCodePrice? subscriptionOfferCodePrices1 = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodePrices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionOfferCodePrice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionOfferCodePrice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionOfferCodePrice)}");
                subscriptionOfferCodePrices1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.Subscription? subscriptionOfferCodePrices2 = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodePrices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.Subscription), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.Subscription> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.Subscription)}");
                subscriptionOfferCodePrices2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem167(
                discriminator?.Type,
                subscriptionOfferCodeCustomCodes,

                subscriptionOfferCodeOneTimeUseCodes,

                subscriptionOfferCodePrices1,

                subscriptionOfferCodePrices2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem167 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSubscriptionOfferCodeCustomCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionOfferCodeCustomCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionOfferCodeCustomCodes!, typeInfo);
            }
            else if (value.IsSubscriptionOfferCodeOneTimeUseCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionOfferCodeOneTimeUseCodes!, typeInfo);
            }
            else if (value.IsSubscriptionOfferCodePrices1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionOfferCodePrice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionOfferCodePrice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionOfferCodePrice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionOfferCodePrices1!, typeInfo);
            }
            else if (value.IsSubscriptionOfferCodePrices2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.Subscription), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.Subscription?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.Subscription).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionOfferCodePrices2!, typeInfo);
            }
        }
    }
}