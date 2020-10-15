using MorseCode.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using static DataLibrary.Logic.Processor;

namespace MorseCode.Models
{
    public class MorseService
    {
        static List<Value> transStrings = new List<Value>();
        MorseChars newChars = new MorseChars();

        internal void TextToMorse(MorseCodeInputVM input)
        {
            StringBuilder stringCode = new StringBuilder(280);

            if (!string.IsNullOrEmpty(input.ToString()))
            {
                string inpChars = input.TextToTrans.ToUpper();
                if (inpChars.Contains(".") || inpChars.Contains("-"))
                {

                }
                else
                {
                    foreach (char c in inpChars)
                    {
                        if (newChars.Characters.ContainsKey(c))
                        {
                            stringCode.Append(newChars.Characters[c] + "   ");
                        }
                        else if (c == ' ')
                        {
                            stringCode.Append(" | ");
                        }
                    }
                }
            }         

            transStrings.Add(new Value
            {
                Id = transStrings.Count + 1,
                Morse = stringCode.ToString(),
                Text = input.TextToTrans
            });

            //SqlService.SaveTranslation(input.TextToTrans, stringCode.ToString());    //FIX STORED PROCEDURE
            //Translate(transStrings.Count + 1, input.TextToTrans, stringCode.ToString());
        }

        public MorseIndexVM ShowResult()
        {
            MorseIndexVM newIndex = new MorseIndexVM
            {
                
                Result = transStrings
                .Select(m => new TransResultVM
                {
                    Result = m.Morse,
                    OriginalText = m.Text,
                    Id = m.Id
                })
                .OrderByDescending(m => m.Id)
                .ToArray()
            };

            return newIndex;
        }

    }
}
