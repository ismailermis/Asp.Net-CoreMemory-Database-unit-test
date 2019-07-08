using System;

namespace Customer.Domain
{
    public class Customer : Entity
    {
        public string FullName { get; protected set; }
        public string CityCode { get; protected set; }
        public DateTime BirthDate { get; protected set; }

        public Customer(string fullName, string cityCode, DateTime birthDate)
        {
            if (
                string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(cityCode) ||
                birthDate.Date == DateTime.Today)
            {
                throw new Exception("Geçerli bir müşteri giriniz");
            }

            FullName = fullName;
            CityCode = cityCode;
            BirthDate = birthDate;
        }

        protected Customer()
        {
            
        }

        public void SetFields(string fullName, string cityCode, DateTime birthDate)
        {
            if (string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(cityCode) ||
                birthDate.Date == DateTime.Today)
            {
                throw new Exception("Güncelleme için alanlar geçerli değil.");
            }

            FullName = fullName;
            CityCode = cityCode;
            BirthDate = birthDate;
        }
    }
}
