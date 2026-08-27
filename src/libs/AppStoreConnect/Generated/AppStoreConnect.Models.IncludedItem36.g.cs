#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem36 : global::System.IEquatable<IncludedItem36>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalizations1 { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalizations1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatmentLocalizations1))]
#endif
        public bool IsAppStoreVersionExperimentTreatmentLocalizations1 => AppStoreVersionExperimentTreatmentLocalizations1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatmentLocalizations1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value)
        {
            value = AppStoreVersionExperimentTreatmentLocalizations1;
            return IsAppStoreVersionExperimentTreatmentLocalizations1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization PickAppStoreVersionExperimentTreatmentLocalizations1() => IsAppStoreVersionExperimentTreatmentLocalizations1
            ? AppStoreVersionExperimentTreatmentLocalizations1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatmentLocalizations1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperiment? AppStoreVersionExperimentTreatmentLocalizations2 { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperiment? AppStoreVersionExperimentTreatmentLocalizations2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatmentLocalizations2))]
#endif
        public bool IsAppStoreVersionExperimentTreatmentLocalizations2 => AppStoreVersionExperimentTreatmentLocalizations2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatmentLocalizations2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperiment? value)
        {
            value = AppStoreVersionExperimentTreatmentLocalizations2;
            return IsAppStoreVersionExperimentTreatmentLocalizations2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperiment PickAppStoreVersionExperimentTreatmentLocalizations2() => IsAppStoreVersionExperimentTreatmentLocalizations2
            ? AppStoreVersionExperimentTreatmentLocalizations2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatmentLocalizations2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem36(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization value) => new IncludedItem36((global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?(IncludedItem36 @this) => @this.AppStoreVersionExperimentTreatmentLocalizations1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem36(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value)
        {
            AppStoreVersionExperimentTreatmentLocalizations1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem36 FromAppStoreVersionExperimentTreatmentLocalizations1(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value) => new IncludedItem36(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem36(global::AppStoreConnect.AppStoreVersionExperiment value) => new IncludedItem36((global::AppStoreConnect.AppStoreVersionExperiment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperiment?(IncludedItem36 @this) => @this.AppStoreVersionExperimentTreatmentLocalizations2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem36(global::AppStoreConnect.AppStoreVersionExperiment? value)
        {
            AppStoreVersionExperimentTreatmentLocalizations2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem36 FromAppStoreVersionExperimentTreatmentLocalizations2(global::AppStoreConnect.AppStoreVersionExperiment? value) => new IncludedItem36(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem36(
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalizations1,
            global::AppStoreConnect.AppStoreVersionExperiment? appStoreVersionExperimentTreatmentLocalizations2
            )
        {
            Type = type;

            AppStoreVersionExperimentTreatmentLocalizations1 = appStoreVersionExperimentTreatmentLocalizations1;
            AppStoreVersionExperimentTreatmentLocalizations2 = appStoreVersionExperimentTreatmentLocalizations2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersionExperimentTreatmentLocalizations2 as object ??
            AppStoreVersionExperimentTreatmentLocalizations1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppStoreVersionExperimentTreatmentLocalizations1?.ToString() ??
            AppStoreVersionExperimentTreatmentLocalizations2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppStoreVersionExperimentTreatmentLocalizations1 && !IsAppStoreVersionExperimentTreatmentLocalizations2 || !IsAppStoreVersionExperimentTreatmentLocalizations1 && IsAppStoreVersionExperimentTreatmentLocalizations2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization, TResult>? appStoreVersionExperimentTreatmentLocalizations1 = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperiment, TResult>? appStoreVersionExperimentTreatmentLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppStoreVersionExperimentTreatmentLocalizations1 && appStoreVersionExperimentTreatmentLocalizations1 != null)
            {
                return appStoreVersionExperimentTreatmentLocalizations1(AppStoreVersionExperimentTreatmentLocalizations1!);
            }
            else if (IsAppStoreVersionExperimentTreatmentLocalizations2 && appStoreVersionExperimentTreatmentLocalizations2 != null)
            {
                return appStoreVersionExperimentTreatmentLocalizations2(AppStoreVersionExperimentTreatmentLocalizations2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization>? appStoreVersionExperimentTreatmentLocalizations1 = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionExperiment>? appStoreVersionExperimentTreatmentLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppStoreVersionExperimentTreatmentLocalizations1)
            {
                appStoreVersionExperimentTreatmentLocalizations1?.Invoke(AppStoreVersionExperimentTreatmentLocalizations1!);
            }
            else if (IsAppStoreVersionExperimentTreatmentLocalizations2)
            {
                appStoreVersionExperimentTreatmentLocalizations2?.Invoke(AppStoreVersionExperimentTreatmentLocalizations2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization>? appStoreVersionExperimentTreatmentLocalizations1 = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperiment>? appStoreVersionExperimentTreatmentLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppStoreVersionExperimentTreatmentLocalizations1)
            {
                appStoreVersionExperimentTreatmentLocalizations1?.Invoke(AppStoreVersionExperimentTreatmentLocalizations1!);
            }
            else if (IsAppStoreVersionExperimentTreatmentLocalizations2)
            {
                appStoreVersionExperimentTreatmentLocalizations2?.Invoke(AppStoreVersionExperimentTreatmentLocalizations2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppStoreVersionExperimentTreatmentLocalizations1,
                typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization),
                AppStoreVersionExperimentTreatmentLocalizations2,
                typeof(global::AppStoreConnect.AppStoreVersionExperiment),
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
        public bool Equals(IncludedItem36 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?>.Default.Equals(AppStoreVersionExperimentTreatmentLocalizations1, other.AppStoreVersionExperimentTreatmentLocalizations1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperiment?>.Default.Equals(AppStoreVersionExperimentTreatmentLocalizations2, other.AppStoreVersionExperimentTreatmentLocalizations2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem36 obj1, IncludedItem36 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem36>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem36 obj1, IncludedItem36 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem36 o && Equals(o);
        }
    }
}
