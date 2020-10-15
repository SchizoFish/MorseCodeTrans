using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class Processor
    {
        public static int Translate(int id, string text, string morse)
        {
            TranslationModel data = new TranslationModel
            {
                Id = id,
                Text = text,
                Morse = morse
            };

            string sql = @"insert into dbo.Translations (Id, Text, Morse) values (@Id, @Text, @Morse)";

            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<TranslationModel> LoadTranslations()
        {
            string sql = @"select Id, Text, Morse from dbo.Translations;";

            return SQLDataAccess.LoadData<TranslationModel>(sql);
        }
    }
}
