using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace anubhav_assignment2.Controllers
{

    public class J2Controller : ApiController
    {
        /*
         Problem Description
You supervise a small parking lot which has N parking spaces.
Yesterday, you recorded which parking spaces were occupied by cars and which were empty.
Today, you recorded the same information.
How many of the parking spaces were occupied both yesterday and today?
Input Specification
The first line of input contains the integer N (1 ≤ N ≤ 100). The second and third lines of input
contain N characters each. The second line of input records the information about yesterday’s
parking spaces, and the third line of input records the information about today’s parking spaces.
Each of these 2N characters will either be C to indicate an occupied space or . to indicate it was
an empty parking space.
Output Specification
Output the number of parking spaces which were occupied yesterday and today
         
         Each of the string should only have "E" or "C".
        Here "E" = Parking space are empty and "C" = Parking space are occupied,
        <example>
        ///GET api/J2/OccupyParking/5/CCEEC/ECCEE ---> Number of occupied places today and tomorrow are 1.
        ///GET api/J2/OccupyParking/7/CCCCCCC/CECECEC ---> Number of occupied places today and tomorrow are 4.
        */



        [HttpGet]
        [Route("api/J2/OccupyParking/{numPark}/{yesterdayPark}/{todayPark}")]
        public string OccupyParking(int numPark, string yesterdayPark, string todayPark)
        {
            string answer = " ";
            int occupy = 0; 
            string yesterdayTemp = yesterdayPark.ToUpper();
            string todayTemp = todayPark.ToUpper();
            char[] yestchars = yesterdayTemp.ToCharArray();
            char[] todaychars = todayTemp.ToCharArray();
            if (numPark < 1 || numPark > 100)
            {
                answer = "Please enter the number of parking spaces in the range of 1-100.";
            }      
            else
            {               
                if ((yesterdayPark.Length == numPark) && (todayPark.Length == numPark))
                {                   
                    for (int i = 0; i < numPark; i++)
                    {                        
                        if ((yestchars[i] == 'C' || yestchars[i] == 'E') && (todaychars[i] == 'C' || todaychars[i] == 'E'))
                        {                            
                            if ((yestchars[i] == todaychars[i]) && (yestchars[i] == 'C'))
                            {                                
                                occupy = occupy + 1;
                            }
                        }                        
                        else
                        {                            
                            answer = "Please Enter 'C' or 'E'";
                            break;
                        }
                    }
                }               
                else
                {
                    answer = "One of the string doesnt have " + numPark + " characters.";
                }
            }
            
            if (occupy > 0)
            {
                answer = "Number of occupied places today and tomorrow are " + occupy;
            }
            return answer;
        }
    }
}

