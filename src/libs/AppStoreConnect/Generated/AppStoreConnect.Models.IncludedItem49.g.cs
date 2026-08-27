#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem49 : global::System.IEquatable<IncludedItem49>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BackgroundAssetUploadFile? BackgroundAssetUploadFiles { get; init; }
#else
        public global::AppStoreConnect.BackgroundAssetUploadFile? BackgroundAssetUploadFiles { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackgroundAssetUploadFiles))]
#endif
        public bool IsBackgroundAssetUploadFiles => BackgroundAssetUploadFiles != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBackgroundAssetUploadFiles(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BackgroundAssetUploadFile? value)
        {
            value = BackgroundAssetUploadFiles;
            return IsBackgroundAssetUploadFiles;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.BackgroundAssetUploadFile PickBackgroundAssetUploadFiles() => IsBackgroundAssetUploadFiles
            ? BackgroundAssetUploadFiles!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetUploadFiles' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? BackgroundAssetVersionAppStoreReleases1 { get; init; }
#else
        public global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? BackgroundAssetVersionAppStoreReleases1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackgroundAssetVersionAppStoreReleases1))]
#endif
        public bool IsBackgroundAssetVersionAppStoreReleases1 => BackgroundAssetVersionAppStoreReleases1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBackgroundAssetVersionAppStoreReleases1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? value)
        {
            value = BackgroundAssetVersionAppStoreReleases1;
            return IsBackgroundAssetVersionAppStoreReleases1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease PickBackgroundAssetVersionAppStoreReleases1() => IsBackgroundAssetVersionAppStoreReleases1
            ? BackgroundAssetVersionAppStoreReleases1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetVersionAppStoreReleases1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? BackgroundAssetVersionExternalBetaReleases { get; init; }
#else
        public global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? BackgroundAssetVersionExternalBetaReleases { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackgroundAssetVersionExternalBetaReleases))]
#endif
        public bool IsBackgroundAssetVersionExternalBetaReleases => BackgroundAssetVersionExternalBetaReleases != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBackgroundAssetVersionExternalBetaReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? value)
        {
            value = BackgroundAssetVersionExternalBetaReleases;
            return IsBackgroundAssetVersionExternalBetaReleases;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease PickBackgroundAssetVersionExternalBetaReleases() => IsBackgroundAssetVersionExternalBetaReleases
            ? BackgroundAssetVersionExternalBetaReleases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetVersionExternalBetaReleases' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? BackgroundAssetVersionInternalBetaReleases { get; init; }
#else
        public global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? BackgroundAssetVersionInternalBetaReleases { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackgroundAssetVersionInternalBetaReleases))]
#endif
        public bool IsBackgroundAssetVersionInternalBetaReleases => BackgroundAssetVersionInternalBetaReleases != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBackgroundAssetVersionInternalBetaReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? value)
        {
            value = BackgroundAssetVersionInternalBetaReleases;
            return IsBackgroundAssetVersionInternalBetaReleases;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease PickBackgroundAssetVersionInternalBetaReleases() => IsBackgroundAssetVersionInternalBetaReleases
            ? BackgroundAssetVersionInternalBetaReleases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetVersionInternalBetaReleases' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BackgroundAsset? BackgroundAssetVersionAppStoreReleases2 { get; init; }
#else
        public global::AppStoreConnect.BackgroundAsset? BackgroundAssetVersionAppStoreReleases2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackgroundAssetVersionAppStoreReleases2))]
