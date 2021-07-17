namespace SampleApiNet5.Controllers
{
    public class MembersController : ApiController
    {
        Member[] members = new Member[]
        {
            new Member { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Member { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Member { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Member> GetAllProducts()
        {
            return members;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var member = members.FirstOrDefault((p) => p.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }
    }
}