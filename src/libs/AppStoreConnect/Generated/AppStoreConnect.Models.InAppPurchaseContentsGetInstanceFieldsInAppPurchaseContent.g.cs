
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent
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
    public static class InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent value)
        {
            return value switch
            {
                InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.FileName => "fileName",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.FileSize => "fileSize",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.LastModifiedDate => "lastModifiedDate",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent? ToEnum(string value)
        {
            return value switch
            {
                "fileName" => InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.FileName,
                "fileSize" => InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.FileSize,
                "inAppPurchaseV2" => InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.InAppPurchaseV2,
                "lastModifiedDate" => InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.LastModifiedDate,
                "url" => InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent.Url,
                _ => null,
            };
        }
    }
}