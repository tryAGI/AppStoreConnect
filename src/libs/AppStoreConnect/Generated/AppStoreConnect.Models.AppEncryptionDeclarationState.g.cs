
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationState
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationState value)
        {
            return value switch
            {
                AppEncryptionDeclarationState.Approved => "APPROVED",
                AppEncryptionDeclarationState.Created => "CREATED",
                AppEncryptionDeclarationState.Expired => "EXPIRED",
                AppEncryptionDeclarationState.Invalid => "INVALID",
                AppEncryptionDeclarationState.InReview => "IN_REVIEW",
                AppEncryptionDeclarationState.Rejected => "REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => AppEncryptionDeclarationState.Approved,
                "CREATED" => AppEncryptionDeclarationState.Created,
                "EXPIRED" => AppEncryptionDeclarationState.Expired,
                "INVALID" => AppEncryptionDeclarationState.Invalid,
                "IN_REVIEW" => AppEncryptionDeclarationState.InReview,
                "REJECTED" => AppEncryptionDeclarationState.Rejected,
                _ => null,
            };
        }
    }
}