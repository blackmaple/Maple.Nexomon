
    /// <summary>
    /// ["Assembly-CSharp.dll".""."UploadSaveDataFailureReason"]
    /// </summary>
    public enum UploadSaveDataFailureReason : System.Int32
    { 

        
        Unknown = 0x00000000,

        NoPlatformInterface = 0x00000001,

        NoPlayerDataStorageInterface = 0x00000002,

        NoProductUserID = 0x00000003,

        InvalidProductUserID = 0x00000004,

        SDKWriteRequestFailed = 0x00000005,

        NullSaveData = 0x00000006,

        InvalidWriteHandler = 0x00000007,

    }
