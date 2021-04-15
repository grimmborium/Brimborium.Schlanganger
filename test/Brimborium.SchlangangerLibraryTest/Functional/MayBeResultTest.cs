using Xunit;
using Brimborium.Functional;
using System;

namespace Brimborium.Functional {
    public class MayBeResultTest {

        [Fact]
        public void MayBeResult_001_SetResult() {
            var sut = MayBeResult.AsFuture<int>();
            WhatEver(4, 5, sut);
        }

        private void WhatEver(int v1, int v2, MayBeResult<int> result) {
            result.SetResult(v1 + v2);
        }
    }
}