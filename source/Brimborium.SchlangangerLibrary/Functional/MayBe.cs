using System;

namespace Brimborium.Functional {
    public static class MayBe {
        public static MayBe<T> AsNone<T>()
            => new MayBe<T>(MayBeMode.None, default, default);

        public static MayBe<T> AsFailure<T>(Exception error)
            => new MayBe<T>(MayBeMode.Error, default, error);

        public static MayBe<T> AsValue<T>(this T value)
           => new MayBe<T>(MayBeMode.Value, value, default);

        public static MayBe<T> AsValueOrNone<T>(this T value)
            where T : class
            => new MayBe<T>((value is null) ? MayBeMode.Value : MayBeMode.None, value, default);

        public static MayBe<T> AsError<T>(this Exception error)
            => new MayBe<T>(MayBeMode.Error, default, error);

        public static void Do<T>(this MayBe<T> @this, Action<T> success, Action? none = default, Action<Exception>? failor = default) {
            if (@this.Mode == MayBeMode.Value) {
                success(@this.Value!);
            } else if (@this.Mode == MayBeMode.None) {
                if (none is object) {
                    none();
                }
            } else if (@this.Mode == MayBeMode.Error) {
                if (failor is object) {
                    failor(@this.Error!);
                }
            } else {
                throw new InvalidOperationException();
            }
        }

        public static MayBe<R> Map<T, R>(this MayBe<T> @this, Func<T, MayBe<R>> success, Func<MayBe<R>>? none = default, Func<Exception, MayBe<R>>? failor = default) {
            if (@this.Mode == MayBeMode.Value) {
                return success(@this.Value!);
            } else if (@this.Mode == MayBeMode.None) {
                if (none is object) {
                    return none();
                } else {
                    return MayBe<R>.AsNone();
                }
            } else if (@this.Mode == MayBeMode.Error) {
                if (failor is object) {
                    return failor(@this.Error!);
                } else {
                    return MayBe<R>.AsError(@this.Error!);
                }
            } else {
                throw new InvalidOperationException();
            }
        }

        public static MayBe<R> TryMap<T, R>(this MayBe<T> @this, Func<T, MayBe<R>> success, Func<MayBe<R>>? none = default, Func<Exception, MayBe<R>>? failor = default) {
            if (@this.Mode == MayBeMode.Value) {
                try {
                    return success(@this.Value!);
                } catch (Exception error) {
                    return MayBe<R>.AsError(error);
                }
            } else if (@this.Mode == MayBeMode.None) {
                if (none is object) {
                    return none();
                } else {
                    return MayBe<R>.AsNone();
                }
            } else if (@this.Mode == MayBeMode.Error) {
                if (failor is object) {
                    return failor(@this.Error!);
                } else {
                    return MayBe<R>.AsError(@this.Error!);
                }
            } else {
                throw new InvalidOperationException();
            }
        }
    }
}