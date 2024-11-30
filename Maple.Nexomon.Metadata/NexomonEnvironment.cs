namespace Maple.Nexomon.Metadata
{
    public partial class NexomonEnvironment(NexomonMetadataContext context)
    {


        public NexomonMetadataContext Context { get; } = context;
        public DatabaseItems DatabaseItems => Context.DatabaseItems;
        public DatabaseMonsters DatabaseMonsters => Context.DatabaseMonsters;

        public SaveData.Ptr_SaveData Ptr_SaveData { get; } = context.SaveData.CURRENT;
        public Inventory.Ptr_Inventory Ptr_Inventory => Ptr_SaveData.INVENTORY;
        public Equipment.Ptr_Equipment Ptr_Equipment => Ptr_SaveData.EQUIPMENT;
        public Wallet.Ptr_Wallet Ptr_Wallet => Ptr_SaveData.WALLET;


        public bool InGame()
        {
            return this.Ptr_SaveData && SaveData.Ptr_SaveData.DOES_SAVE_DATA_EXIST(this.Ptr_SaveData.SLOT_NUMBER);
        }

        public bool WaitGameData()
        {
            return SpinWait.SpinUntil(() => this.DatabaseItems.DATA.Valid() && this.DatabaseMonsters.DATA.Valid(), TimeSpan.FromSeconds(15L));
        }
    }
}
