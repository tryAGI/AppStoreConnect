#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class Attributes2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.Attributes2>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.Attributes2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes? awaitingUpload = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.AwaitingUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes)}");
                awaitingUpload = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes? uploadComplete = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.UploadComplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes)}");
                uploadComplete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes? failed = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? complete1 = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.Complete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes)}");
                complete1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? complete2 = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.Complete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes)}");
                complete2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes? readyForReview = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.ReadyForReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes)}");
                readyForReview = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes? waitingForReview = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.WaitingForReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes)}");
                waitingForReview = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes? inReview = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.InReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes)}");
                inReview = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes? accepted = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.Accepted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes)}");
                accepted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes? approved = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.Approved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes)}");
                approved = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes? rejected = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.Rejected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes)}");
                rejected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes? archived = default;
            if (discriminator?.State == global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState.Archived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes)}");
                archived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.Attributes2(
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
            global::AppStoreConnect.Attributes2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAwaitingUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAwaitingUpload(), typeInfo);
            }
            else if (value.IsUploadComplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUploadComplete(), typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFailed(), typeInfo);
            }
            else if (value.IsComplete1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComplete1(), typeInfo);
            }
            else if (value.IsComplete2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComplete2(), typeInfo);
            }
            else if (value.IsReadyForReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReadyForReview(), typeInfo);
            }
            else if (value.IsWaitingForReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWaitingForReview(), typeInfo);
            }
            else if (value.IsInReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInReview(), typeInfo);
            }
            else if (value.IsAccepted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAccepted(), typeInfo);
            }
            else if (value.IsApproved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickApproved(), typeInfo);
            }
            else if (value.IsRejected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRejected(), typeInfo);
            }
            else if (value.IsArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickArchived(), typeInfo);
            }
        }
    }
}