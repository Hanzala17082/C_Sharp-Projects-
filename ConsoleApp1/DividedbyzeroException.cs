
namespace ConsoleApp1
{
    [Serializable]
    internal class DividedbyzeroException : Exception
    {
        public DividedbyzeroException()
        {
        }

        public DividedbyzeroException(string? message) : base(message)
        {
        }

        public DividedbyzeroException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}