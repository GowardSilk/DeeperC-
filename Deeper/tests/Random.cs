class RandomTest
{
    private static Random random = new Random();
    public string RandomString(int length, string chars)
    {
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    public int RandomInt(int from = 0, int to = 255) 
    {
        return random.Next(from, to);
    }
}
