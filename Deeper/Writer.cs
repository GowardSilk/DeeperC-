class fileStream
{
    public void Write(string fileName, string objectToWrite)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
        {
            writer.Write(objectToWrite);
        }
    }
    public void Write<T>(string fileName, Triplet<T> objectToWrite) { }
    public void Read(string fileName, ref string objectToRead)
    {
        if (File.Exists(fileName))
        {
            using (var stream = File.Open(fileName, FileMode.Open))
            {
                using (var reader = new BinaryReader(stream, System.Text.Encoding.UTF8, false))
                {
                    objectToRead = reader.ReadString();
                }
            }
        }
    }
};