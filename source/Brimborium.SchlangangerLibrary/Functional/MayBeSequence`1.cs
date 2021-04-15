using System;
using System.Collections.Generic;

namespace Brimborium.Functional {
#if false
    public static class MayBeSequence {
        public static MayBeSequence<T> AsNone<T>()
            => new MayBeSequence<T>(MayBeMode.None, default, default);

        public static MayBeSequence<T> AsValue<T>(this T value)
            => new MayBeSequence<T>(MayBeMode.Value, value, default);

        public static MayBeSequence<T> AsFailure<T>(this Exception error)
            => new MayBeSequence<T>(MayBeMode.Error, default, error);
    }
    public readonly struct MayBeSequence<T> {
        public readonly IEnumerable<T>? Value;
        public readonly Exception? Error;
        public readonly MayBeMode Mode;

        public static MayBeSequence<T> AsNone()
            => new MayBeSequence<T>(MayBeMode.None, default, default);

        public static MayBeSequence<T> AsValue(IEnumerable<T> value)
            => new MayBeSequence<T>(MayBeMode.Value, value, default);

        public static MayBeSequence<T> AsError(Exception error)
            => new MayBeSequence<T>(MayBeMode.Error, default, error);

        public MayBeSequence(MayBeMode mode = default, IEnumerable<T>? value = default, Exception? error = default) {
            this.Mode = mode;
            this.Value = value;
            this.Error = error;
        }
    }
#endif
    public static class MayBeList {
        public static MayBeList<T> AsNone<T>()
            => new MayBeList<T>(MayBeMode.None, default, default);

        public static MayBeList<T> AsValue<T>(this List<T> value)
            => new MayBeList<T>(MayBeMode.Value, value, default);

        public static MayBeList<T> AsFailure<T>(this Exception error)
            => new MayBeList<T>(MayBeMode.Error, default, error);
    }
    public readonly struct MayBeList<T> {
        public readonly List<T>? Value;
        public readonly Exception? Error;
        public readonly MayBeMode Mode;

        public static MayBeList<T> AsNone()
            => new MayBeList<T>(MayBeMode.None, default, default);

        public static MayBeList<T> AsValue(List<T> value)
            => new MayBeList<T>(MayBeMode.Value, value, default);

        public static MayBeList<T> AsError(Exception error)
            => new MayBeList<T>(MayBeMode.Error, default, error);

        public MayBeList(MayBeMode mode = default, List<T>? value = default, Exception? error = default) {
            this.Mode = mode;
            this.Value = value;
            this.Error = error;
        }
    }
}