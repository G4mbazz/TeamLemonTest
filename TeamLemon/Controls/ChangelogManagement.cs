using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TeamLemon.Controls
{
    internal class ChangelogManagement
    {
        public static List<string> Lines = new List<string>();
        public static async Task WriteChangelogAsync()
        {
            // Get the path to write the changelog
            // Using DateTime to get the currrent Month-Day-Year_Hour-Minute-Second
            // To add in the filename for easier readability
            string path = Path.Combine(@"../../../Changelogs\log-" + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss") + ".txt");
            await File.WriteAllLinesAsync(path, Lines);
        }

        public static void AppendToChangelog(string StringToAppend)
        {
            Lines.Add(StringToAppend);
        }
    }
}
