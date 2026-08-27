
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent
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
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchaseContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.FileName => "fileName",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.FileSize => "fileSize",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.LastModifiedDate => "lastModifiedDate",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent? ToEnum(string value)
        {
            return value switch
            {
                "fileName" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.FileName,
                "fileSize" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.FileSize,
                "inAppPurchaseV2" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.InAppPurchaseV2,
                "lastModifiedDate" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.LastModifiedDate,
                "url" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent.Url,
                _ => null,
            };
        }
    }
}