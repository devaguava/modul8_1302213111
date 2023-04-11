class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();

        if (config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
        }
        else if (config.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di transfer:");
        }

        int transferAmount = int.Parse(Console.ReadLine());

        int transferFee = transferAmount <= config.Transfer.threshold ? config.Transfer.low_fee : config.Transfer.high_fee;
        int totalAmount = transferAmount + transferFee;

        Console.WriteLine(config.lang == "en" ? $"Transfer fee = {transferFee}" : $"Biaya transfer = {transferFee}");
        Console.WriteLine(config.lang == "en" ? $"Total amount = {totalAmount}" : $"Total biaya = {totalAmount}");

        for (int i = 0; i < config.Methods.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {config.Methods[i]}");
        }

        Console.WriteLine(config.lang == "en" ? $"Please type \"{config.Confirmation.En}\" to confirm the transaction:" : $"Ketik \"{config.Confirmation.Id}\" untuk mengkonfirmasi transaksi:");

        string confirmation = Console.ReadLine();

        if (confirmation == (config.lang == "en" ? config.Confirmation.En : config.Confirmation.Id))
        {
            Console.WriteLine(config.lang == "en" ? "The transfer is cancelled" : "Proses transfer berhasil");
        }
    }
}