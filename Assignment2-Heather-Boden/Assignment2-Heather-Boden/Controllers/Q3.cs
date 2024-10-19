using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_Heather_Boden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3 : ControllerBase
    {
        /// J2 chili peppers 
        /// <summary>
        /// Calculate the total Scoville units within the chili
        /// </summary>
        /// <param name="ingredients"></param>
        /// <returns>
        /// a totaled interger taken from a string. 
        /// </returns>
        /// <example>
        /// https://localhost:xxx/api/Q3/ChiliPeppers/poblano%2Ccayenne%2Cthai%2Cpoblano
        /// </example>
        
        [HttpGet(template: "ChiliPeppers/{ingredients}")]
        public int ChiliPeppers(string ingredients)
        {
            int poblano =  1500;
            int mirasol = 6000;
            int serrano = 15500;
            int cayenne = 40000;
            int thai = 75000;
            int habanero = 125000;

            // 1. "Poblano, Cayenne, Thai, Poblano"
            // 2. ["Poblano", "Cayenne", "Thai", "Poblano"]
            string[] ingredientSplit = ingredients.Split(",");

            int spiciness = 0;

            // for (int i = 0; i < ingredientSplit.Length; i++)
            foreach (string ingredientName in ingredientSplit)
            {
                // string ingredientName = ingredientSplit[i];

                if (ingredientName.ToLower() == "cayenne")
                {
                    spiciness += cayenne;
                }
                else if(ingredientName.ToLower() == "poblano")
                {
                    spiciness += poblano;
                }
                else if (ingredientName.ToLower() == "mirasol")
                {
                    spiciness += mirasol;
                }
                else if (ingredientName.ToLower() == "serrano")
                {
                    spiciness += serrano;
                }
                else if (ingredientName.ToLower() == "thai")
                {
                    spiciness += thai;
                }
                else if (ingredientName.ToLower() == "habanero")
                {
                    spiciness += habanero;
                }
            }

            return spiciness;
                
            

            
        }
    }
}
