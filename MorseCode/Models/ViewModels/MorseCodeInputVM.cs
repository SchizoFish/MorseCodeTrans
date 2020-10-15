using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorseCode.Models.ViewModels
{
    [Bind(Prefix = nameof(MorseIndexVM.MorseCodeInput))]
    public class MorseCodeInputVM
    {
        [Required(ErrorMessage = "Please enter the phrase to translate")]
        [Display(Name = "Text to translate")]
        public string TextToTrans { get; set; }
    }
}
