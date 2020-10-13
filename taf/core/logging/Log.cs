using log4net;
using log4net.Config;
using mentoring_taf.taf.utils;

namespace mentoring_taf.taf.core.logging
{
    public class Log
    {
        private static ILog LOG = LogManager.GetLogger("LOGGER");

        static Log()
        {
            XmlConfigurator.Configure(new System.IO.FileInfo(PathsUtils.GetSolutionRootPath() + "log4net.config"));
        }

        public static void Info(string s)
        {
            LOG.Info(s);
        }

    }
}
