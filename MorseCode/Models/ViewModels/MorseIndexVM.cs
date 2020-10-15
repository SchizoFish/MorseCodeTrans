using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorseCode.Models.ViewModels
{
    public class MorseIndexVM
    {        
        public MorseCodeInputVM MorseCodeInput { get; set; }
        public TransResultVM[] Result { get; set; }
    }
}
