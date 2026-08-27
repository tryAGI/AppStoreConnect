#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem2>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AlternativeDistributionPackageVersionResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AlternativeDistributionPackageVersionResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AlternativeDistributionPackageDelta? alternativeDistributionPackageDeltas = default;
            if (discriminator?.Type == global::AppStoreConnect.AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageDeltas)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AlternativeDistributionPackageDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AlternativeDistributionPackageDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AlternativeDistributionPackageDelta)}");
                alternativeDistributionPackageDeltas = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AlternativeDistributionPackageVariant? alternativeDistributionPackageVariants = default;
            if (discriminator?.Type == global::AppStoreConnect.AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageVariants)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AlternativeDistributionPackageVariant), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AlternativeDistributionPackageVariant> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AlternativeDistributionPackageVariant)}");
                alternativeDistributionPackageVariants = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AlternativeDistributionPackage? alternativeDistributionPackages = default;
            if (discriminator?.Type == global::AppStoreConnect.AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AlternativeDistributionPackage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AlternativeDistributionPackage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AlternativeDistributionPackage)}");
                alternativeDistributionPackages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem2(
                discriminator?.Type,
                alternativeDistributionPackageDeltas,

                alternativeDistributionPackageVariants,

                alternativeDistributionPackages
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAlternativeDistributionPackageDeltas)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AlternativeDistributionPackageDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AlternativeDistributionPackageDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AlternativeDistributionPackageDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AlternativeDistributionPackageDeltas!, typeInfo);
            }
            else if (value.IsAlternativeDistributionPackageVariants)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AlternativeDistributionPackageVariant), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AlternativeDistributionPackageVariant?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AlternativeDistributionPackageVariant).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AlternativeDistributionPackageVariants!, typeInfo);
            }
            else if (value.IsAlternativeDistributionPackages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AlternativeDistributionPackage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AlternativeDistributionPackage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AlternativeDistributionPackage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AlternativeDistributionPackages!, typeInfo);
            }
        }
    }
}