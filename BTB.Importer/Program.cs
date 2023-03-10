using System.Globalization;
using BTB.Importer.Models;
using CsvHelper;
using AutoMapper;
using BTB.Importer.Mappings;


using (var reader = new StreamReader("./TestFiles/lodgify_example.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    csv.Context.RegisterClassMap<LodgifyModelMap>();

    var records = csv.GetRecords<LodgifyModel>().ToList();

    var mapper = LodgifyToBTBMapperConfig.InitializeAutomapper();

    //var btbModel = records.ForEach(x => mapper.Map<BTBModel>(x));
    var btbList = new List<BTBModel>();

    foreach (var item in records)
    {
        var test = mapper.Map<BTBModel>(item);
        btbList.Add(test);
    }

}


Console.ReadLine();
