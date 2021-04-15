using System;

namespace Brimborium.Functional {
    public class MayBeResult<T> {
        private MayBe<T> _Result;

        public MayBeResult() {
            this._Result = new MayBe<T>(MayBeMode.Unspecific, default, default);
        }

        public void SetResult(T value) {
            this._Result = new MayBe<T>(MayBeMode.Value, value, default);
        }

        public void SetError(Exception error) {
            this._Result = new MayBe<T>(MayBeMode.Error, default, error);
        }

        public void SetNone() {
            this._Result = new MayBe<T>(MayBeMode.None, default, default);
        }

        public bool TryGetResult(out MayBe<T> result) {
            result = this._Result;
            return (MayBeMode.Unspecific != this._Result.Mode);
        }
    }
}