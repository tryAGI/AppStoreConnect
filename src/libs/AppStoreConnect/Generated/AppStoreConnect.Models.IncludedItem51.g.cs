#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem51 : global::System.IEquatable<IncludedItem51>
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
        public global::AppStoreConnect.BackgroundAssetUploadFile PickBackgroundAssetUploadFiles() => BackgroundAssetUploadFiles is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetUploadFiles' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? BackgroundAssetVersionAppStoreReleases { get; init; }
#else
        public global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? BackgroundAssetVersionAppStoreReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackgroundAssetVersionAppStoreReleases))]
#endif
        public bool IsBackgroundAssetVersionAppStoreReleases => BackgroundAssetVersionAppStoreReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBackgroundAssetVersionAppStoreReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? value)
        {
            value = BackgroundAssetVersionAppStoreReleases;
            return IsBackgroundAssetVersionAppStoreReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease PickBackgroundAssetVersionAppStoreReleases() => BackgroundAssetVersionAppStoreReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetVersionAppStoreReleases' but the value was {ToString()}.");

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
        public global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease PickBackgroundAssetVersionExternalBetaReleases() => BackgroundAssetVersionExternalBetaReleases is { } value
            ? value
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
        public global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease PickBackgroundAssetVersionInternalBetaReleases() => BackgroundAssetVersionInternalBetaReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetVersionInternalBetaReleases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BackgroundAsset? BackgroundAssets { get; init; }
#else
        public global::AppStoreConnect.BackgroundAsset? BackgroundAssets { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackgroundAssets))]
