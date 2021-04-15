using System;

namespace Brimborium.Functional {
    public static class MayBeResult {
        public static MayBeResult<T> AsFuture<T>() {
            return new MayBeResult<T>();
        }
    }
}