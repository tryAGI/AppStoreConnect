
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxTestersV2GetCollectionFieldsSandboxTester
    {
        /// <summary>
        /// 
        /// </summary>
        AcAccountName,
        /// <summary>
        /// 
        /// </summary>
        ApplePayCompatible,
        /// <summary>
        /// 
        /// </summary>
        FirstName,
        /// <summary>
        /// 
        /// </summary>
        InterruptPurchases,
        /// <summary>
        /// 
        /// </summary>
        LastName,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionRenewalRate,
        /// <summary>
        /// 
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTestersV2GetCollectionFieldsSandboxTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTestersV2GetCollectionFieldsSandboxTester value)
        {
            return value switch
            {
                SandboxTestersV2GetCollectionFieldsSandboxTester.AcAccountName => "acAccountName",
                SandboxTestersV2GetCollectionFieldsSandboxTester.ApplePayCompatible => "applePayCompatible",
                SandboxTestersV2GetCollectionFieldsSandboxTester.FirstName => "firstName",
                SandboxTestersV2GetCollectionFieldsSandboxTester.InterruptPurchases => "interruptPurchases",
                SandboxTestersV2GetCollectionFieldsSandboxTester.LastName => "lastName",
                SandboxTestersV2GetCollectionFieldsSandboxTester.SubscriptionRenewalRate => "subscriptionRenewalRate",
                SandboxTestersV2GetCollectionFieldsSandboxTester.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTestersV2GetCollectionFieldsSandboxTester? ToEnum(string value)
        {
            return value switch
            {
                "acAccountName" => SandboxTestersV2GetCollectionFieldsSandboxTester.AcAccountName,
                "applePayCompatible" => SandboxTestersV2GetCollectionFieldsSandboxTester.ApplePayCompatible,
                "firstName" => SandboxTestersV2GetCollectionFieldsSandboxTester.FirstName,
                "interruptPurchases" => SandboxTestersV2GetCollectionFieldsSandboxTester.InterruptPurchases,
                "lastName" => SandboxTestersV2GetCollectionFieldsSandboxTester.LastName,
                "subscriptionRenewalRate" => SandboxTestersV2GetCollectionFieldsSandboxTester.SubscriptionRenewalRate,
                "territory" => SandboxTestersV2GetCollectionFieldsSandboxTester.Territory,
                _ => null,
            };
        }
    }
}