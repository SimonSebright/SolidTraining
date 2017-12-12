using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FluentAssertions;
using Xunit;

namespace RightTest
{
    public class MailingLogicTest
    {

        [Fact]
        public void Target_called_for_valid_addresses()
        {
            var emailAddresses = new string[] {"a@b.com", "b@c.com"};
            int count = 0;

            MailingLogic.Process(emailAddresses,
                (em) => true,
                (em) => { count++; });

            count.Should().Be(2);
        }

        [Fact]
        public void Target_not_called_for_invalid_addresses()
        {
            var emailAddresses = new string[] {"a@b.com", "rubbish"};
            int count = 0;

            MailingLogic.Process(emailAddresses,
                (em) => { return em != "rubbish"; },
                (em) => { count++; });

            count.Should().Be(1);
        }

        [Fact]
        public void Real_validator_checks_for_whitespace_and_at()
        {
            MailingLogic.IsValidEmailAddress(null).Should().BeFalse();
            MailingLogic.IsValidEmailAddress(String.Empty).Should().BeFalse();
            MailingLogic.IsValidEmailAddress("\t\r\n").Should().BeFalse();
            MailingLogic.IsValidEmailAddress("This has no at sign, is not email").Should().BeFalse();

            MailingLogic.IsValidEmailAddress("@").Should().BeTrue();
        }

        [Fact]
        public void Line_based_address_reader()
        {
            var contents = 
@"a@b.com
b@c.com";
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(contents)))
            {
                MailingLogic.LineBasedEmailAddresses(ms).ShouldBeEquivalentTo(new string[] {"a@b.com", "b@c.com"});
            }
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

        public static bool IsValidEmailAddress(string email)
        {
            // Obviously this would be a bit better....
            return !String.IsNullOrWhiteSpace(email) && email.Contains("@");
        }

        public static IEnumerable<string> LineBasedEmailAddresses(Stream contents)
        {
            using (StreamReader sr = new StreamReader(contents))
            {
                while (!sr.EndOfStream)
                {
                    yield return sr.ReadLine();
                }
            }
        }
    }
}