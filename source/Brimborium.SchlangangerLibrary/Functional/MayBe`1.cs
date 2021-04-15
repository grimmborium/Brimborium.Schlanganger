using System;

namespace Brimborium.Functional {
    public readonly struct MayBe<T> {
        public readonly T? Value;
        public readonly Exception? Error;
        public readonly MayBeMode Mode;

        public static MayBe<T> AsNone()
            => new MayBe<T>(MayBeMode.None, default, default);

        public static MayBe<T> AsValue(T value)
            => new MayBe<T>(MayBeMode.Value, value, default);

        public static MayBe<T> AsError(Exception error)
            => new MayBe<T>(MayBeMode.Error, default, error);

        public MayBe(MayBeMode mode = default, T? value = default, Exception? error = default) {
            this.Mode = mode;
            this.Value = value;
            this.Error = error;
        }

        //#pragma warning disable RCS1163 // Unused parameter.
        //        public static implicit operator MayBe<T>(None none) => new MayBe<T>(MayBeMode.None, default, default);
        //#pragma warning restore RCS1163 // Unused parameter.
        //        public static implicit operator MayBe<T>(T value) => new MayBe<T>(MayBeMode.Value, value, default);
        //        public static implicit operator MayBe<T>(Exception error) => new MayBe<T>(MayBeMode.Error, default, error);
    }
}