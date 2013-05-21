using System.Runtime.InteropServices;

namespace AR.Drone.Client.Packets
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VideoPacket
    {
        public long Timestamp;
        public uint FrameNumber;
        public ushort Height;
        public ushort Width;
        public VideoFrameType FrameType;
        public byte[] Data;
    }
}