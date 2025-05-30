namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> SellerList { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            SellerList.Add(seller);
        }

        public void RemoveSeller(Seller seller)
        {
            SellerList.Remove(seller);
        }

        public double AllSales(DateTime initial, DateTime final)
        {
            return
                SellerList.Sum(seller => seller.TotalSales(initial, final));


        }
    }
}
