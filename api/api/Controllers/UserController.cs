using api.Context;
using api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private FoodContext _db;
        public UserController(FoodContext db)
        {
            _db = db;
        }

        public int Post(User user)
        {
            try
            {
                _db.Add(user);
                _db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return 1;
        }
    }
}
