using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Notes.Web.Models.Notepad;
using Notes.Infrastructure;
using System.IO;
using System.Diagnostics;

namespace Notes.Web.Controllers
{
    public class NotepadController : Controller
    {
        /// <summary>
        /// Default action when the controller is called
        /// Loads the home page with the default text       
        /// </summary>
        /// <returns>View (NotepadVM Model) the webpage to display and content</returns>
        public IActionResult Index()
        {
            NotepadVM notepad = new NotepadVM()
            {
                InputText = "Anything you type into the left hand textarea will appear in the right.",
                OutputText = "Anything you type into the left hand textarea will appear in the right."
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