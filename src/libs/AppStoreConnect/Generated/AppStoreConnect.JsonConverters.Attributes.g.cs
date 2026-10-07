#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class AttributesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.Attributes>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.Attributes Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes? awaitingUpload = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.AwaitingUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes)}");
                awaitingUpload = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes? uploadComplete = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.UploadComplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes)}");
                uploadComplete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageFailedAttributes? failed = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageFailedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? complete1 = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.Complete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes)}");
                complete1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? complete2 = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.Complete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes)}");
                complete2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes? readyForReview = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.ReadyForReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes)}");
                readyForReview = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes? waitingForReview = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.WaitingForReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes)}");
                waitingForReview = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes? inReview = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.InReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes)}");
                inReview = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes? accepted = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.Accepted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes)}");
                accepted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes? approved = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.Approved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes)}");
                approved = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes? rejected = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.Rejected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes)}");
                rejected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes? archived = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState.Archived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes)}");
                archived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.Attributes(
                discriminator?.State,
                awaitingUpload,

                uploadComplete,

                failed,

                complete1,

                complete2,

                readyForReview,

                waitingForReview,

                inReview,

                accepted,

                approved,

                rejected,

                archived
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.Attributes value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAwaitingUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAwaitingUpload(), typeInfo);
            }
            else if (value.IsUploadComplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUploadComplete(), typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageFailedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFailed(), typeInfo);
            }
            else if (value.IsComplete1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComplete1(), typeInfo);
            }
            else if (value.IsComplete2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComplete2(), typeInfo);
            }
            else if (value.IsReadyForReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReadyForReview(), typeInfo);
            }
            else if (value.IsWaitingForReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWaitingForReview(), typeInfo);
            }
            else if (value.IsInReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInReview(), typeInfo);
            }
            else if (value.IsAccepted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAccepted(), typeInfo);
            }
            else if (value.IsApproved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickApproved(), typeInfo);
            }
            else if (value.IsRejected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRejected(), typeInfo);
            }
            else if (value.IsArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickArchived(), typeInfo);
            }
        }
    }
}