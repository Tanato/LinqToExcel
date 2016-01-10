using LinqToExcel.Domain;
using System;
using System.Collections.Generic;

namespace LinqToExcel.Query
{
    internal class ExcelQueryConstructorArgs
    {
        internal string FileName { get; set; }
        internal DatabaseEngine DatabaseEngine { get; set; }
        internal Dictionary<string, ColumnMapping> ColumnMappings { get; set; }
        internal Dictionary<string, Func<string, object>> Transformations { get; set; }
        internal StrictMappingType? StrictMapping { get; set; }
		internal bool UsePersistentConnection { get; set; }
        internal TrimSpacesType TrimSpaces { get; set; }
        internal bool ReadOnly { get; set; }
    }
}
