using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_Heather_Boden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1 : ControllerBase
    {
        ///<summary>
        ///Gain 50 points for every package delivered
        /// lose 10 points for every collision with an obstacle.
        /// earn a bonus 500 points if the number of packages delivered is greater than the number of collisions with the obstacles. 
        ///  task: determine the final score at the end of a game. 
        /// </summary>
        /// 
        /// <returns>
        /// 
        /// </returns>
        /// 
        /// <example>
        /// 
        /// </example>
        [HttpPost(template: "delivedroid")]
        public int delivedroid([FromForm] int numCollision, [FromForm] int numDelivered)
        {
            //points for delivered package
            int deliveredPoints = 50;
            //loose points for collision with obstacle.
            int collisionPoints = 10;
            //bonus if num packages del. is greater than the collisions. 
            int bonus = 500;


            int deliveries = numDelivered * deliveredPoints;
            int collisions = numCollision * collisionPoints;
            //bool earnBonus = deliveries >= collisions;

            int finalScore = deliveries - collisions;
            if (numDelivered > numCollision)
            {
               finalScore +=  bonus;
            }

            return finalScore;
        }
        // determine final score at the end of a game:
        // use an if statement to calculate if the delivered is >= the collisons. 
        //
    }
}
