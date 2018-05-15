using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logics.Interfaces
{
    public interface ISearchService
    {
          IEnumerable<KeySearch> GetSearchResult(string searchTerm);

    }

}