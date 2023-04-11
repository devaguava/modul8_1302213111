using System;
using System.Text.Json;
public class AppConfig
{
	public BankTransferConfig bankTransferConfig;

	public const string filePath = @"bank_transfer_config.json";

    public AppConfig()
    {
        try
        {
            ReadConfigFile();
        }
        catch
        {
            SetDefault();
            WriteNewConfigFile();
        }
    }

    private BankTransferConfig ReadConfigFile()
    {
        string configJsonData = File.ReadAllText(filePath);
        bankTransferConfig = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
        return bankTransferConfig;
    }

    private void SetDefault()
    {
      
    }

    private void WriteNewConfigFile()
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(bankTransferConfig, options);
        File.WriteAllText(filePath, jsonString);
    }
}
