namespace homework
{
    static class Ramazan
    {

        public static string RandomElement(int length)
        {
            var random = new System.Random();
            string data = default;

            for (int i = 0; i < length; i++)
            {
                data += random.Next() % 10;
            }

            return data;
        }

    }
}
