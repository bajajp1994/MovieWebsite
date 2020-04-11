using System.Collections.Generic;

namespace Widly.Controllers.API
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}
