using NUnit.Framework;

using SharpEcho.Recruiting.SpellChecker.Contracts;
using SharpEcho.Recruiting.SpellChecker.Core;

namespace SharpEcho.Recruiting.SpellChecker.Tests
{
    [TestFixture]
    class MnemonicSpellCheckerIBeforeETests
    {
        private ISpellChecker SpellChecker;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            SpellChecker = new MnemonicSpellCheckerIBeforeE();
        }

        [Test]
        public void Check_Word_That_Contains_I_Before_E_Is_Spelled_Correctly()
        {
            // implement this test
            Assert.True(SpellChecker.Check("friend"));
            Assert.True(SpellChecker.Check("believe"));
            Assert.True(SpellChecker.Check("die"));
            Assert.True(SpellChecker.Check("fierce"));
            Assert.True(SpellChecker.Check("collie"));
            Assert.True(SpellChecker.Check("receive"));
            Assert.True(SpellChecker.Check("ceiling"));
            Assert.True(SpellChecker.Check("receipt"));
        }

        [Test]
        public void Check_Word_That_Contains_I_Before_E_Is_Spelled_Incorrectly()
        {
            // implement this test
            Assert.False(SpellChecker.Check("species"));
            Assert.False(SpellChecker.Check("science"));
            Assert.False(SpellChecker.Check("sufficient"));
            Assert.False(SpellChecker.Check("their"));
            Assert.False(SpellChecker.Check("weird"));
            Assert.False(SpellChecker.Check("vein"));
            Assert.False(SpellChecker.Check("feisty"));
            Assert.False(SpellChecker.Check("foreign"));
            Assert.False(SpellChecker.Check("seize"));
            
        }
    }
}
