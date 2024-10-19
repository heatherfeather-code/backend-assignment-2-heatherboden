using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_Heather_Boden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2 : ControllerBase
    {
        // Question 2022 J1 Cupcake Party

        // givens from the problem:
        // regular box of cupcakes holds 8
        // small box holds 3 cupcakes. 
        //task: there are 28 students, and need at least 28 cupcakes. how many are left over if each student gets one

        /// <summary>
        /// Calculate the number of leftover cupcakes for a class of 28
        /// </summary>
        /// <param name="numRegBox"></param>
        /// <param name="numSmallBox"></param>
        /// <returns>
        /// returns the number of cupcakes leftover from a class party of 28. 
        /// </returns>
        /// <example>
        /// curl -X 'POST' ^
        /// https://localhost:xxx/api/Q2/cupcakeParty' ^
        /// -H 'accept: text/plain' ^
        /// -H 'Content-Type: multipart/form-data' ^
        /// -F 'numRegBox=5' ^
        /// -F 'numSmallBox=4'
        /// </example> 


        [HttpPost(template: "cupcakeParty")]
        public int CupcakeParty ([FromForm] int numRegBox, [FromForm] int numSmallBox)
        {
            //num of cupcakes in regular box
            int cupcakesInRegBox = 8;
            //num of cupcakes in small box
            int cupcakesInSmallBox = 3;
            //class size: number of students.
            int classSize = 28; 

            int totalCupcakes = (numRegBox * cupcakesInRegBox) + (numSmallBox * cupcakesInSmallBox);
            
            
            int leftOverCupcakes = totalCupcakes - classSize;
                      
            return leftOverCupcakes;
        }

    }
}
