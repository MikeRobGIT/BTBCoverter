using System.Globalization;
using BTB.Importer.Models;
using CsvHelper;
using CsvHelper.Configuration;

namespace BTB.Importer
{
    internal static class ResultWriter
    {
        public static void SaveToFile(this List<BTBModel> btbList, string resultDirectoryPath, string resultFilePath)
        {
            if (!Directory.Exists(resultDirectoryPath))
                Directory.CreateDirectory(resultDirectoryPath);

            if (!File.Exists(resultFilePath))
                File.Create(resultFilePath).Dispose();

            using var sw = new StreamWriter(resultFilePath);
            using var cw = new CsvWriter(sw, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                //HasHeaderRecord = false
            });
            cw.WriteRecords(btbList);
        }
    }
}