#endif
        public bool IsBackgroundAssets => BackgroundAssets != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBackgroundAssets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BackgroundAsset? value)
        {
            value = BackgroundAssets;
            return IsBackgroundAssets;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BackgroundAsset PickBackgroundAssets() => BackgroundAssets is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssets' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem51(global::AppStoreConnect.BackgroundAssetUploadFile value) => new IncludedItem51((global::AppStoreConnect.BackgroundAssetUploadFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetUploadFile?(IncludedItem51 @this) => @this.BackgroundAssetUploadFiles;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem51(global::AppStoreConnect.BackgroundAssetUploadFile? value)
        {
            BackgroundAssetUploadFiles = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem51 FromBackgroundAssetUploadFiles(global::AppStoreConnect.BackgroundAssetUploadFile? value) => new IncludedItem51(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem51(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease value) => new IncludedItem51((global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease?(IncludedItem51 @this) => @this.BackgroundAssetVersionAppStoreReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem51(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? value)
        {
            BackgroundAssetVersionAppStoreReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem51 FromBackgroundAssetVersionAppStoreReleases(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? value) => new IncludedItem51(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem51(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease value) => new IncludedItem51((global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease?(IncludedItem51 @this) => @this.BackgroundAssetVersionExternalBetaReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem51(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? value)
        {
            BackgroundAssetVersionExternalBetaReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem51 FromBackgroundAssetVersionExternalBetaReleases(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? value) => new IncludedItem51(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem51(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease value) => new IncludedItem51((global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease?(IncludedItem51 @this) => @this.BackgroundAssetVersionInternalBetaReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem51(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? value)
        {
            BackgroundAssetVersionInternalBetaReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem51 FromBackgroundAssetVersionInternalBetaReleases(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? value) => new IncludedItem51(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem51(global::AppStoreConnect.BackgroundAsset value) => new IncludedItem51((global::AppStoreConnect.BackgroundAsset?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAsset?(IncludedItem51 @this) => @this.BackgroundAssets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem51(global::AppStoreConnect.BackgroundAsset? value)
        {
            BackgroundAssets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem51 FromBackgroundAssets(global::AppStoreConnect.BackgroundAsset? value) => new IncludedItem51(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem51(
            global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.BackgroundAssetUploadFile? backgroundAssetUploadFiles,
            global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? backgroundAssetVersionAppStoreReleases,
            global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? backgroundAssetVersionExternalBetaReleases,
            global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? backgroundAssetVersionInternalBetaReleases,
            global::AppStoreConnect.BackgroundAsset? backgroundAssets
            )
        {
            Type = type;

            BackgroundAssetUploadFiles = backgroundAssetUploadFiles;
            BackgroundAssetVersionAppStoreReleases = backgroundAssetVersionAppStoreReleases;
            BackgroundAssetVersionExternalBetaReleases = backgroundAssetVersionExternalBetaReleases;
            BackgroundAssetVersionInternalBetaReleases = backgroundAssetVersionInternalBetaReleases;
            BackgroundAssets = backgroundAssets;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BackgroundAssets as object ??
            BackgroundAssetVersionInternalBetaReleases as object ??
            BackgroundAssetVersionExternalBetaReleases as object ??
            BackgroundAssetVersionAppStoreReleases as object ??
            BackgroundAssetUploadFiles as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BackgroundAssetUploadFiles?.ToString() ??
            BackgroundAssetVersionAppStoreReleases?.ToString() ??
            BackgroundAssetVersionExternalBetaReleases?.ToString() ??
            BackgroundAssetVersionInternalBetaReleases?.ToString() ??
            BackgroundAssets?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBackgroundAssetUploadFiles && !IsBackgroundAssetVersionAppStoreReleases && !IsBackgroundAssetVersionExternalBetaReleases && !IsBackgroundAssetVersionInternalBetaReleases && !IsBackgroundAssets || !IsBackgroundAssetUploadFiles && IsBackgroundAssetVersionAppStoreReleases && !IsBackgroundAssetVersionExternalBetaReleases && !IsBackgroundAssetVersionInternalBetaReleases && !IsBackgroundAssets || !IsBackgroundAssetUploadFiles && !IsBackgroundAssetVersionAppStoreReleases && IsBackgroundAssetVersionExternalBetaReleases && !IsBackgroundAssetVersionInternalBetaReleases && !IsBackgroundAssets || !IsBackgroundAssetUploadFiles && !IsBackgroundAssetVersionAppStoreReleases && !IsBackgroundAssetVersionExternalBetaReleases && IsBackgroundAssetVersionInternalBetaReleases && !IsBackgroundAssets || !IsBackgroundAssetUploadFiles && !IsBackgroundAssetVersionAppStoreReleases && !IsBackgroundAssetVersionExternalBetaReleases && !IsBackgroundAssetVersionInternalBetaReleases && IsBackgroundAssets;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.BackgroundAssetUploadFile, TResult>? backgroundAssetUploadFiles = null,
            global::System.Func<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease, TResult>? backgroundAssetVersionAppStoreReleases = null,
            global::System.Func<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease, TResult>? backgroundAssetVersionExternalBetaReleases = null,
            global::System.Func<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease, TResult>? backgroundAssetVersionInternalBetaReleases = null,
            global::System.Func<global::AppStoreConnect.BackgroundAsset, TResult>? backgroundAssets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BackgroundAssetUploadFiles is { } __value0 && backgroundAssetUploadFiles != null)
            {
                return backgroundAssetUploadFiles(__value0);
            }
            else if (BackgroundAssetVersionAppStoreReleases is { } __value1 && backgroundAssetVersionAppStoreReleases != null)
            {
                return backgroundAssetVersionAppStoreReleases(__value1);
            }
            else if (BackgroundAssetVersionExternalBetaReleases is { } __value2 && backgroundAssetVersionExternalBetaReleases != null)
            {
                return backgroundAssetVersionExternalBetaReleases(__value2);
            }
            else if (BackgroundAssetVersionInternalBetaReleases is { } __value3 && backgroundAssetVersionInternalBetaReleases != null)
            {
                return backgroundAssetVersionInternalBetaReleases(__value3);
            }
            else if (BackgroundAssets is { } __value4 && backgroundAssets != null)
            {
                return backgroundAssets(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.BackgroundAssetUploadFile>? backgroundAssetUploadFiles = null,

            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease>? backgroundAssetVersionAppStoreReleases = null,

            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease>? backgroundAssetVersionExternalBetaReleases = null,

            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease>? backgroundAssetVersionInternalBetaReleases = null,

            global::System.Action<global::AppStoreConnect.BackgroundAsset>? backgroundAssets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BackgroundAssetUploadFiles is { } __value0)
            {
                backgroundAssetUploadFiles?.Invoke(__value0);
            }
            else if (BackgroundAssetVersionAppStoreReleases is { } __value1)
            {
                backgroundAssetVersionAppStoreReleases?.Invoke(__value1);
            }
            else if (BackgroundAssetVersionExternalBetaReleases is { } __value2)
            {
                backgroundAssetVersionExternalBetaReleases?.Invoke(__value2);
            }
            else if (BackgroundAssetVersionInternalBetaReleases is { } __value3)
            {
                backgroundAssetVersionInternalBetaReleases?.Invoke(__value3);
            }
            else if (BackgroundAssets is { } __value4)
            {
                backgroundAssets?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.BackgroundAssetUploadFile>? backgroundAssetUploadFiles = null,
            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease>? backgroundAssetVersionAppStoreReleases = null,
            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease>? backgroundAssetVersionExternalBetaReleases = null,
            global::System.Action<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease>? backgroundAssetVersionInternalBetaReleases = null,
            global::System.Action<global::AppStoreConnect.BackgroundAsset>? backgroundAssets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BackgroundAssetUploadFiles is { } __value0)
            {
                backgroundAssetUploadFiles?.Invoke(__value0);
            }
            else if (BackgroundAssetVersionAppStoreReleases is { } __value1)
            {
                backgroundAssetVersionAppStoreReleases?.Invoke(__value1);
            }
            else if (BackgroundAssetVersionExternalBetaReleases is { } __value2)
            {
                backgroundAssetVersionExternalBetaReleases?.Invoke(__value2);
            }
            else if (BackgroundAssetVersionInternalBetaReleases is { } __value3)
            {
                backgroundAssetVersionInternalBetaReleases?.Invoke(__value3);
            }
            else if (BackgroundAssets is { } __value4)
            {
                backgroundAssets?.Invoke(__value4);
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
                BackgroundAssetVersionAppStoreReleases,
                typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease),
                BackgroundAssetVersionExternalBetaReleases,
                typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease),
                BackgroundAssetVersionInternalBetaReleases,
                typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease),
                BackgroundAssets,
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
        public bool Equals(IncludedItem51 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetUploadFile?>.Default.Equals(BackgroundAssetUploadFiles, other.BackgroundAssetUploadFiles) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease?>.Default.Equals(BackgroundAssetVersionAppStoreReleases, other.BackgroundAssetVersionAppStoreReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease?>.Default.Equals(BackgroundAssetVersionExternalBetaReleases, other.BackgroundAssetVersionExternalBetaReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease?>.Default.Equals(BackgroundAssetVersionInternalBetaReleases, other.BackgroundAssetVersionInternalBetaReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAsset?>.Default.Equals(BackgroundAssets, other.BackgroundAssets)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem51 obj1, IncludedItem51 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem51>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem51 obj1, IncludedItem51 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem51 o && Equals(o);
        }
    }
}
