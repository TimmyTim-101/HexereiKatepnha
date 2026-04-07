using System.Text.Json;
using HexereiKatepnha.Models.Good;

namespace HexereiKatepnha.Services.JsonService;

public class GoodJsonParseService
{
    private string _jsonFilePath;
    private string _jsonString = "{}";
    private int _status = 1;
    private string _errorMessage = "未知错误";

    public GoodJsonParseService(string filePath)
    {
        _jsonFilePath = filePath;
        try
        {
            _jsonString = System.IO.File.ReadAllText(filePath);
            ParseMainProcess();
        }
        catch (Exception e)
        {
            _status = 0;
            _errorMessage = e.Message;
        }
    }

    private void ParseMainProcess()
    {
        try
        {
            ParseJsonStringToObject();
            BuildInnerObject();
            GiveValueToConfigs();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    private void ParseJsonStringToObject()
    {
        try
        {
            GoodModel? thisGoodModel = JsonSerializer.Deserialize<GoodModel>(_jsonString);
            Console.WriteLine(thisGoodModel!.format);
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    private void BuildInnerObject()
    {
    }

    private void GiveValueToConfigs()
    {
    }

    public int GetResult()
    {
        return _status;
    }

    public string GetErrorMessage()
    {
        return _errorMessage;
    }

    public string GetFileName()
    {
        return System.IO.Path.GetFileName(_jsonFilePath);
    }
}