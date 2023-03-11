using BTB.Importer.Mappings;

namespace BTB.Importer;

internal class Program
{
    //TODO: Do not allow "|" in any of the fields, it will fail to upload on BTB
    public static void Main(string[] args)
    {
        const string resultDirectoryPath = "./Output";
        const string resultFilePath = $"{resultDirectoryPath}/Result.csv";
        const string sourceCsv = "./TestFiles/lodgify_example.csv";

        var btbList = new LodgifyToBTBMapperConfig().Map(sourceCsv);

        btbList.SaveToFile(resultDirectoryPath, resultFilePath);

        Console.WriteLine("COMPLETE!!!");
        Console.ReadLine();
    }
}