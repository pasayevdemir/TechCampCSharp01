

namespace ProductOfInventory
{
    public class Product
    {
        private string _name = string.Empty; //field
        public string Name//property
        {
            //get => _name; bodied expression
            get { return _name; }
            private set
            {
                if (value != null)//!= ilə 'is not' eyni bir operatordu
                    Console.WriteLine("Value is null which you send");

                else _name = value;
            }
        }


        private double _quantity;//field
        public double Quantity
        {
            get { return _quantity; }

            private set
            {
                if (value < 0)
                    Console.WriteLine("Value is null which you send");

                else
                    _quantity = value;
            }
        }


        private double _price;
        public double Price
        {
            get => _price;
            private set
            {
                if (value < 0)
                    Console.WriteLine("Value is null which you send");
                else
                    _price = value;
            }
        }

        public Product(string name, double quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        ~Product()
        {
            Console.WriteLine("Product is working its destructor ");
        }
    }
}
