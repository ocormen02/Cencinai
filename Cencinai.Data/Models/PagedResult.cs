using System;
using System.Collections.Generic;

namespace Cencinai.Data.Models
{
    public class PagedResult<T> where T : class
    {
        public IList<T> Result { get; set; } = new List<T>();

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public int PageCount { get; set; }

        public int TotalRowCount { get; set; }

        public int FirstRowOnPage => (CurrentPage - 1) * PageSize + 1;

        public int LastRowOnPage => Math.Min(CurrentPage * PageSize, TotalRowCount);
    }
}
