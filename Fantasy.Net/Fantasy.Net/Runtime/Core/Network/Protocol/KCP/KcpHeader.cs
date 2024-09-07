namespace Fantasy.Network.KCP
#pragma warning disable CS1591
{
    public enum KcpHeader : byte
    {
        None = 0x00,
        RequestConnection = 0x01,
        WaitConfirmConnection = 0x02,
        ConfirmConnection = 0x03,
        RepeatChannelId = 0x04,
        ReceiveData = 0x06,
        Disconnect = 0x07
    }
}