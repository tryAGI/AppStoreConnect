
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DevicesGetCollectionSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        Minusid,
        /// <summary>
        /// 
        /// </summary>
        Minusname,
        /// <summary>
        /// 
        /// </summary>
        Minusplatform,
        /// <summary>
        /// 
        /// </summary>
        Minusstatus,
        /// <summary>
        /// 
        /// </summary>
        Minusudid,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Udid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DevicesGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DevicesGetCollectionSortItem value)
        {
            return value switch
            {
                DevicesGetCollectionSortItem.Minusid => "-id",
                DevicesGetCollectionSortItem.Minusname => "-name",
                DevicesGetCollectionSortItem.Minusplatform => "-platform",
                DevicesGetCollectionSortItem.Minusstatus => "-status",
                DevicesGetCollectionSortItem.Minusudid => "-udid",
                DevicesGetCollectionSortItem.Id => "id",
                DevicesGetCollectionSortItem.Name => "name",
                DevicesGetCollectionSortItem.Platform => "platform",
                DevicesGetCollectionSortItem.Status => "status",
                DevicesGetCollectionSortItem.Udid => "udid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DevicesGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-id" => DevicesGetCollectionSortItem.Minusid,
                "-name" => DevicesGetCollectionSortItem.Minusname,
                "-platform" => DevicesGetCollectionSortItem.Minusplatform,
                "-status" => DevicesGetCollectionSortItem.Minusstatus,
                "-udid" => DevicesGetCollectionSortItem.Minusudid,
                "id" => DevicesGetCollectionSortItem.Id,
                "name" => DevicesGetCollectionSortItem.Name,
                "platform" => DevicesGetCollectionSortItem.Platform,
                "status" => DevicesGetCollectionSortItem.Status,
                "udid" => DevicesGetCollectionSortItem.Udid,
                _ => null,
            };
        }
    }
}