using Microsoft.EntityFrameworkCore;

namespace EF_Database_First;

internal class Program {


    static void Main(string[] args) {
        var _context = new TqlprsdbContext(); 

        var newRequest = from r in _context.Requests
                         join rl in _context.Requestlines
                           on r.Id equals rl.RequestId
                         join p in _context.Products
                           on rl.ProductId equals p.Id
                         join v in _context equals v.Id
                           on p.VendorId equals v.Id 
                         join u in _context.Users
                            on 
                         
        
        var _context = new TqlprsdbContext();

        var newUser = new User {

            Id = 0, Username = "gd", Password = "gd",
            Firstname = "Greg", Lastname = "Doud",
            IsReviewer = true, IsAdmin = true

        };

       _context.Users.Add(newUser);




        var newVendor = new Vendor {

            Id = 0, Code = "MAX", Name = "MAX", Address = "123 Any Street",
            City = "Mason", State = "OH", Zip = "45040"
        };

        _context.Vendors.Add(newVendor);
        _context.SaveChanges();


        var newProduct = new Product {
            Id = 0, PartNbr = "ROLEX", Name = "ROLEX",
            Price = 35000, Unit = "Each", VendorId = 3
        };

        _context.Products.Add(newProduct);
       


        var newRequest = new Request {
            Id = 0, Description = "I need a ROLEX!!!",
            Justification = "Just Because!", DeliveryMode = "Pickup",
            Status = "NEW", Total = 0, UserId = 6

        };

        _context.Requests.Add(newRequest);
        _context.SaveChanges(); 



        


        

    }
}
