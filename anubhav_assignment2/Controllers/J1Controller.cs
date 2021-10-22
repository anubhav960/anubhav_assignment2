using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace anubhav_assignment2.Controllers
{
    /*
     * Problem Description
Here at the Concerned Citizens of Commerce (CCC), we have noted that telemarketers like to use
seven-digit phone numbers where the last four digits have three properties. Looking just at the last
four digits, these properties are:
• the first of these four digits is an 8 or 9;
• the last digit is an 8 or 9;
• the second and third digits are the same.
For example, if the last four digits of the telephone number are 8229, 8338, or 9008, these are
telemarketer numbers.
Write a program to decide if a telephone number is a telemarketer number or not, based on the
last four digits. If the number is not a telemarketer number, we should answer the phone, and
otherwise, we should ignore it.
Input Specification
The input will be 4 lines where each line contains exactly one digit in the range from 0 to 9.
Output Specification
Output either ignore if the number matches the pattern for a telemarketer number; otherwise,
output answer.
     
    /// GET api/J1/Telemarketer/5/6/6/8 --> Answer
    /// GET api/J1/Telemarketer/9/6/6/8 --> Ignore
    */



    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route ("api/J1/Telemarketer/{dig1}/{dig2}/{dig3}/{dig4}")]
        public string Telemarketer( int dig1, int dig2, int dig3, int dig4)
        {
            string telemarketnum = "";
            bool pattern = false;

            if ( (dig1<0) ||(dig2<0) || (dig3<0) || (dig4<0) || (dig1>9) || (dig2>9) || (dig3>9) || (dig4>9))
            {
                telemarketnum = "Enter valid input ranging between 0-9";
            }
            else
            {
                if ((dig1==8 || dig1==9) && (dig4==8 || dig4==9))
                {
                    if (dig2==dig3)
                    {
                        pattern = true;
                    }
                    else
                    {
                        pattern = false;
                    }
                }
                else
                {
                    pattern = false;
                }
                if (pattern)
                {
                    telemarketnum = "Ignore";
                }
                else
                {
                    telemarketnum = "Answer";
                }
            }
            return telemarketnum;
        }
    }
}
