using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TranslatorWebsite.DTOs.Requests;
using TranslatorWebsite.Models;

namespace TranslatorWebsite.Services
{
    public class MsSqlWordsDbService : IWordsDbService
    {
        public IEnumerable<Word> GetWords()
        {
            throw new System.NotImplementedException();
        }

        public Word GetWord(int index)
        {
            throw new System.NotImplementedException();
        }

        public void AddWord(AddWordRequest request)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteWord(DeleteWordRequest request)
        {
            throw new System.NotImplementedException();
        }

        public void ModifyWord(ModifyWordRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}