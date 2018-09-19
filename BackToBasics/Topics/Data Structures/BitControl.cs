namespace BackToBasics.Topics.Data_Structures
{
    class BitControl
    {
        public int Or(int firstNumber, int secondNumber)
        {
            return firstNumber | secondNumber;
        }
        public int And(int firstNumber, int secondNumber)
        {
            return firstNumber & secondNumber;
        }
        public int Xor(int firstNumber, int secondNumber)
        {
            return firstNumber ^ secondNumber;
        }
        public int Complement(int number)
        {
            return ~number;
        }
        public int BitwiseLeft(int firstNumber, int secondNumber)
        {
            return firstNumber << secondNumber;
        }
        public int BitwiseRight(int firstNumber, int secondNumber)
        {
            return firstNumber >> secondNumber;
        }

        public void BitOperations()
        {
            //00001110
            //00001011
            //00001111 = 15
            var orResult = Or(14, 11);
            //00001110
            //00001011
            //00001010 = 10
            var andResult = And(14, 11);
            //00001110
            //00001011
            //00000101 = 5
            var xorResult = Xor(14, 11);
            //~00011010 = 11100101 = 229 ---> -27
            var bitwiseComplementResult = Complement(26);
            //42 << 1 = 84(In binary 1010100)
            var bitwiseLeft = BitwiseLeft(42, 1);
            //42 >> 1 = 21(In binary 010101)
            var bitwiseRight = BitwiseRight(42, 1);
        }
    }
}
