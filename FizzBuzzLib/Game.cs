namespace FizzBuzzLib
{
    public class Game
    {
        public string Process(int inputNumber)
        {            
            string? outPutString = inputNumber == 3? "Fizz" : inputNumber.ToString();

            return outPutString;
        }
    }
}