using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstApiProject.controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("explode")]
    public string Explode(string s)
    {
      // Insert your solution here
      // split string into numbers
      var answerString = "";
      s = s.ToString();
      foreach (var letter in s)
      {
        var number = int.Parse(letter.ToString());
        // find the value of each number
        // duplicate the number value times
        for (var i = 0; i < number; i++)
        {
          answerString += letter;
        }
      }
      // return a copy of the numbers duplicated
      return answerString;
    }
  }
  // https://localhost:5001/api/explosion/explode?s=875322





















}

