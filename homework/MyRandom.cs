namespace homework
{
    static class MyRandom
    {

        public static System.Random RandomProp { get; set; } = new System.Random();

        public static string RandomString(int length)
        {
            var data = new System.Text.StringBuilder();

            for (int i = 0; i < length; i++)
            {
                data.Append(RandomProp.Next() % 10);
            }

            return data.ToString();
        }

        public static int RandomInteger() => RandomProp.Next();

        public static double RandomDouble() => RandomProp.NextDouble();
    }
}
