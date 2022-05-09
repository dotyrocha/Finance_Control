
namespace FinanceControl.Domain.Models
{
    public class User : BaseEntity
    {
        public User()
        {

        }
       
        public string Name { get; set; }

        public string Age { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }        
    }
}
