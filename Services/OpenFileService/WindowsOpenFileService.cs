namespace HexereiKatepnha.Services.OpenFileService;

public class WindowsOpenFileService : IOpenFileService
{
    public string? PickJsonFile()
    {
        var openFileDialog = new Microsoft.Win32.OpenFileDialog
        {
            Title = "选择要导入的json配置文件",
            Filter = "Json 文件 (*.json)|*.json|所有文件 (*.*)|*.*",
            Multiselect = false
        };
        if (openFileDialog.ShowDialog() == true)
        {
            return openFileDialog.FileName;
        }

        return null;
    }
}