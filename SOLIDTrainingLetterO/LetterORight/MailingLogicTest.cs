using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LetterORight
{
    [TestFixture]
    public class MailingLogicTest
    {
        [Test]
        public void We_can_supply_email_addresses()
        {
            var emailAddresses = new string[] {"a@b.com", "b@c.com"};

            MailingLogic.Process(emailAddresses, null, null);
        }

    }

    public class MailingLogic
    {
        public static void Process(IEnumerable<string> emailAddresses, Func<string, bool> validator, Action<string> target)
        {
            throw new NotImplementedException();
        }
    }
}
