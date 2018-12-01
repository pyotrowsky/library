using System;
namespace LibrarySolution
{
    public class ObjGenerator
    {
        private const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const String numbers = "0123456789";
        public ObjGenerator()
        {

        }

        public String generateRandomName()
        {
            Random r = new Random();
            var length = r.Next(25); // Arbitrarily chosen max length
            var chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                var idx = r.Next(characters.Length);
                chars[i] = characters[idx];
            }
            return new string(chars);
        }

        public int generateRandomNumber()
        {
            Random r = new Random();
            var length = r.Next(25); // Arbitrarily chosen max length
            var chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                var idx = r.Next(numbers.Length);
                chars[i] = numbers[idx];
            }

            int.TryParse(new string(chars), out int num);
            return num;
        }
    }
}