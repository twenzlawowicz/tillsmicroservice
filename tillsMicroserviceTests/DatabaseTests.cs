using NUnit.Framework;
using tillsMicroservice.Controllers;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Given_WhenSimpleValueSaved_WhenRead_ThenSameValueReturend()
        {
            var sut = new InMemoryDB();
            string expected = "1";
            sut.Save("key1", expected);
            string actual = sut.Read("key1");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_WhenSimpleValueInserted_WhenRead_ThenSameValueReturend()
        {
            var sut = new InMemoryDB();
            string expected = "112";
            string key = sut.Insert(expected);
            string actual = sut.Read(key);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_WhenSimpleValuesInserted_WhenGetAmount_ThenNumberOfEntriesReturend()
        {
            var sut = new InMemoryDB();
            string[] values = {"value1", "value2", "value3"};
            foreach (string v in values) {
                sut.Insert(v);
            }

            var expected = 3;
            var actual = sut.Count();
            Assert.AreEqual(expected,actual);
        }
    }
}