#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem63 : global::System.IEquatable<IncludedItem63>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BuildUploadFile? BuildUploadFiles { get; init; }
#else
        public global::AppStoreConnect.BuildUploadFile? BuildUploadFiles { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuildUploadFiles))]
#endif
        public bool IsBuildUploadFiles => BuildUploadFiles != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuildUploadFiles(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BuildUploadFile? value)
        {
            value = BuildUploadFiles;
            return IsBuildUploadFiles;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildUploadFile PickBuildUploadFiles() => BuildUploadFiles is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuildUploadFiles' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Build? Builds { get; init; }
#else
        public global::AppStoreConnect.Build? Builds { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Builds))]
#endif
        public bool IsBuilds => Builds != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuilds(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Build? value)
        {
            value = Builds;
            return IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Build PickBuilds() => Builds is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builds' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.BuildUploadFile value) => new IncludedItem63((global::AppStoreConnect.BuildUploadFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BuildUploadFile?(IncludedItem63 @this) => @this.BuildUploadFiles;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.BuildUploadFile? value)
        {
            BuildUploadFiles = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBuildUploadFiles(global::AppStoreConnect.BuildUploadFile? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.Build value) => new IncludedItem63((global::AppStoreConnect.Build?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem63 @this) => @this.Builds;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.Build? value)
        {
            Builds = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBuilds(global::AppStoreConnect.Build? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(
            global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.BuildUploadFile? buildUploadFiles,
            global::AppStoreConnect.Build? builds
            )
        {
            Type = type;

            BuildUploadFiles = buildUploadFiles;
            Builds = builds;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Builds as object ??
            BuildUploadFiles as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BuildUploadFiles?.ToString() ??
            Builds?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBuildUploadFiles && !IsBuilds || !IsBuildUploadFiles && IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.BuildUploadFile, TResult>? buildUploadFiles = null,
            global::System.Func<global::AppStoreConnect.Build, TResult>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BuildUploadFiles is { } __value0 && buildUploadFiles != null)
            {
                return buildUploadFiles(__value0);
            }
            else if (Builds is { } __value1 && builds != null)
            {
                return builds(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.BuildUploadFile>? buildUploadFiles = null,

            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BuildUploadFiles is { } __value0)
            {
                buildUploadFiles?.Invoke(__value0);
            }
            else if (Builds is { } __value1)
            {
                builds?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.BuildUploadFile>? buildUploadFiles = null,
            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BuildUploadFiles is { } __value0)
            {
                buildUploadFiles?.Invoke(__value0);
            }
            else if (Builds is { } __value1)
            {
                builds?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BuildUploadFiles,
                typeof(global::AppStoreConnect.BuildUploadFile),
                Builds,
                typeof(global::AppStoreConnect.Build),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(IncludedItem63 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BuildUploadFile?>.Default.Equals(BuildUploadFiles, other.BuildUploadFiles) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(Builds, other.Builds)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem63 obj1, IncludedItem63 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem63>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem63 obj1, IncludedItem63 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem63 o && Equals(o);
        }
    }
}
