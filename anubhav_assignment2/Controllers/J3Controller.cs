using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace anubhav_assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /*
         * Problem Description
You decide to go for a very long drive on a very straight road. Along this road are five cities. As
you travel, you record the distance between each pair of consecutive cities.
You would like to calculate a distance table that indicates the distance between any two of the cities
you have encountered.
Input Specification
The first line contains 4 positive integers less than 1000, each representing the distances between
consecutive pairs of consecutive cities: specifically, the ith integer represents the distance between
city i and city i + 1.
Output Specification
The output should be 5 lines, with the ith line (1 ≤ i ≤ 5) containing the distance from city i to
cities 1, 2, ... 5 in order, separated by one space.
         * 
         
        //GET api/J3/Finaldest/3/10/12/5 --> Ouput:            0 3 13 25 30
                                                               3 0 10 22 27
                                                               13 10 0 12 17
                                                               25 22 12 0 5
                                                               30 27 17 5 0
        */



        [HttpGet]
        [Route("api/J3/Finaldest/{city1}/{city2}/{city3}/{city4}")]
        public int[,] Finaldest(int city1, int city2, int city3, int city4)
        {
            
            int[] dist = new int[] { 0, city1, city2, city3, city4 };
            
            int[,] result = new int[5, 5];
            
            int totaldist = 0;
            
            bool check = true;

            
            for (int i = 0; i < 5; i++)
            {
                if (dist[i] < 0 || dist[i] >= 1000)
                {
                    
                    check = false;
                    result = null;
                    break;
                }
            }

            
            if (check)
            {                
                for (int i = 0; i < 5; i++)
                {                   
                    for (int j = 0; j < 5; j++)
                    {                        
                        if (i == j)
                        {
                            result[i, j] = 0;
                        }                        
                        else if (i < j)
                        {                            
                            for (int k = i + 1; k <= j; k++)
                            {
                                totaldist = totaldist + dist[k];
                            }
                            result[i, j] = totaldist;
                            totaldist = 0;
                        }
                        else
                        {                            
                            result[i, j] = result[j, i];
                        }
                    }
                }
            }            
            return result;
        }
    }
}
