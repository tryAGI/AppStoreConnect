
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Images,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Image => "image",
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Images => "images",
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Subscription => "subscription",
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Image,
                "images" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Images,
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Localizations,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.State,
                "subscription" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Subscription,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion.Version,
                _ => null,
            };
        }
    }
}