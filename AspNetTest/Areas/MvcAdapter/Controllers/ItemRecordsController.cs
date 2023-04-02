using AspNetTest.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AspNetTest.Areas.MvcAdapter.Controllers
{
    [Authorize]
    public class ItemRecordsController : ApiController
    {
        private static readonly List<ItemRecord> _itemRecords = new List<ItemRecord>
        {
            ItemRecord.NewRecord(),
            ItemRecord.NewRecord(),
            ItemRecord.NewRecord()
        };

        // GET: api/ItemRecords
        public IEnumerable<ItemRecord> Get()
        {
            return _itemRecords;
        }

        // GET: api/ItemRecords/5
        public ItemRecord Get(int id)
        {
            return _itemRecords.First();
        }
    }
}
