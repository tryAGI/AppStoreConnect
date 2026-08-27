#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem145JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem145>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem145 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot? inAppPurchaseAppStoreReviewScreenshots = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAppStoreReviewScreenshots)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot)}");
                inAppPurchaseAppStoreReviewScreenshots = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseAvailability? inAppPurchaseAvailabilities = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAvailabilities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseAvailability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseAvailability> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseAvailability)}");
                inAppPurchaseAvailabilities = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseContent? inAppPurchaseContents = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseContents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseContent)}");
                inAppPurchaseContents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseImage? inAppPurchaseImages = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseImage)}");
                inAppPurchaseImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseLocalization? inAppPurchaseLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseLocalization)}");
                inAppPurchaseLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseOfferCode? inAppPurchaseOfferCodes = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseOfferCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseOfferCode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseOfferCode)}");
                inAppPurchaseOfferCodes = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchasePricePoint? inAppPurchasePricePoints = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchasePricePoints)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchasePricePoint), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchasePricePoint> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchasePricePoint)}");
                inAppPurchasePricePoints = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchasePriceSchedule? inAppPurchasePriceSchedules = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchasePriceSchedules)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchasePriceSchedule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchasePriceSchedule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchasePriceSchedule)}");
                inAppPurchasePriceSchedules = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseVersion? inAppPurchaseVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseVersion)}");
                inAppPurchaseVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.PromotedPurchase? promotedPurchases = default;
            if (discriminator?.Type == global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType.PromotedPurchases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.PromotedPurchase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.PromotedPurchase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.PromotedPurchase)}");
                promotedPurchases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem145(
                discriminator?.Type,
                inAppPurchaseAppStoreReviewScreenshots,

                inAppPurchaseAvailabilities,

                inAppPurchaseContents,

                inAppPurchaseImages,

                inAppPurchaseLocalizations,

                inAppPurchaseOfferCodes,

                inAppPurchasePricePoints,

                inAppPurchasePriceSchedules,

                inAppPurchaseVersions,

                promotedPurchases
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem145 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInAppPurchaseAppStoreReviewScreenshots)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseAppStoreReviewScreenshots!, typeInfo);
            }
            else if (value.IsInAppPurchaseAvailabilities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseAvailability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseAvailability?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseAvailability).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseAvailabilities!, typeInfo);
            }
            else if (value.IsInAppPurchaseContents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseContents!, typeInfo);
            }
            else if (value.IsInAppPurchaseImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseImages!, typeInfo);
            }
            else if (value.IsInAppPurchaseLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseLocalizations!, typeInfo);
            }
            else if (value.IsInAppPurchaseOfferCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseOfferCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseOfferCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseOfferCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseOfferCodes!, typeInfo);
            }
            else if (value.IsInAppPurchasePricePoints)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchasePricePoint), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchasePricePoint?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchasePricePoint).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchasePricePoints!, typeInfo);
            }
            else if (value.IsInAppPurchasePriceSchedules)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchasePriceSchedule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchasePriceSchedule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchasePriceSchedule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchasePriceSchedules!, typeInfo);
            }
            else if (value.IsInAppPurchaseVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseVersions!, typeInfo);
            }
            else if (value.IsPromotedPurchases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.PromotedPurchase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.PromotedPurchase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.PromotedPurchase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromotedPurchases!, typeInfo);
            }
        }
    }
}