using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mentoring_taf.taf.utils
{
    class PathsUtils
    {
        public static String GetSolutionRootPath()
        {
            return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));
        }
    }
}
