
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        Description,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionsGetInstanceFieldsSubscriptionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization value)
        {
            return value switch
            {
                SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization.Description => "description",
                SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization.Locale => "locale",
                SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization.Name => "name",
                SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization.Description,
                "locale" => SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization.Locale,
                "name" => SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization.Name,
                "version" => SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization.Version,
                _ => null,
            };
        }
    }
}