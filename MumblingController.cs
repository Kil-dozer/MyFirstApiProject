using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MyFirstApiProject.controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("mumble")]
    public string Mumble(string s)
    {
      // s.toLower()
      // URL = https://localhost:5001/api/mumbling/mumble?s=blah
      s = s.ToLower();
      // index = 0
      var timesToRepeatTheLetter = 1;
      var answerString = "";
      // foreach letter in s
      foreach (var letter in s)
      {
        //.  repeat the letter timesToRepeatTheLetter times
        for (var i = 0; i < timesToRepeatTheLetter; i++)
        {
          if (i == 0)
          {
            answerString += letter.ToString().ToUpper();
          }
          else
          {
            answerString += letter;
          }
        }
        answerString += "-";
        timesToRepeatTheLetter++;
      }
      //.  toTitleCase
      //   add to a list
      //.  index++
      return answerString.TrimEnd('-');
    }
    // return a + b;
    // Test, website returned 4
    // return 3 + 1;
    // https://localhost:5001/api/mumbling/mumble
  }




















}

















