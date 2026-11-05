
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion
    {
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        Placement,
        /// <summary>
        ///
        /// </summary>
        RetentionMessage,
        /// <summary>
        ///
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion.Placement => "placement",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}