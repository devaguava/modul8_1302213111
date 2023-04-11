using System;

public class BankTransferConfig
{
	public string lang { get; set; }
    public TransferConfig Transfer { get; set; }
    public string[] Methods { get; set; }
    public ConfirmationConfig Confirmation { get; set; }

    public class TransferConfig
    {
        public int threshold { get; set; }

        public int low_fee { get; set; }

        public int high_fee { get; set; }
    }

    public class ConfirmationConfig
    {
        public string En { get; set; }
        public string Id { get; set; }

		public ConfirmationConfig() { }

		public ConfirmationConfig(string En, string Id)
		{
			this.En = En;
			this.Id = Id;
		}
    }
}
