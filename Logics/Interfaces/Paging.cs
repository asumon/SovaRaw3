using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovaDataBase
{
    public class Paging
    {
        const int MaxPageSize = 100;
        private int _pageSize = 10;

        public int Page { get; set; }
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                if (value > MaxPageSize) _pageSize = MaxPageSize;
                else _pageSize = value;
            }
        }
    }
}
