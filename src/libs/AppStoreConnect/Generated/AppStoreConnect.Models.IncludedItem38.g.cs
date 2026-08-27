#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem38 : global::System.IEquatable<IncludedItem38>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment? AppStoreVersionExperimentTreatments1 { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment? AppStoreVersionExperimentTreatments1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatments1))]
#endif
        public bool IsAppStoreVersionExperimentTreatments1 => AppStoreVersionExperimentTreatments1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatments1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperimentTreatment? value)
        {
            value = AppStoreVersionExperimentTreatments1;
            return IsAppStoreVersionExperimentTreatments1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment PickAppStoreVersionExperimentTreatments1() => IsAppStoreVersionExperimentTreatments1
            ? AppStoreVersionExperimentTreatments1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatments1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersionExperimentTreatments2 { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersionExperimentTreatments2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatments2))]
#endif
        public bool IsAppStoreVersionExperimentTreatments2 => AppStoreVersionExperimentTreatments2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatments2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersion? value)
        {
            value = AppStoreVersionExperimentTreatments2;
            return IsAppStoreVersionExperimentTreatments2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersionExperimentTreatments2() => IsAppStoreVersionExperimentTreatments2
            ? AppStoreVersionExperimentTreatments2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatments2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppStoreVersionExperimentTreatments3 { get; init; }
#else
        public global::AppStoreConnect.App? AppStoreVersionExperimentTreatments3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatments3))]
#endif
        public bool IsAppStoreVersionExperimentTreatments3 => AppStoreVersionExperimentTreatments3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatments3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppStoreVersionExperimentTreatments3;
            return IsAppStoreVersionExperimentTreatments3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickAppStoreVersionExperimentTreatments3() => IsAppStoreVersionExperimentTreatments3
            ? AppStoreVersionExperimentTreatments3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatments3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem38(global::AppStoreConnect.AppStoreVersionExperimentTreatment value) => new IncludedItem38((global::AppStoreConnect.AppStoreVersionExperimentTreatment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentTreatment?(IncludedItem38 @this) => @this.AppStoreVersionExperimentTreatments1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem38(global::AppStoreConnect.AppStoreVersionExperimentTreatment? value)
        {
            AppStoreVersionExperimentTreatments1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem38 FromAppStoreVersionExperimentTreatments1(global::AppStoreConnect.AppStoreVersionExperimentTreatment? value) => new IncludedItem38(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem38(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem38((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem38 @this) => @this.AppStoreVersionExperimentTreatments2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem38(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersionExperimentTreatments2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem38 FromAppStoreVersionExperimentTreatments2(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem38(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem38(global::AppStoreConnect.App value) => new IncludedItem38((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem38 @this) => @this.AppStoreVersionExperimentTreatments3;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem38(global::AppStoreConnect.App? value)
        {
            AppStoreVersionExperimentTreatments3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem38 FromAppStoreVersionExperimentTreatments3(global::AppStoreConnect.App? value) => new IncludedItem38(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem38(
            global::AppStoreConnect.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppStoreVersionExperimentTreatment? appStoreVersionExperimentTreatments1,
            global::AppStoreConnect.AppStoreVersion? appStoreVersionExperimentTreatments2,
            global::AppStoreConnect.App? appStoreVersionExperimentTreatments3
            )
        {
            Type = type;

            AppStoreVersionExperimentTreatments1 = appStoreVersionExperimentTreatments1;
            AppStoreVersionExperimentTreatments2 = appStoreVersionExperimentTreatments2;
            AppStoreVersionExperimentTreatments3 = appStoreVersionExperimentTreatments3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersionExperimentTreatments3 as object ??
            AppStoreVersionExperimentTreatments2 as object ??
            AppStoreVersionExperimentTreatments1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppStoreVersionExperimentTreatments1?.ToString() ??
            AppStoreVersionExperimentTreatments2?.ToString() ??
            AppStoreVersionExperimentTreatments3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppStoreVersionExperimentTreatments1 && !IsAppStoreVersionExperimentTreatments2 && !IsAppStoreVersionExperimentTreatments3 || !IsAppStoreVersionExperimentTreatments1 && IsAppStoreVersionExperimentTreatments2 && !IsAppStoreVersionExperimentTreatments3 || !IsAppStoreVersionExperimentTreatments1 && !IsAppStoreVersionExperimentTreatments2 && IsAppStoreVersionExperimentTreatments3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperimentTreatment, TResult>? appStoreVersionExperimentTreatments1 = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersionExperimentTreatments2 = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appStoreVersionExperimentTreatments3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppStoreVersionExperimentTreatments1 && appStoreVersionExperimentTreatments1 != null)
            {
                return appStoreVersionExperimentTreatments1(AppStoreVersionExperimentTreatments1!);
            }
            else if (IsAppStoreVersionExperimentTreatments2 && appStoreVersionExperimentTreatments2 != null)
            {
                return appStoreVersionExperimentTreatments2(AppStoreVersionExperimentTreatments2!);
            }
            else if (IsAppStoreVersionExperimentTreatments3 && appStoreVersionExperimentTreatments3 != null)
            {
                return appStoreVersionExperimentTreatments3(AppStoreVersionExperimentTreatments3!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatment>? appStoreVersionExperimentTreatments1 = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersionExperimentTreatments2 = null,

            global::System.Action<global::AppStoreConnect.App>? appStoreVersionExperimentTreatments3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppStoreVersionExperimentTreatments1)
            {
                appStoreVersionExperimentTreatments1?.Invoke(AppStoreVersionExperimentTreatments1!);
            }
            else if (IsAppStoreVersionExperimentTreatments2)
            {
                appStoreVersionExperimentTreatments2?.Invoke(AppStoreVersionExperimentTreatments2!);
            }
            else if (IsAppStoreVersionExperimentTreatments3)
            {
                appStoreVersionExperimentTreatments3?.Invoke(AppStoreVersionExperimentTreatments3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatment>? appStoreVersionExperimentTreatments1 = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersionExperimentTreatments2 = null,
            global::System.Action<global::AppStoreConnect.App>? appStoreVersionExperimentTreatments3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppStoreVersionExperimentTreatments1)
            {
                appStoreVersionExperimentTreatments1?.Invoke(AppStoreVersionExperimentTreatments1!);
            }
            else if (IsAppStoreVersionExperimentTreatments2)
            {
                appStoreVersionExperimentTreatments2?.Invoke(AppStoreVersionExperimentTreatments2!);
            }
            else if (IsAppStoreVersionExperimentTreatments3)
            {
                appStoreVersionExperimentTreatments3?.Invoke(AppStoreVersionExperimentTreatments3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppStoreVersionExperimentTreatments1,
                typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment),
                AppStoreVersionExperimentTreatments2,
                typeof(global::AppStoreConnect.AppStoreVersion),
                AppStoreVersionExperimentTreatments3,
                typeof(global::AppStoreConnect.App),
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
        public bool Equals(IncludedItem38 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentTreatment?>.Default.Equals(AppStoreVersionExperimentTreatments1, other.AppStoreVersionExperimentTreatments1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersionExperimentTreatments2, other.AppStoreVersionExperimentTreatments2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppStoreVersionExperimentTreatments3, other.AppStoreVersionExperimentTreatments3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem38 obj1, IncludedItem38 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem38>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem38 obj1, IncludedItem38 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem38 o && Equals(o);
        }
    }
}
