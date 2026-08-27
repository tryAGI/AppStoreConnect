
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPage,
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPageLocalizations,
        /// <summary>
        /// 
        /// </summary>
        DeepLink,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPage => "appCustomProductPage",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.DeepLink => "deepLink",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPage" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPage,
                "appCustomProductPageLocalizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations,
                "deepLink" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.DeepLink,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.State,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion.Version,
                _ => null,
            };
        }
    }
}