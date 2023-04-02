using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetTest.Models
{
    public class ItemRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static ItemRecord NewRecord()
        {
            var rnd = new Random();

            return new ItemRecord
            {
                Id = rnd.Next(),
                Name = "The name",
                Description = "The description"
            };
        }
    }
}