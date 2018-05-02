using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FarkleTDDDemo {
    [TestFixture]
    public class FarklerTests {
        [Test]
        public static void test1() {
            Assert.That(Farkler.Score(new List<int> {  }), Is.EqualTo(  ));
        }

    }
}
