using Test.Model;

namespace Test.Operation
{
    public class ProductOperation : BaseOperation<Product>
    {
        public override void Add(Product model)
        {
            Models.Add(model);
        }

        public override void Update(Product model)
        {
            var result = Models.Find(x => x.Id == model.Id);
            if (result != null)
            {
                result.Name = model.Name;
                result.Description = model.Description;
            }
        }

        public void Display(int id)
        {
            var product = Models.Find(x => x.Id == id);
            Console.Clear();
            if (product != null)
            {
                Console.WriteLine("ID: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Description: " + product.Description);
            }
            else
            {
                Console.WriteLine("Tapılmadı");
            }
        }
    }
}
