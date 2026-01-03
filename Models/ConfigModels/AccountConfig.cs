using System.Security.Cryptography;
using System.Text;

namespace HexereiKatepnha.Models.ConfigModels;

public class AccountConfig
{
    public string CurrentAccount { get; set; } = "默认账户";
    public List<string> AccountList { get; set; } = ["默认账户"];

    public static Guid CalculateMd5(string input)
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        using (MD5 md5 = MD5.Create())
        {
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            return new Guid(hashBytes);
        }
    }
}