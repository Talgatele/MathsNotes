using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Notes.Web.Models.Notepad;
using Notes.Infrastructure;
using System.IO;

namespace Notes.Web.Controllers
{
    public class NotepadController : Controller
    {
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

        //public IEnumerable<Token> Parse(string text)
        //{
        //    StringReader reader = new StringReader(text);
        //    List<Token> tokens = new List<Token>();

        //    while (reader.Peek() != -1)
        //    {
        //        //if whitespace

        //        //if type function sin,cos,etc
        //    }

        //    return tokens;
        //}

        public IActionResult Parse(string inputText)
        {
            StringReader reader = new StringReader(inputText);
            List<Token> tokens = new List<Token>();

            while (reader.Peek() != -1)
            {
                //if whitespace

                //if type function sin,cos,etc
            }

            NotepadVM notepad = new NotepadVM()
            {
                InputText = inputText,
                OutputText = inputText + "addition"
            };

            return View("Index", notepad);
        }
    }
}