#endif
        public bool IsBackgroundAssetVersionAppStoreReleases2 => BackgroundAssetVersionAppStoreReleases2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBackgroundAssetVersionAppStoreReleases2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BackgroundAsset? value)
        {
            value = BackgroundAssetVersionAppStoreReleases2;
            return IsBackgroundAssetVersionAppStoreReleases2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.BackgroundAsset PickBackgroundAssetVersionAppStoreReleases2() => IsBackgroundAssetVersionAppStoreReleases2
            ? BackgroundAssetVersionAppStoreReleases2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetVersionAppStoreReleases2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem49(global::AppStoreConnect.BackgroundAssetUploadFile value) => new IncludedItem49((global::AppStoreConnect.BackgroundAssetUploadFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetUploadFile?(IncludedItem49 @this) => @this.BackgroundAssetUploadFiles;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem49(global::AppStoreConnect.BackgroundAssetUploadFile? value)
        {
            BackgroundAssetUploadFiles = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem49 FromBackgroundAssetUploadFiles(global::AppStoreConnect.BackgroundAssetUploadFile? value) => new IncludedItem49(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem49(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease value) => new IncludedItem49((global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease?(IncludedItem49 @this) => @this.BackgroundAssetVersionAppStoreReleases1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem49(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? value)
        {
            BackgroundAssetVersionAppStoreReleases1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem49 FromBackgroundAssetVersionAppStoreReleases1(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? value) => new IncludedItem49(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem49(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease value) => new IncludedItem49((global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease?(IncludedItem49 @this) => @this.BackgroundAssetVersionExternalBetaReleases;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem49(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? value)
        {
            BackgroundAssetVersionExternalBetaReleases = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem49 FromBackgroundAssetVersionExternalBetaReleases(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? value) => new IncludedItem49(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem49(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease value) => new IncludedItem49((global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease?(IncludedItem49 @this) => @this.BackgroundAssetVersionInternalBetaReleases;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem49(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? value)
        {
            BackgroundAssetVersionInternalBetaReleases = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem49 FromBackgroundAssetVersionInternalBetaReleases(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? value) => new IncludedItem49(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem49(global::AppStoreConnect.BackgroundAsset value) => new IncludedItem49((global::AppStoreConnect.BackgroundAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAsset?(IncludedItem49 @this) => @this.BackgroundAssetVersionAppStoreReleases2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem49(global::AppStoreConnect.BackgroundAsset? value)
        {
            BackgroundAssetVersionAppStoreReleases2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem49 FromBackgroundAssetVersionAppStoreReleases2(global::AppStoreConnect.BackgroundAsset? value) => new IncludedItem49(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem49(
            global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.BackgroundAssetUploadFile? backgroundAssetUploadFiles,
            global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? backgroundAssetVersionAppStoreReleases1,
            global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? backgroundAssetVersionExternalBetaReleases,
            global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? backgroundAssetVersionInternalBetaReleases,
            global::AppStoreConnect.BackgroundAsset? backgroundAssetVersionAppStoreReleases2
            )
        {
            Type = type;

            BackgroundAssetUploadFiles = backgroundAssetUploadFiles;
            BackgroundAssetVersionAppStoreReleases1 = backgroundAssetVersionAppStoreReleases1;
            BackgroundAssetVersionExternalBetaReleases = backgroundAssetVersionExternalBetaReleases;
            BackgroundAssetVersionInternalBetaReleases = backgroundAssetVersionInternalBetaReleases;
            BackgroundAssetVersionAppStoreReleases2 = backgroundAssetVersionAppStoreReleases2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BackgroundAssetVersionAppStoreReleases2 as object ??
            BackgroundAssetVersionInternalBetaReleases as object ??
            BackgroundAssetVersionExternalBetaReleases as object ??
            BackgroundAssetVersionAppStoreReleases1 as object ??
            BackgroundAssetUploadFiles as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BackgroundAssetUploadFiles?.ToString() ??
            BackgroundAssetVersionAppStoreReleases1?.ToString() ??
            BackgroundAssetVersionExternalBetaReleases?.ToString() ??
            BackgroundAssetVersionInternalBetaReleases?.ToString() ??
            BackgroundAssetVersionAppStoreReleases2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBackgroundAssetUploadFiles && !IsBackgroundAssetVersionAppStoreReleases1 && !IsBackgroundAssetVersionExternalBetaReleases && !IsBackgroundAssetVersionInternalBetaReleases && !IsBackgroundAssetVersionAppStoreReleases2 || !IsBackgroundAssetUploadFiles && IsBackgroundAssetVersionAppStoreReleases1 && !IsBackgroundAssetVersionExternalBetaReleases && !IsBackgroundAssetVersionInternalBetaReleases && !IsBackgroundAssetVersionAppStoreReleases2 || !IsBackgroundAssetUploadFiles && !IsBackgroundAssetVersionAppStoreReleases1 && IsBackgroundAssetVersionExternalBetaReleases && !IsBackgroundAssetVersionInternalBetaReleases && !IsBackgroundAssetVersionAppStoreReleases2 || !IsBackgroundAssetUploadFiles && !IsBackgroundAssetVersionAppStoreReleases1 && !IsBackgroundAssetVersionExternalBetaReleases && IsBackgroundAssetVersionInternalBetaReleases && !IsBackgroundAssetVersionAppStoreReleases2 || !IsBackgroundAssetUploadFiles && !IsBackgroundAssetVersionAppStoreReleases1 && !IsBackgroundAssetVersionExternalBetaReleases && !IsBackgroundAssetVersionInternalBetaReleases && IsBackgroundAssetVersionAppStoreReleases2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.BackgroundAssetUploadFile, TResult>? backgroundAssetUploadFiles = null,
            global::System.Func<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease, TResult>? backgroundAssetVersionAppStoreReleases1 = null,
            global::System.Func<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease, TResult>? backgroundAssetVersionExternalBetaReleases = null,
            global::System.Func<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease, TResult>? backgroundAssetVersionInternalBetaReleases = null,
            global::System.Func<global::AppStoreConnect.BackgroundAsset, TResult>? backgroundAssetVersionAppStoreReleases2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBackgroundAssetUploadFiles && backgroundAssetUploadFiles != null)
            {
                return backgroundAssetUploadFiles(BackgroundAssetUploadFiles!);
            }
            else if (IsBackgroundAssetVersionAppStoreReleases1 && backgroundAssetVersionAppStoreReleases1 != null)
            {
                return backgroundAssetVersionAppStoreReleases1(BackgroundAssetVersionAppStoreReleases1!);
            }
            else if (IsBackgroundAssetVersionExternalBetaReleases && backgroundAssetVersionExternalBetaReleases != null)
            {
                return backgroundAssetVersionExternalBetaReleases(BackgroundAssetVersionExternalBetaReleases!);
            }
            else if (IsBackgroundAssetVersionInternalBetaReleases && backgroundAssetVersionInternalBetaReleases != null)
            {
                return backgroundAssetVersionInternalBetaReleases(BackgroundAssetVersionInternalBetaReleases!);
            }
            else if (IsBackgroundAssetVersionAppStoreReleases2 && backgroundAssetVersionAppStoreReleases2 != null)
            {
                return backgroundAssetVersionAppStoreReleases2(BackgroundAssetVersionAppStoreReleases2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.BackgroundAssetUploadFile>? backgroundAssetUploadFiles = null,

            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease>? backgroundAssetVersionAppStoreReleases1 = null,

            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease>? backgroundAssetVersionExternalBetaReleases = null,

            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease>? backgroundAssetVersionInternalBetaReleases = null,

            global::System.Action<global::AppStoreConnect.BackgroundAsset>? backgroundAssetVersionAppStoreReleases2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBackgroundAssetUploadFiles)
            {
                backgroundAssetUploadFiles?.Invoke(BackgroundAssetUploadFiles!);
            }
            else if (IsBackgroundAssetVersionAppStoreReleases1)
            {
                backgroundAssetVersionAppStoreReleases1?.Invoke(BackgroundAssetVersionAppStoreReleases1!);
            }
            else if (IsBackgroundAssetVersionExternalBetaReleases)
            {
                backgroundAssetVersionExternalBetaReleases?.Invoke(BackgroundAssetVersionExternalBetaReleases!);
            }
            else if (IsBackgroundAssetVersionInternalBetaReleases)
            {
                backgroundAssetVersionInternalBetaReleases?.Invoke(BackgroundAssetVersionInternalBetaReleases!);
            }
            else if (IsBackgroundAssetVersionAppStoreReleases2)
            {
                backgroundAssetVersionAppStoreReleases2?.Invoke(BackgroundAssetVersionAppStoreReleases2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.BackgroundAssetUploadFile>? backgroundAssetUploadFiles = null,
            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease>? backgroundAssetVersionAppStoreReleases1 = null,
            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease>? backgroundAssetVersionExternalBetaReleases = null,
            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease>? backgroundAssetVersionInternalBetaReleases = null,
            global::System.Action<global::AppStoreConnect.BackgroundAsset>? backgroundAssetVersionAppStoreReleases2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBackgroundAssetUploadFiles)
            {
                backgroundAssetUploadFiles?.Invoke(BackgroundAssetUploadFiles!);
            }
            else if (IsBackgroundAssetVersionAppStoreReleases1)
            {
                backgroundAssetVersionAppStoreReleases1?.Invoke(BackgroundAssetVersionAppStoreReleases1!);
            }
            else if (IsBackgroundAssetVersionExternalBetaReleases)
            {
                backgroundAssetVersionExternalBetaReleases?.Invoke(BackgroundAssetVersionExternalBetaReleases!);
            }
            else if (IsBackgroundAssetVersionInternalBetaReleases)
            {
                backgroundAssetVersionInternalBetaReleases?.Invoke(BackgroundAssetVersionInternalBetaReleases!);
            }
            else if (IsBackgroundAssetVersionAppStoreReleases2)
            {
                backgroundAssetVersionAppStoreReleases2?.Invoke(BackgroundAssetVersionAppStoreReleases2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BackgroundAssetUploadFiles,
                typeof(global::AppStoreConnect.BackgroundAssetUploadFile),
                BackgroundAssetVersionAppStoreReleases1,
                typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease),
                BackgroundAssetVersionExternalBetaReleases,
                typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease),
                BackgroundAssetVersionInternalBetaReleases,
                typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease),
                BackgroundAssetVersionAppStoreReleases2,
                typeof(global::AppStoreConnect.BackgroundAsset),
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
        public bool Equals(IncludedItem49 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetUploadFile?>.Default.Equals(BackgroundAssetUploadFiles, other.BackgroundAssetUploadFiles) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease?>.Default.Equals(BackgroundAssetVersionAppStoreReleases1, other.BackgroundAssetVersionAppStoreReleases1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease?>.Default.Equals(BackgroundAssetVersionExternalBetaReleases, other.BackgroundAssetVersionExternalBetaReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease?>.Default.Equals(BackgroundAssetVersionInternalBetaReleases, other.BackgroundAssetVersionInternalBetaReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAsset?>.Default.Equals(BackgroundAssetVersionAppStoreReleases2, other.BackgroundAssetVersionAppStoreReleases2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem49 obj1, IncludedItem49 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem49>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem49 obj1, IncludedItem49 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem49 o && Equals(o);
        }
    }
}
