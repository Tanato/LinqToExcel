namespace LinqToExcel.Domain
{
    /// <summary>
    /// Define who column mapping will reference.
    /// </summary>
    public enum ColumnMappingType
    {
        /// <summary>
        /// Default - Uses column header mapping
        /// </summary>
        Header,

        /// <summary>
        /// Uses Excel column letter to map property
        /// </summary>
        ExcelColumnLetter
    }
}