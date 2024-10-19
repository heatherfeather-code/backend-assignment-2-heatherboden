using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Assignment2_Heather_Boden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5 : ControllerBase
    {
        //2024 J3 bronze Count
        /// <summary>
        /// Questions asks how many contestants won bronze
        /// </summary>
        /// <returns>
        /// the result of number of contestants that won bronze, outputting the number
        /// </returns>
        /// <example>
        /// https://localhost:xxx/api/Q5/BronzeCount/70%2C68%2C52%2C73
        /// </example>
        [HttpGet(template:"BronzeCount/{participantScores}")]
        public string BronzeCount(string participantScores)
        {
            //modifying question to remove the inital reference for how many contestants. 
            string[] scoreSplit = participantScores.Split(",");

            int highestScore = 0;
            for(int i=0; i < scoreSplit.Length; i++)
            {
                //need to change array elements from string to integer
                int currentScore = int.Parse(scoreSplit[i]);

                if (currentScore > highestScore)
                {
                    highestScore = currentScore;
                }
            }

            int secondScore = 0;
            for(int i=0; i<scoreSplit.Length; i++)
            {
                // need to compare the second highest score to the current score
                int currentScore = int.Parse(scoreSplit[i]);

                if(currentScore > secondScore && currentScore < highestScore)
                {
                    secondScore = currentScore;
                }
            }

            int thirdScore = 0;
            for (int i=0; i < scoreSplit.Length; i++)
            {
                //need to compare the third highest score to the current score
                int currentScore = int.Parse(scoreSplit[i]);

                if(currentScore > thirdScore && currentScore < secondScore)
                {
                    thirdScore = currentScore;
                }
            }

            int numBronze = 0;

            for(int i=0; i < scoreSplit.Length; i++)
            {
                int currentScore = int.Parse(scoreSplit[i]);

                if(currentScore == thirdScore)
                {
                    numBronze++;
                }
            }


            return  thirdScore + " " + numBronze;
        }

    }
}
