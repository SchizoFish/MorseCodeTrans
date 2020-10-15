using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MorseCode.Models;
using MorseCode.Models.ViewModels;
using DataLibrary;
using static DataLibrary.Logic.Processor;

namespace MorseCode.Controllers
{
    public class MorseCodeController : Controller
    {
        private readonly MorseService service;

        public MorseCodeController(MorseService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("morsecode/translate")]
        [Route("")]
        public IActionResult Translate(MorseCodeInputVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            service.TextToMorse(vm);

            return RedirectToAction(nameof(Translate));
        }

        [HttpGet]
        [Route("morsecode/translate")]
        [Route("")]
        public IActionResult Translate()
        {
            return View(service.ShowResult());
        }

    }
}