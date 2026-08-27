
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationsGetCollectionSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinuslastModifiedDate,
        /// <summary>
        ///
        /// </summary>
        Minusname,
        /// <summary>
        ///
        /// </summary>
        MinuspublishEndDate,
        /// <summary>
        ///
        /// </summary>
        MinuspublishStartDate,
        /// <summary>
        ///
        /// </summary>
        Minustype,
        /// <summary>
        ///
        /// </summary>
        LastModifiedDate,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        PublishEndDate,
        /// <summary>
        ///
        /// </summary>
        PublishStartDate,
        /// <summary>
        ///
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationsGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetCollectionSortItem value)
        {
            return value switch
            {
                NominationsGetCollectionSortItem.MinuslastModifiedDate => "-lastModifiedDate",
                NominationsGetCollectionSortItem.Minusname => "-name",
                NominationsGetCollectionSortItem.MinuspublishEndDate => "-publishEndDate",
                NominationsGetCollectionSortItem.MinuspublishStartDate => "-publishStartDate",
                NominationsGetCollectionSortItem.Minustype => "-type",
                NominationsGetCollectionSortItem.LastModifiedDate => "lastModifiedDate",
                NominationsGetCollectionSortItem.Name => "name",
                NominationsGetCollectionSortItem.PublishEndDate => "publishEndDate",
                NominationsGetCollectionSortItem.PublishStartDate => "publishStartDate",
                NominationsGetCollectionSortItem.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-lastModifiedDate" => NominationsGetCollectionSortItem.MinuslastModifiedDate,
                "-name" => NominationsGetCollectionSortItem.Minusname,
                "-publishEndDate" => NominationsGetCollectionSortItem.MinuspublishEndDate,
                "-publishStartDate" => NominationsGetCollectionSortItem.MinuspublishStartDate,
                "-type" => NominationsGetCollectionSortItem.Minustype,
                "lastModifiedDate" => NominationsGetCollectionSortItem.LastModifiedDate,
                "name" => NominationsGetCollectionSortItem.Name,
                "publishEndDate" => NominationsGetCollectionSortItem.PublishEndDate,
                "publishStartDate" => NominationsGetCollectionSortItem.PublishStartDate,
                "type" => NominationsGetCollectionSortItem.Type,
                _ => null,
            };
        }
    }
}