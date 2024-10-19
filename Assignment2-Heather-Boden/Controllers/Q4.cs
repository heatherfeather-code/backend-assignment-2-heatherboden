using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_Heather_Boden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4 : ControllerBase
    {
        //Question Selected : 2015 J2 Happy or Sad
        /// <summary>
        /// asseses the emoticon within a message and determines if the user is expressing, happy, sad or none. 
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        /// <example>
        /// 
        /// </example>
        [HttpGet(template:"HappySad/{textMessage}")]
        public string HappySad(string textMessage)
        {
            string happy = ":-)";
            string sad = ":-(";

            int happyCount = 0;
            int sadCount = 0;

            happyCount=textMessage.Split(happy).Length - 1;
            sadCount = textMessage.Split(sad).Length - 1;

            //none
            if (happyCount == 0 && sadCount == 0)
            {
                return "none";
            }
            //equal amount of happy & sad:
            else if (happyCount == sadCount)
            {
                return "unsure";
            }

            //happy < no. of sad
            else if(happyCount > sadCount)
            {
                return "happy";
            }
            //no of sad < no. of happy
            else if(happyCount < sadCount) 
            {
                return "sad";
            }
            return "none";
        }
    }
}
