using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestAspNetUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        // GET api/values/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public ActionResult Sum(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                decimal sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());

            }
            return BadRequest("Valores inválidos");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public ActionResult Sub(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                decimal sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());

            }
            return BadRequest("Valores inválidos");
        }

        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public ActionResult Mult(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                decimal sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());

            }
            return BadRequest("Valores inválidos");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public ActionResult Div(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                if (ConvertToDecimal(secondNumber) != 0)
                {
                    decimal sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                    return Ok(sum.ToString());
                }

            }
            return BadRequest("Valores inválidos");
        }

        [HttpGet("avg/{firstNumber}/{secondNumber}")]
        public ActionResult Avg(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                decimal sum = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(sum.ToString());


            }
            return BadRequest("Valores inválidos");
        }

        [HttpGet("raiz/{firstNumber}")]
        public ActionResult Raiz(string firstNumber)
        {
            if (isNumeric(firstNumber))
            {
                var resultado = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(resultado.ToString());


            }
            return BadRequest("Valores inválidos");
        }



        private decimal ConvertToDecimal(string firstNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(firstNumber, out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }

        private bool isNumeric(string firstNumber)
        {
            double number;
            bool isNumber = double.TryParse(firstNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;

        }
    }
}
