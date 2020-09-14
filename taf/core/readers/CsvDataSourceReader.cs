using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace mentoring_taf.taf.core.readers
{
    class CsvDataSourceReader<T>
    {
        protected String filePath { get; set; }

        public List<T> ReadAll()
        {
            List<T> records;

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<T>().ToList();
            }
            return records;
        }
    }
}
