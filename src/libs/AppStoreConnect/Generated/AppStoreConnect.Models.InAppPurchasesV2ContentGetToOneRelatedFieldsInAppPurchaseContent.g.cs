
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent
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
    public static class InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent value)
        {
            return value switch
            {
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.FileName => "fileName",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.FileSize => "fileSize",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.LastModifiedDate => "lastModifiedDate",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent? ToEnum(string value)
        {
            return value switch
            {
                "fileName" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.FileName,
                "fileSize" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.FileSize,
                "inAppPurchaseV2" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.InAppPurchaseV2,
                "lastModifiedDate" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.LastModifiedDate,
                "url" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent.Url,
                _ => null,
            };
        }
    }
}