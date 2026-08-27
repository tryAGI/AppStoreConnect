#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem61 : global::System.IEquatable<IncludedItem61>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BuildUploadFile? BuildUploadFiles1 { get; init; }
#else
        public global::AppStoreConnect.BuildUploadFile? BuildUploadFiles1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuildUploadFiles1))]
#endif
        public bool IsBuildUploadFiles1 => BuildUploadFiles1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuildUploadFiles1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BuildUploadFile? value)
        {
            value = BuildUploadFiles1;
            return IsBuildUploadFiles1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildUploadFile PickBuildUploadFiles1() => IsBuildUploadFiles1
            ? BuildUploadFiles1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuildUploadFiles1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Build? BuildUploadFiles2 { get; init; }
#else
        public global::AppStoreConnect.Build? BuildUploadFiles2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuildUploadFiles2))]
#endif
        public bool IsBuildUploadFiles2 => BuildUploadFiles2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuildUploadFiles2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Build? value)
        {
            value = BuildUploadFiles2;
            return IsBuildUploadFiles2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Build PickBuildUploadFiles2() => IsBuildUploadFiles2
            ? BuildUploadFiles2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuildUploadFiles2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem61(global::AppStoreConnect.BuildUploadFile value) => new IncludedItem61((global::AppStoreConnect.BuildUploadFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BuildUploadFile?(IncludedItem61 @this) => @this.BuildUploadFiles1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(global::AppStoreConnect.BuildUploadFile? value)
        {
            BuildUploadFiles1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem61 FromBuildUploadFiles1(global::AppStoreConnect.BuildUploadFile? value) => new IncludedItem61(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem61(global::AppStoreConnect.Build value) => new IncludedItem61((global::AppStoreConnect.Build?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem61 @this) => @this.BuildUploadFiles2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(global::AppStoreConnect.Build? value)
        {
            BuildUploadFiles2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem61 FromBuildUploadFiles2(global::AppStoreConnect.Build? value) => new IncludedItem61(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(
            global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.BuildUploadFile? buildUploadFiles1,
            global::AppStoreConnect.Build? buildUploadFiles2
            )
        {
            Type = type;

            BuildUploadFiles1 = buildUploadFiles1;
            BuildUploadFiles2 = buildUploadFiles2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BuildUploadFiles2 as object ??
            BuildUploadFiles1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BuildUploadFiles1?.ToString() ??
            BuildUploadFiles2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBuildUploadFiles1 && !IsBuildUploadFiles2 || !IsBuildUploadFiles1 && IsBuildUploadFiles2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.BuildUploadFile, TResult>? buildUploadFiles1 = null,
            global::System.Func<global::AppStoreConnect.Build, TResult>? buildUploadFiles2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuildUploadFiles1 && buildUploadFiles1 != null)
            {
                return buildUploadFiles1(BuildUploadFiles1!);
            }
            else if (IsBuildUploadFiles2 && buildUploadFiles2 != null)
            {
                return buildUploadFiles2(BuildUploadFiles2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.BuildUploadFile>? buildUploadFiles1 = null,

            global::System.Action<global::AppStoreConnect.Build>? buildUploadFiles2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuildUploadFiles1)
            {
                buildUploadFiles1?.Invoke(BuildUploadFiles1!);
            }
            else if (IsBuildUploadFiles2)
            {
                buildUploadFiles2?.Invoke(BuildUploadFiles2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.BuildUploadFile>? buildUploadFiles1 = null,
            global::System.Action<global::AppStoreConnect.Build>? buildUploadFiles2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuildUploadFiles1)
            {
                buildUploadFiles1?.Invoke(BuildUploadFiles1!);
            }
            else if (IsBuildUploadFiles2)
            {
                buildUploadFiles2?.Invoke(BuildUploadFiles2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BuildUploadFiles1,
                typeof(global::AppStoreConnect.BuildUploadFile),
                BuildUploadFiles2,
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
        public bool Equals(IncludedItem61 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BuildUploadFile?>.Default.Equals(BuildUploadFiles1, other.BuildUploadFiles1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(BuildUploadFiles2, other.BuildUploadFiles2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem61 obj1, IncludedItem61 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem61>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem61 obj1, IncludedItem61 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem61 o && Equals(o);
        }
    }
}
