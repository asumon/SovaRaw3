using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess;
using DomainModels;
using Logics;
using Logics.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SovaApi.Models;

namespace SovaApi.Controllers
{
    [Route("api/Search")]
    public class SearchController : Controller
    {
      
        public IMapper mapper { get; set; }
        public ISearchService searchService;



        public SearchController( IMapper mapper, ISearchService searchService)
        {
           
            this.mapper = mapper;
            this.searchService = searchService;
        }

        [HttpGet]
        public IActionResult GetAllSearchResults()
        {
            var searches = searchService.GetSearchResult("what is abs");

           
            return Ok(searches);

        }

      



    }
}
