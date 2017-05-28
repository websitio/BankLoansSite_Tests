using NUnit.Framework;
using BankingSite.Models;


namespace BankingSiteUnitTests
{
    [TestFixture]
    public class CreditHistoryCheckerTests
    {
        [Test]
        public void ShouldRecognisePeopleWithBadCredit()
        {
            var sut = new CreditHistoryChecker();


            var isCreditWorthy = sut.CheckCreditHistory("Sarah", "Smith");

            Assert.That(isCreditWorthy, Is.False);

        }


        [Test]
        public void ShouldOKPeopleWithGoodCredit()
        {
            var sut = new CreditHistoryChecker();


            var isCreditWorthy = sut.CheckCreditHistory("Tom", "Smith");

            Assert.That(isCreditWorthy, Is.True);

        }



    }
}
