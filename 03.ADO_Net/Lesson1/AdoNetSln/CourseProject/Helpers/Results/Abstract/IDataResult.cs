﻿
namespace CourseProject.Helpers.Results.Abstract
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; set; }
    }
}
