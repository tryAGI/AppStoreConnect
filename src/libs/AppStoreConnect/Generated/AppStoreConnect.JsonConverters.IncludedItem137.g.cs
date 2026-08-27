#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem137JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem137>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem137 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseOfferCodeResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseOfferCodeResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseOfferCodeResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode? inAppPurchaseOfferCodeCustomCodes = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeCustomCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode)}");
                inAppPurchaseOfferCodeCustomCodes = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode? inAppPurchaseOfferCodeOneTimeUseCodes = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeOneTimeUseCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode)}");
                inAppPurchaseOfferCodeOneTimeUseCodes = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseOfferPrice? inAppPurchaseOfferPrices = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType.InAppPurchaseOfferPrices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseOfferPrice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseOfferPrice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseOfferPrice)}");
                inAppPurchaseOfferPrices = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem137(
                discriminator?.Type,
                inAppPurchaseOfferCodeCustomCodes,

                inAppPurchaseOfferCodeOneTimeUseCodes,

                inAppPurchaseOfferPrices
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem137 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInAppPurchaseOfferCodeCustomCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseOfferCodeCustomCodes!, typeInfo);
            }
            else if (value.IsInAppPurchaseOfferCodeOneTimeUseCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseOfferCodeOneTimeUseCodes!, typeInfo);
            }
            else if (value.IsInAppPurchaseOfferPrices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseOfferPrice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseOfferPrice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseOfferPrice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseOfferPrices!, typeInfo);
            }
        }
    }
}