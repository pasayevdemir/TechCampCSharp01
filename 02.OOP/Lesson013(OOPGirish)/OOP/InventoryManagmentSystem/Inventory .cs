using ProductOfInventory;
using System.Collections;

namespace InventoryManagmentSystem
{
    public class Inventory
    {
        ArrayList products = new();
        public string AddProduct(Product addModel)
        {
            if (addModel is null)
                return "Not added";

            products.Add(addModel);
            return "Added";
        }

        public string RomoveProduct(Product deleteModel)
        {
            if (deleteModel is null)
                return "Not removed";

            products.Remove(deleteModel);
            return "Removed";
        }

        public void GetProductInfo(int index, out Product outProduct)
        {
            outProduct = null;
            if (products.Count < index)
                Console.WriteLine("invalid index");
            else
            {
                outProduct = (Product)products[index];
                Console.WriteLine(outProduct.Name);
                Console.WriteLine(outProduct.Quantity);
                Console.WriteLine(outProduct.Price);
            }
        }

        public void UpdateProductQuantity(int index, ref double quantity)
        {
            if (products.Count < index && index >= 0)
                Console.WriteLine("invalid index");
            else
            {
                Product findProduct = (Product)products[index];
                products[index] = new Product(findProduct.Name, quantity, findProduct.Price);
            }
        }

        public Product this[int index]
        {
            get
            {
                if (products.Count < index && index >= 0)
                {
                    Console.WriteLine("invalid index");
                    return null;
                }
                else
                    return (Product)products[index];
            }
            set
            {
                products.Insert(index, value);
            }
        }
    }
}
