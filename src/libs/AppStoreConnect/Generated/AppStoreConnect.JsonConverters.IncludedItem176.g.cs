#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem176JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem176>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem176 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.PromotedPurchase? promotedPurchases = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.PromotedPurchases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.PromotedPurchase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.PromotedPurchase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.PromotedPurchase)}");
                promotedPurchases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot? subscriptionAppStoreReviewScreenshots = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionAppStoreReviewScreenshots)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot)}");
                subscriptionAppStoreReviewScreenshots = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionAvailability? subscriptionAvailabilities = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionAvailabilities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionAvailability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionAvailability> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionAvailability)}");
                subscriptionAvailabilities = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionGroup? subscriptionGroups = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionGroup)}");
                subscriptionGroups = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionImage? subscriptionImages = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionImage)}");
                subscriptionImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionIntroductoryOffer? subscriptionIntroductoryOffers = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionIntroductoryOffers)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionIntroductoryOffer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionIntroductoryOffer)}");
                subscriptionIntroductoryOffers = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionLocalization? subscriptionLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionLocalization)}");
                subscriptionLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionOfferCode? subscriptionOfferCodes = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionOfferCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionOfferCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionOfferCode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionOfferCode)}");
                subscriptionOfferCodes = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionPlanAvailability? subscriptionPlanAvailabilities = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionPlanAvailabilities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionPlanAvailability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionPlanAvailability> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionPlanAvailability)}");
                subscriptionPlanAvailabilities = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionPrice? subscriptionPrices = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionPrices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionPrice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionPrice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionPrice)}");
                subscriptionPrices = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionPromotionalOffer? subscriptionPromotionalOffers = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionPromotionalOffers)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionPromotionalOffer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionPromotionalOffer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionPromotionalOffer)}");
                subscriptionPromotionalOffers = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionVersion? subscriptionVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionVersion)}");
                subscriptionVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.WinBackOffer? winBackOffers = default;
            if (discriminator?.Type == global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType.WinBackOffers)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.WinBackOffer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.WinBackOffer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.WinBackOffer)}");
                winBackOffers = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem176(
                discriminator?.Type,
                promotedPurchases,

                subscriptionAppStoreReviewScreenshots,

                subscriptionAvailabilities,

                subscriptionGroups,

                subscriptionImages,

                subscriptionIntroductoryOffers,

                subscriptionLocalizations,

                subscriptionOfferCodes,

                subscriptionPlanAvailabilities,

                subscriptionPrices,

                subscriptionPromotionalOffers,

                subscriptionVersions,

                winBackOffers
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem176 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPromotedPurchases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.PromotedPurchase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.PromotedPurchase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.PromotedPurchase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromotedPurchases!, typeInfo);
            }
            else if (value.IsSubscriptionAppStoreReviewScreenshots)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionAppStoreReviewScreenshots!, typeInfo);
            }
            else if (value.IsSubscriptionAvailabilities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionAvailability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionAvailability?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionAvailability).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionAvailabilities!, typeInfo);
            }
            else if (value.IsSubscriptionGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionGroups!, typeInfo);
            }
            else if (value.IsSubscriptionImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionImages!, typeInfo);
            }
            else if (value.IsSubscriptionIntroductoryOffers)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionIntroductoryOffer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionIntroductoryOffer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionIntroductoryOffers!, typeInfo);
            }
            else if (value.IsSubscriptionLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionLocalizations!, typeInfo);
            }
            else if (value.IsSubscriptionOfferCodes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionOfferCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionOfferCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionOfferCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionOfferCodes!, typeInfo);
            }
            else if (value.IsSubscriptionPlanAvailabilities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionPlanAvailability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionPlanAvailability?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionPlanAvailability).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionPlanAvailabilities!, typeInfo);
            }
            else if (value.IsSubscriptionPrices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionPrice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionPrice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionPrice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionPrices!, typeInfo);
            }
            else if (value.IsSubscriptionPromotionalOffers)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionPromotionalOffer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionPromotionalOffer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionPromotionalOffer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionPromotionalOffers!, typeInfo);
            }
            else if (value.IsSubscriptionVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionVersions!, typeInfo);
            }
            else if (value.IsWinBackOffers)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.WinBackOffer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.WinBackOffer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.WinBackOffer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WinBackOffers!, typeInfo);
            }
        }
    }
}