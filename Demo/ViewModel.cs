using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ViewModel
    {
        public List<Item> Items { get; set; }
        public List<Link> Connections { get; set; }
        public ViewModel()
        {
            Items = new List<Item>();
            for (int i = 0; i < 5; i++)
                Items.Add(new Item { Id = i, Name = "Item " + i });
            Connections = new List<Link>();
            for (int i = 0; i < 4; i++)
                Connections.Add(new Link { From = Items[i].Id, To = Items[i + 1].Id });
            Connections.Add(new Link { From = Items[4].Id, To = Items[0].Id });
        }
    }
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Link
    {
        public object From { get; set; }
        public object To { get; set; }
    }
}
