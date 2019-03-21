using Microsoft.AspNetCore.Mvc;
using Notes.Web.Models.Notepad;

namespace Notes.Web.Controllers
{
    /// <summary>
    /// Controller for the notepad views
    /// </summary>
    public class NotepadController : Controller
    {
        /// <summary>
        /// Default action when the controller is called
        /// Loads the home page with the default text       
        /// </summary>
        /// <returns>View (NotepadVM Model) the webpage to display and content</returns>
        public IActionResult Index()
        {
            string defaultText = "Anything you type into the left hand textarea will appear in the right. \n\n"+
                                "To write an expression, simply enclose in back ticks \n\n" +
                                "`-(b pm sqrt(b^2-4ac))/(2a)` \n\n" +
                                "`sum_(i= 1)^n i^3=((n(n+1))/2)^2` \n\n" +
                                "Logic symbols can also be used, so notes can be written for non mathematical purposes too.\n\n"+                                
                                "`R1: a => b`\n"+
                                "`R2: => notb`\n"+
                                "`R1 > R2` b provable? No.\n\n";

            NotepadVM notepad = new NotepadVM()
            {
                InputText = defaultText,
                OutputText = defaultText
            };

            ViewData["Message"] = "Notepad";

            return View(notepad);
        }

        /// <summary>
        /// Called by site.js on keyup, parses the text from the input text area
        /// Returns the parsed, and translated text to display in the output div
        /// </summary>
        /// <param name="inputText">The text contained in the input textarea</param>
        /// <returns>View(NotepadVM Model) The webpage, and the input and output text to display</returns>
        public IActionResult Parse(string inputText)
        {
            //StringReader reader = new StringReader(inputText);
            //List<Token> tokens = new List<Token>();

            //while (reader.Peek() != -1)
            //{
            //    //if whitespace

            //    //if type function sin,cos,etc
            //}

            NotepadVM notepad = new NotepadVM()
            {
                InputText = inputText,
                OutputText = inputText
            };

            return View("Index", notepad);
        }
    }
}