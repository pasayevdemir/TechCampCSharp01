using CourseProject.Helpers.Results.Abstract;

namespace CourseProject.Helpers
{
    public class Result : IResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public Result(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}
