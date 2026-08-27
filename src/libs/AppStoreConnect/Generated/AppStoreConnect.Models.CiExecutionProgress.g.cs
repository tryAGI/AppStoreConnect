
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiExecutionProgress
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiExecutionProgressExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiExecutionProgress value)
        {
            return value switch
            {
                CiExecutionProgress.Complete => "COMPLETE",
                CiExecutionProgress.Pending => "PENDING",
                CiExecutionProgress.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiExecutionProgress? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => CiExecutionProgress.Complete,
                "PENDING" => CiExecutionProgress.Pending,
                "RUNNING" => CiExecutionProgress.Running,
                _ => null,
            };
        }
    }
}