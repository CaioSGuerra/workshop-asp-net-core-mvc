using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecords.Any())
            {
                return; //DB has been seeded
            }

            Department department1 = new Department(1, "Computers");
            Department department2 = new Department(2, "Eletronics");
            Department department3 = new Department(3, "Fashion");
            Department department4 = new Department(4, "Books");

            Seller seller1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, department1);
            Seller seller2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, department2);
            Seller seller3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, department1);
            Seller seller4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, department4);
            Seller seller5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, department3);
            Seller seller6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, department2);

            SalesRecord salesRecord1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, seller1);
            SalesRecord salesRecord2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, seller5);
            SalesRecord salesRecord3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, seller4);
            SalesRecord salesRecord4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, seller1);
            SalesRecord salesRecord5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, seller3);
            SalesRecord salesRecord6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, seller1);
            SalesRecord salesRecord7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, seller2);
            SalesRecord salesRecord8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, seller4);
            SalesRecord salesRecord9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, seller6);
            SalesRecord salesRecord10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, seller6);
            SalesRecord salesRecord11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, seller2);
            SalesRecord salesRecord12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, seller3);
            SalesRecord salesRecord13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, seller4);
            SalesRecord salesRecord14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, seller5);
            SalesRecord salesRecord15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, seller1);
            SalesRecord salesRecord16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, seller4);
            SalesRecord salesRecord17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, seller1);
            SalesRecord salesRecord18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, seller3);
            SalesRecord salesRecord19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, seller5);
            SalesRecord salesRecord20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, seller6);
            SalesRecord salesRecord21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, seller2);
            SalesRecord salesRecord22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, seller4);
            SalesRecord salesRecord23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, seller2);
            SalesRecord salesRecord24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, seller5);
            SalesRecord salesRecord25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, seller3);
            SalesRecord salesRecord26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, seller4);
            SalesRecord salesRecord27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, seller1);
            SalesRecord salesRecord28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, seller3);
            SalesRecord salesRecord29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, seller5);
            SalesRecord salesRecord30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, seller2);

            _context.Department.AddRange(department1, department2, department3, department4);

            _context.Seller.AddRange(seller1, seller2, seller3, seller4, seller5, seller6);

            _context.SalesRecords.AddRange(
                salesRecord1, salesRecord2, salesRecord3, salesRecord4, salesRecord5, salesRecord6, salesRecord7, salesRecord8, salesRecord9, salesRecord10,
                salesRecord11, salesRecord12, salesRecord13, salesRecord14, salesRecord15, salesRecord16, salesRecord17, salesRecord18, salesRecord19, salesRecord20,
                salesRecord21, salesRecord22, salesRecord23, salesRecord24, salesRecord25, salesRecord26, salesRecord27, salesRecord28, salesRecord29, salesRecord30
            );

            _context.SaveChanges();
        }
    }
}
