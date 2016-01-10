namespace LinqToExcel.Domain
{
    /// <summary>
    /// Column mapping class
    /// </summary>
    public sealed class ColumnMapping
    {
        /// <summary>
        /// Contructor 
        /// </summary>
        /// <param name="columnName">Column Name</param>
        /// <param name="columMappingType">Column Mapping Type - Default Header</param>
        public ColumnMapping(string columnName, ColumnMappingType columMappingType = ColumnMappingType.Header)
        {
            ColumnName = columnName;
            ColumnMappingType = columMappingType;
        }

        /// <summary>
        /// Name of the excel column to map property
        /// </summary>
        public string ColumnName { get; private set; }

        /// <summary>
        /// Type of excel column to map
        /// </summary>
        public ColumnMappingType ColumnMappingType { get; private set; }
    }
}
