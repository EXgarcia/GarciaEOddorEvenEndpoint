//Elizar Garcia
//10-26-22
//MiniCh#6OddorEven
//In this challenge the console will take in an int and tell the user if it is odd or even.
//Peer Review: Jeremy Lapham: Great program works as intended, I don't know if you need data validation but you can add it 


using Microsoft.AspNetCore.Mvc;

namespace GarciaEOddorEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddController : ControllerBase
{
    [HttpGet]
    [Route("Odd/{numOne}")]

    public string math(string numOne)
    {
        

        
        
        int number1 = Convert.ToInt32(numOne);

        int remainder = number1 % 2;

        if (remainder == 0)
        {
          return (numOne + " is even ");
        
        }else{
            return (numOne + " is odd ");

        }
        

   

    }

}
