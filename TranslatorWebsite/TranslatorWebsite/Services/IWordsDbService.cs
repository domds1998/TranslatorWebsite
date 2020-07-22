using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TranslatorWebsite.DTOs.Requests;
using TranslatorWebsite.Models;

namespace TranslatorWebsite.Services
{
    public interface IWordsDbService
    {
        public IEnumerable<Word> GetWords();

        public Word GetWord(int index);
        
        public void AddWord(AddWordRequest request);

        public void DeleteWord(DeleteWordRequest request);

        public void ModifyWord(ModifyWordRequest request);

    }
}