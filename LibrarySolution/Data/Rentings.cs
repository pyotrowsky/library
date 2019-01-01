using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySolution
{
    public class Renting
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int itemId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Renting(int userId, int itemId)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.startDate = new DateTime();
        }
    }
}
