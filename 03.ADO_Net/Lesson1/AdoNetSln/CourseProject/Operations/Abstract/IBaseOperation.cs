
using CourseProject.Entities.Abstract;
using CourseProject.Helpers.Results.Abstract;

namespace CourseProject.Operations.Abstract
{
    public interface IBaseOperation<T> where T: BaseEntity, new()
    {
        IResult Add(T entity);
        IResult Update(T entity,int id);
        IResult Deleted(int id);
        IDataResult<T> GetById(int id);
        IDataResult<List<T>> GetAll();
    }
}
