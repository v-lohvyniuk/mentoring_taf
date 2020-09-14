using mentoring_taf.taf.sut.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.core.readers
{
    class UsersCsvDataSourceReader : CsvDataSourceReader<User>
    {
        public UsersCsvDataSourceReader()
        {
            filePath = "C:\\Users\\volod\\source\\repos\\mentoring_taf\\testdata\\datasource\\users\\datasource-users.csv";
        }

    }
}
