using LinqToExcel.Domain;
using System;

namespace LinqToExcel.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class ExcelColumnAttribute : Attribute
    {
        private readonly string _columnName;
        private readonly ColumnMappingType _columnMappingType;

        public ExcelColumnAttribute(string columnName, ColumnMappingType columnMappingType = ColumnMappingType.Header)
        {
            _columnName = columnName;
            _columnMappingType = columnMappingType;
        }

        public string ColumnName
        {
            get { return _columnName; }
        }

        public ColumnMappingType ColumnMappingType
        {
            get { return _columnMappingType; }
        }
    }
}
