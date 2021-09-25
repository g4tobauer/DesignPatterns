namespace DesignPatterns.DesignPatterns.Adapter.Classes.Streams
{
    public class VgaStream
    {
        public byte[] _stream;
        public void SetData(byte[] data)
        {
            _stream = data;
        }
        public byte[] GetData()
        {
            return _stream;
        }
    }
}
