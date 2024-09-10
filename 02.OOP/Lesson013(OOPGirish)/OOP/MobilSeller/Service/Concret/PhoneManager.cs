using MobilSeller.DataBase;
using MobilSeller.Models;
using MobilSeller.Service.Abstract;

namespace MobilSeller.Service.Concret
{
    public class PhoneManager : IPhoneManager
    {
        public bool AddPhone(Phone phone)
        {
            if (phone is not null)
            {
                DB.Instance.Phones.Add(phone);
                return true;
            }
            else return false;
        }

        public bool DeletedPhone(int id)
        {
            var foundPhone = DB.Instance.Phones.Find(x => x.ID == id);
            if (foundPhone is null)
                return false;

            else
            {
                foundPhone.Deleted = foundPhone.ID;
                return true;
            }
        }

        public List<Phone> GetAll()
        {
           return DB.Instance.Phones;
        }

        public List<Phone> GetAllDeleted()
        {
            return DB.Instance.Phones.Where(x => x.Deleted != 0).ToList();
        }

        public List<Phone> GetAllNonDeleted()
        {
            return DB.Instance.Phones.Where(x => x.Deleted == 0).ToList();
        }
        public bool UpdatePhone(Phone phone, int id)
        {
            var foundPhone = DB.Instance.Phones.Find(x => x.ID == id);

            if (foundPhone is null)
                return false;
            else
            {
                foundPhone.Model = phone.Model;
                foundPhone.Marka = phone.Marka;
                foundPhone.MemmoryCapacity = phone.MemmoryCapacity;
                foundPhone.Price = phone.Price;
                return true;
            }
        }
    }
}
