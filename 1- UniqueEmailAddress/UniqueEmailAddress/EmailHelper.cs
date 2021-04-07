using System;
using System.Collections.Generic;
using System.Text;

namespace UniqueEmailAddress
{
    public class EmailHelper
    {
        public EmailHelper()
        {

        }
        //simple way
        public int NumberOfUniqueEmailAddresses(string[] emails)
        {
            if (emails == null || emails.Length == 0)
            {
                return 0;
            }
            HashSet<string> uniqueEmailAddresses = new HashSet<string>();
            foreach (string email in emails)
            {
                var split = email.Split("@");
                var transform = split[0].Replace(".", "").Split("+")[0];
                uniqueEmailAddresses.Add(transform + "@" + split[1]);
            }

            return uniqueEmailAddresses.Count;
        }
    }
}
