
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent
    {
        /// <summary>
        /// 
        /// </summary>
        FileName,
        /// <summary>
        /// 
        /// </summary>
        FileSize,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseV2,
        /// <summary>
        /// 
        /// </summary>
        LastModifiedDate,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.FileName => "fileName",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.FileSize => "fileSize",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.InAppPurchaseV2 => "inAppPurchaseV2",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.LastModifiedDate => "lastModifiedDate",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent? ToEnum(string value)
        {
            return value switch
            {
                "fileName" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.FileName,
                "fileSize" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.FileSize,
                "inAppPurchaseV2" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.InAppPurchaseV2,
                "lastModifiedDate" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.LastModifiedDate,
                "url" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent.Url,
                _ => null,
            };
        }
    }
}