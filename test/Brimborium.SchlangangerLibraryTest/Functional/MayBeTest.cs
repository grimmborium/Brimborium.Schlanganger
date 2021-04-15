using Xunit;
using Brimborium.Functional;
using System;

namespace Brimborium.Functional {
    public class MayBeTest {
        [Fact]
        public void MayBe_001_Do() {
            int act = 0;
            MayBe<int>.AsValue(42).Do(
                (i) => {
                    Assert.Equal(42, i);
                    act = 1;
                },
                () => act = 2,
                (_) => act = 3);
            Assert.Equal(1, act);
        }

        [Fact]
        public void MayBe_002() {
            var val = MayBe<int>.AsValue(42);
            MayBe<int> act = val.Map(
                (i) => {
                    Assert.Equal(42, i);
                    return MayBe<int>.AsValue(1);
                },
                () => MayBe<int>.AsValue(2),
                (_) => MayBe<int>.AsValue(3));
            Assert.Equal(1, act.Value);
        }

        [Fact]
        public void MayBe_003() {
            var val = MayBeList.AsValue<int>(new int[] { 1, 2, 3, 4 });
        }

    }
}