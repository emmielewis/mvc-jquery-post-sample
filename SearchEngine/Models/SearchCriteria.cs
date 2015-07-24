using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SearchEngine.Models
{
    public class SearchCriteria
    {
        [DisplayName("Search")]
        public string SearchString { get; set; }
        public string SearchScope { get; set; }

        public SearchCriteria() { }
        public SearchCriteria(string searchString, string searchScope)
        {
            SearchString = searchString;
            SearchScope = searchScope;
        }
    }
}