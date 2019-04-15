using System;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;


public partial class ReadJson
{
    [JsonProperty("items")]
    public Item[] Items { get; set; }
}

public partial class Item
{
    [JsonProperty("url")]
    public Uri Url { get; set; }

    [JsonProperty("item_xpath", NullValueHandling = NullValueHandling.Ignore)]
    public string ItemXpath { get; set; }

    [JsonProperty("item_size")]
    public string ItemSize { get; set; }
}

public partial class ReadJson
{
    public static ReadJson FromJson(string json) { return JsonConvert.DeserializeObject<ReadJson>(json, Converter.Settings); }
}

public static class Serialize
{
    public static string ToJson(this ReadJson self) { return JsonConvert.SerializeObject(self, Converter.Settings); }
}

internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
}

class UseJsonInVar
{
    public static void Test()
    {
        string filepath = "Question__55692935.json";

        File.WriteAllText(filepath, GetJson());

        StreamReader ddd = new StreamReader(filepath);
        var json = ddd.ReadToEnd();
        //DataJson objectJson = JsonConvert.DeserializeObject<DataJson>(json);

        //url = objectJson.ReadJson[0].url;
        //user = objectJson.ReadJson[0].item_xpath;
        //pass = objectJson.ReadJson[0].item_size;

        var objectJson = JsonConvert.DeserializeObject<ReadJson>(json);
        var url = objectJson.Items[0].Url;
        var user = objectJson.Items[0].ItemXpath;
        var pass = objectJson.Items[0].ItemSize;

        Console.WriteLine("url = {0}\nuser = {1}\npass = {2}", url, user, pass);
    }

    static string GetJson()
    {
        var json = @"{
""items"":[
{
""url"":""https://www.nordstromrack.com/shop/Women/Clothing/Activewear/Jackets%20&%20Hoodies"",
""item_xpath"":""//*[@href='/shop/product/2299794/nike-vintage-drawstring-hoodie?color=BLACK%2FSAIL']"",
""item_size"":""//*[@href='?color=TRUBER%2FSAIL&size=L']""
},
{
""url"":""https://www.nordstromrack.com/events/281375/products/2584102/j-crew-cotton-cardigan?color=BLACK"",
""item_xpath"":""//*[@href='/events/281375/products/2584102/j-crew-cotton-cardigan?color=BLACK']"",
""item_size"":""//*[@href='?color=BLACK&size=M']""
}
]
}
";
        return json;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Environment version: " + Environment.Version);
        Console.WriteLine("Json.NET version: " + typeof(JsonSerializer).Assembly.FullName);
        Console.WriteLine();

        try
        {
            UseJsonInVar.Test();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed with unhandled exception: ");
            Console.WriteLine(ex);
            throw;
        }
    }
}
