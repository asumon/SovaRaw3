using DomainModels;
using Logics.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SovaDataBase
{
    public class SearchService : ISearchService
    {
        public IEnumerable<KeySearch> GetSearchResult(string searchTerm)
        {
           using ( var db = new SovaDbContext())
            {

                return db.KeySearch.FromSql("call keysearch({0})", searchTerm).ToList();
            } 
        }




        }
    }

