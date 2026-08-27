
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScmPullRequestAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webUrl")]
        public string? WebUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceRepositoryOwner")]
        public string? SourceRepositoryOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceRepositoryName")]
        public string? SourceRepositoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceBranchName")]
        public string? SourceBranchName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationRepositoryOwner")]
        public string? DestinationRepositoryOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationRepositoryName")]
        public string? DestinationRepositoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationBranchName")]
        public string? DestinationBranchName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isClosed")]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCrossRepository")]
        public bool? IsCrossRepository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmPullRequestAttributes" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="number"></param>
        /// <param name="webUrl"></param>
        /// <param name="sourceRepositoryOwner"></param>
        /// <param name="sourceRepositoryName"></param>
        /// <param name="sourceBranchName"></param>
        /// <param name="destinationRepositoryOwner"></param>
        /// <param name="destinationRepositoryName"></param>
        /// <param name="destinationBranchName"></param>
        /// <param name="isClosed"></param>
        /// <param name="isCrossRepository"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScmPullRequestAttributes(
            string? title,
            int? number,
            string? webUrl,
            string? sourceRepositoryOwner,
            string? sourceRepositoryName,
            string? sourceBranchName,
            string? destinationRepositoryOwner,
            string? destinationRepositoryName,
            string? destinationBranchName,
            bool? isClosed,
            bool? isCrossRepository)
        {
            this.Title = title;
            this.Number = number;
            this.WebUrl = webUrl;
            this.SourceRepositoryOwner = sourceRepositoryOwner;
            this.SourceRepositoryName = sourceRepositoryName;
            this.SourceBranchName = sourceBranchName;
            this.DestinationRepositoryOwner = destinationRepositoryOwner;
            this.DestinationRepositoryName = destinationRepositoryName;
            this.DestinationBranchName = destinationBranchName;
            this.IsClosed = isClosed;
            this.IsCrossRepository = isCrossRepository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmPullRequestAttributes" /> class.
        /// </summary>
        public ScmPullRequestAttributes()
        {
        }

    }
}