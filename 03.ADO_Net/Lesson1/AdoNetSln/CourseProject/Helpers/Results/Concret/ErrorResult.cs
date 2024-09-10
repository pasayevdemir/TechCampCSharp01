

namespace CourseProject.Helpers
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {

        }
    }
}
