using Test.Model;

namespace Test.Operation
{
    public abstract class BaseOperation<T> where T : class, new()
    {
        public List<T> Models { get; set; } = new();
        public abstract void Add(T model);
        public abstract void Update(T model);
    }
}
