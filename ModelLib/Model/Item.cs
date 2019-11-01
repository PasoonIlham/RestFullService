using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Quality { get; set; }
        public double Quantity { get; set; }

        public Item(int id, string name, string quality, double quantity)
        {
            ID = id;
            Name = name;
            Quality = quality;
            Quantity = quantity;
        }

        public Item()
        {

        }


        public override string ToString()
        {
            return $"{nameof(ID)}: {ID}, {nameof(Name)}: {Name}, {nameof(Quality)}: {Quality}, {nameof(Quantity)}: {Quantity}";
        }

        public override bool Equals(object obj)
        {
            return obj is Item item &&
                   ID == item.ID &&
                   Name == item.Name &&
                   Quality == item.Quality &&
                   Quantity == item.Quantity;
        }
    }
}
