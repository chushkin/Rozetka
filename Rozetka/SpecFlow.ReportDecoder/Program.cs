using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SpecFlow.ReportDecoder
{
    class Program
    {
        static int Main(string[] args)
        {
            var fileName = "SpecFlowExecutionReport.html";
            if (args.Length > 0)
            {
                fileName = args[0];
            }

            if (!File.Exists(fileName)) return 1;

            var regex = new Regex(@"\\x[A-Z0-9a-z]{4}");
            string content;
            using (var sr = new StreamReader(fileName))
            {
                content = sr.ReadToEnd();
                sr.Close();
                var matches = regex.Matches(content);
                foreach (Match match in matches)
                {
                    content = content.Replace(match.Value,
                                    new string(new[] {(char) Convert.ToUInt32(match.Value.Replace('\\', '0'), 16)}));
                }
            }

            using (var sr = new StreamWriter(fileName))
            {
                sr.Write(content);
                sr.Close();
            }

            return 0;
        }
    }
}
