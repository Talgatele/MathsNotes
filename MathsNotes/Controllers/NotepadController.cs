using MathsNotes.Models.Notepad;
using Microsoft.AspNetCore.Mvc;
using Notes.Web.Models.Notepad;
using System.Collections.Generic;

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
            string defaultText = "Anything you type into the left hand textarea will appear in the right. \n\n" +
                                "To write an expression, simply enclose in back ticks \n\n" +
                                "`-(b pm sqrt(b^2-4ac))/(2a)` \n\n" +
                                "`sum_(i= 1)^n i^3=((n(n+1))/2)^2` \n\n" +
                                "Logic symbols can also be used, so notes can be written for non mathematical purposes too.\n\n" +
                                "`R1: a => b`\n" +
                                "`R2: => notb`\n" +
                                "`R1 > R2` b provable? No.\n\n";

            NotepadVM notepad = new NotepadVM()
            {
                InputText = defaultText,
                OutputText = defaultText,
                SymbolSets = GetSymbolSets()
            };

            ViewData["Message"] = "Notepad";

            return View(notepad);
        }

        private List<SymbolSetsVM> GetSymbolSets()
        {
            var symbolSets = new List<SymbolSetsVM>();

            var ops = new SymbolSetsVM()
            {
                SymbolSetName = "Operation Symbols",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "+" },
                    new SymbolVM() { Symbol = "-" },
                    new SymbolVM() { Symbol = "*" },
                    new SymbolVM() { Symbol = "**" },
                    new SymbolVM() { Symbol = "***" },
                    new SymbolVM() { Symbol = "//" },
                    new SymbolVM() { Symbol = "\\" },
                    new SymbolVM() { Symbol = "xx" },
                    new SymbolVM() { Symbol = "-:" },
                    new SymbolVM() { Symbol = "|><" },
                    new SymbolVM() { Symbol = "><|" },
                    new SymbolVM() { Symbol = "|><|" },
                    new SymbolVM() { Symbol = "@" },
                    new SymbolVM() { Symbol = "o+" },
                    new SymbolVM() { Symbol = "ox" },
                    new SymbolVM() { Symbol = "o." },
                    new SymbolVM() { Symbol = "+" },
                    new SymbolVM() { Symbol = "SUM" },
                    new SymbolVM() { Symbol = "prod" },
                    new SymbolVM() { Symbol = "^^" },
                    new SymbolVM() { Symbol = "^^^" },
                    new SymbolVM() { Symbol = "vv" },
                    new SymbolVM() { Symbol = "vvv" },
                    new SymbolVM() { Symbol = "nn" },
                    new SymbolVM() { Symbol = "nnn" },
                    new SymbolVM() { Symbol = "uu" },
                    new SymbolVM() { Symbol = "uuu" },
                }
            };
            var misc = new SymbolSetsVM()
            {
                SymbolSetName = "Miscellaneous Symbols",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "2/3" },
                    new SymbolVM() { Symbol = "2^3" },
                    new SymbolVM() { Symbol = "sqrt x" },
                    new SymbolVM() { Symbol = "root(3)(x)" },
                    new SymbolVM() { Symbol = "int" },
                    new SymbolVM() { Symbol = "oint" },
                    new SymbolVM() { Symbol = "del" },
                    new SymbolVM() { Symbol = "grad" },
                    new SymbolVM() { Symbol = "+-" },
                    new SymbolVM() { Symbol = "O/" },
                    new SymbolVM() { Symbol = "oo" },
                    new SymbolVM() { Symbol = "aleph" },
                    new SymbolVM() { Symbol = ":." },
                    new SymbolVM() { Symbol = ":'" },
                    new SymbolVM() { Symbol = "|...|" },
                    new SymbolVM() { Symbol = "|cdots|" },
                    new SymbolVM() { Symbol = "vdots" },
                    new SymbolVM() { Symbol = "ddots" },
                    new SymbolVM() { Symbol = "|\\|" },
                    new SymbolVM() { Symbol = "|quad|" },
                    new SymbolVM() { Symbol = "/_" },
                    new SymbolVM() { Symbol = "frown" },
                    new SymbolVM() { Symbol = "/_\\" },
                    new SymbolVM() { Symbol = "diamond" },
                    new SymbolVM() { Symbol = "square" },
                    new SymbolVM() { Symbol = "|__" },
                    new SymbolVM() { Symbol = "__|" },
                    new SymbolVM() { Symbol = "|~" },
                    new SymbolVM() { Symbol = "~|" },
                    new SymbolVM() { Symbol = "CC" },
                    new SymbolVM() { Symbol = "NN" },
                    new SymbolVM() { Symbol = "QQ" },
                    new SymbolVM() { Symbol = "RR" },
                    new SymbolVM() { Symbol = "ZZ" },
                    new SymbolVM() { Symbol = "\"Hello\"" }
                }
            };
            var relation = new SymbolSetsVM()
            {
                SymbolSetName = "Relation Symbols",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "=" },
                    new SymbolVM() { Symbol = "!=" },
                    new SymbolVM() { Symbol = "<" },
                    new SymbolVM() { Symbol = ">" },
                    new SymbolVM() { Symbol = "<=" },
                    new SymbolVM() { Symbol = ">=" },
                    new SymbolVM() { Symbol = "-<" },
                    new SymbolVM() { Symbol = "-<=" },
                    new SymbolVM() { Symbol = ">-" },
                    new SymbolVM() { Symbol = ">-=" },
                    new SymbolVM() { Symbol = "in" },
                    new SymbolVM() { Symbol = "!in" },
                    new SymbolVM() { Symbol = "sub" },
                    new SymbolVM() { Symbol = "sup" },
                    new SymbolVM() { Symbol = "sube" },
                    new SymbolVM() { Symbol = "supe" },
                    new SymbolVM() { Symbol = "-=" },
                    new SymbolVM() { Symbol = "~=" },
                    new SymbolVM() { Symbol = "~~" },
                    new SymbolVM() { Symbol = "prop" }
                }
            };
            var logic = new SymbolSetsVM()
            {
                SymbolSetName = "Logical Symbols",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "and" },
                    new SymbolVM() { Symbol = "or" },
                    new SymbolVM() { Symbol = "not" },
                    new SymbolVM() { Symbol = "=>" },
                    new SymbolVM() { Symbol = "if" },
                    new SymbolVM() { Symbol = "<=>" },
                    new SymbolVM() { Symbol = "AA" },
                    new SymbolVM() { Symbol = "EE" },
                    new SymbolVM() { Symbol = "_|_" },
                    new SymbolVM() { Symbol = "TT" },
                    new SymbolVM() { Symbol = "|--" },
                    new SymbolVM() { Symbol = "|==" }
                }
            };
            var group = new SymbolSetsVM()
            {
                SymbolSetName = "Grouping Brackets",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "(" },
                    new SymbolVM() { Symbol = ")" },
                    new SymbolVM() { Symbol = "[" },
                    new SymbolVM() { Symbol = "]" },
                    new SymbolVM() { Symbol = "{" },
                    new SymbolVM() { Symbol = "}" },
                    new SymbolVM() { Symbol = "(:" },
                    new SymbolVM() { Symbol = ":)" },
                    new SymbolVM() { Symbol = "<<" },
                    new SymbolVM() { Symbol = ">>" },
                    new SymbolVM() { Symbol = "{: x )" },
                    new SymbolVM() { Symbol = "( x :}" },
                    new SymbolVM() { Symbol = "abs(x)" },
                    new SymbolVM() { Symbol = "floor(x)" },
                    new SymbolVM() { Symbol = "ceil(x)" },
                    new SymbolVM() { Symbol = "norm(vecx)" }
                }
            };
            var arrows = new SymbolSetsVM()
            {
                SymbolSetName = "Arrows",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "uarr" },
                    new SymbolVM() { Symbol = "darr" },
                    new SymbolVM() { Symbol = "rarr" },
                    new SymbolVM() { Symbol = "->" },
                    new SymbolVM() { Symbol = ">->" },
                    new SymbolVM() { Symbol = "->>" },
                    new SymbolVM() { Symbol = ">_>>" },
                    new SymbolVM() { Symbol = "|->" },
                    new SymbolVM() { Symbol = "larr" },
                    new SymbolVM() { Symbol = "harr" },
                    new SymbolVM() { Symbol = "rArr" },
                    new SymbolVM() { Symbol = "lArr" },
                    new SymbolVM() { Symbol = "hArr" }
                }
            };
            var accents = new SymbolSetsVM()
            {
                SymbolSetName = "Accents",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "hat x" },
                    new SymbolVM() { Symbol = "bar x" },
                    new SymbolVM() { Symbol = "ul x" },
                    new SymbolVM() { Symbol = "vec x" },
                    new SymbolVM() { Symbol = "dot x" },
                    new SymbolVM() { Symbol = "ddot x" },
                    new SymbolVM() { Symbol = "overset(x)(=)" },
                    new SymbolVM() { Symbol = "underset(x)(=)" },
                    new SymbolVM() { Symbol = "ubrace(1+2)" },
                    new SymbolVM() { Symbol = "obrace(1+2)" },
                    new SymbolVM() { Symbol = "color(red)(x)" },
                    new SymbolVM() { Symbol = "cancel(x)" }
                }
            };
            var greek = new SymbolSetsVM()
            {
                SymbolSetName = "Greek Letters",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "alpha" },
                    new SymbolVM() { Symbol = "beta" },
                    new SymbolVM() { Symbol = "gamma" },
                    new SymbolVM() { Symbol = "Gamma" },
                    new SymbolVM() { Symbol = "delta" },
                    new SymbolVM() { Symbol = "Delta" },
                    new SymbolVM() { Symbol = "epsilon" },
                    new SymbolVM() { Symbol = "varepsilon" },
                    new SymbolVM() { Symbol = "zeta" },
                    new SymbolVM() { Symbol = "eta" },
                    new SymbolVM() { Symbol = "theta" },
                    new SymbolVM() { Symbol = "Theta" },
                    new SymbolVM() { Symbol = "vartheta" },
                    new SymbolVM() { Symbol = "iota" },
                    new SymbolVM() { Symbol = "kappa" },
                    new SymbolVM() { Symbol = "lambda" },
                    new SymbolVM() { Symbol = "Lambda" },
                    new SymbolVM() { Symbol = "mu" },
                    new SymbolVM() { Symbol = "nu" },
                    new SymbolVM() { Symbol = "xi" },
                    new SymbolVM() { Symbol = "Xi" },
                    new SymbolVM() { Symbol = "pi" },
                    new SymbolVM() { Symbol = "Pi" },
                    new SymbolVM() { Symbol = "rho" },
                    new SymbolVM() { Symbol = "sigma" },
                    new SymbolVM() { Symbol = "Sigma" },
                    new SymbolVM() { Symbol = "tau" },
                    new SymbolVM() { Symbol = "upsilon" },
                    new SymbolVM() { Symbol = "phi" },
                    new SymbolVM() { Symbol = "Phi" },
                    new SymbolVM() { Symbol = "varphi" },
                    new SymbolVM() { Symbol = "chi" },
                    new SymbolVM() { Symbol = "psi" },
                    new SymbolVM() { Symbol = "Psi" },
                    new SymbolVM() { Symbol = "omega" },
                    new SymbolVM() { Symbol = "Omega" },
                }
            };
            var font = new SymbolSetsVM()
            {
                SymbolSetName = "Font Commands",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "bb \"AaBbCc\"" },
                    new SymbolVM() { Symbol = "bbb \"AaBbCc\"" },
                    new SymbolVM() { Symbol = "cc \"AaBbCc\"" },
                    new SymbolVM() { Symbol = "tt \"AaBbCc\"" },
                    new SymbolVM() { Symbol = "fr \"AaBbCc\"" },
                    new SymbolVM() { Symbol = "sf \"AaBbCc\"" },
                }
            };
            var funcs = new SymbolSetsVM()
            {
                SymbolSetName = "Example Functions",
                Symbols = new List<SymbolVM>()
                {
                    new SymbolVM() { Symbol = "[[a,b],[c,d]]" },
                    new SymbolVM() { Symbol = "((a),(b))" },
                    new SymbolVM() { Symbol = "{(2x,+,17y,=,23),(x,-,y,=,5):}" },
                    new SymbolVM() { Symbol = "lim_(N->oo) sum_(i=0)^N" },
                    new SymbolVM() { Symbol = "int_0^1 f(x)dx" },
                    new SymbolVM() { Symbol = "f'(x) = dy/dx" },
                    new SymbolVM() { Symbol = "(dq)/(dp)" },
                    new SymbolVM() { Symbol = "ubrace(1+2+3+4)_(\"4 terms\")" },
                    new SymbolVM() { Symbol = "obrace(1+2+3+4)^(\"4 terms\")" }
                }
            };

            symbolSets.Add(ops);
            symbolSets.Add(misc);
            symbolSets.Add(relation);
            symbolSets.Add(logic);
            symbolSets.Add(group);
            symbolSets.Add(arrows);
            symbolSets.Add(accents);
            symbolSets.Add(greek);
            symbolSets.Add(font);
            symbolSets.Add(funcs);

            return symbolSets;
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