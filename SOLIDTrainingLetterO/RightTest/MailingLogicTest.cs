using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace RightTest
{
    public class MailingLogicTest
    {
        [Fact]
        public void Email_address_is_validated()
        {
            var emailAddresses = new string[] { "a@b.com", "rubbish" };
            int count = 0;

            MailingLogic.Process(emailAddresses,
                (em) => { return em != "rubbish"; },
                (em) => { count++; });

            count.Should().Be(1);
        }

        [Fact]
        public void Target_called_for_valid_addresses()
        {
            var emailAddresses = new string[] { "a@b.com", "b@c.com" };
            int count = 0;

            MailingLogic.Process(emailAddresses,
                (em) => true,
                (em) => { count++; });

            count.Should().Be(2);
        }
    }


    public static class MailingLogic
    {
        public static void Process(IEnumerable<string> emailAddresses, Func<string, bool> validator,
            Action<string> target)
        {
            var validAddresses = emailAddresses.Where(validator);
            foreach (var validAddress in validAddresses)
            {
                target(validAddress);
            }
        }
    }
}