using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorseCode.Models.ViewModels
{
    [Bind(Prefix = nameof(MorseIndexVM.Result))]
    public class TransResultVM
    {
        [Display(Name = "Morse Tranlsation")]
        public string Result { get; set; }

        public string OriginalText { get; set; }

        public int Id { get; set; }
    }
}
