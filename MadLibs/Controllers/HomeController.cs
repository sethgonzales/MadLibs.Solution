using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    
    [Route("/")]
    public ActionResult MadLibs() { return View(); }
  
    [Route("/results")]
    public ActionResult Results(string name, string noun, string adjective, string verb)
    {

      StoryVariables myStoryVariable = new StoryVariables();

      myStoryVariable.Name = name;
      myStoryVariable.Noun = noun;
      myStoryVariable.Adjective = adjective;
      myStoryVariable.Verb = verb;

      return View(myStoryVariable);
    }
  }
}