using System.Text;

namespace Motel_booking_system.Helpers
{
    internal static class PasswordEncryption
    {
        public static string Encrypt(string input)
        {
            int key = 5;
            char[] inputArray = input.ToCharArray();
            List<int> encryptedCharacters = new List<int>();
            StringBuilder encryptedString = new StringBuilder();

            // use temporary variable to convert each character in the input to integers
            int temp;
            foreach (char inputChar in inputArray)
            {
                temp = (int)inputChar;
                var encryptedChar = temp += key;
                encryptedCharacters.Add(encryptedChar);
            }

            foreach (char encryptedChar in encryptedCharacters)
            {
                encryptedString.Append(encryptedChar);
            }
            return encryptedString.ToString();
        }

        public static string Decrypt(string input)
        {
            int key = 5;
            char[] inputArray = input.ToCharArray();
            List<int> decryptedCharacters = new List<int>();
            StringBuilder decryptedString = new StringBuilder();

            // use temporary variable to convert each character in the input to integers
            int temp;
            foreach (char inputChar in inputArray)
            {
                temp = (int)inputChar;
                var decryptedChar = temp -= key;
                decryptedCharacters.Add(decryptedChar);
            }

            foreach (char encryptedChar in decryptedCharacters)
            {
                decryptedString.Append(encryptedChar);
            }
            return decryptedString.ToString();
        }
    }
}
