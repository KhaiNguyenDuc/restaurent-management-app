using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Table
    {
        private int id;
        private string tableNumber;
        private string type;
        private string state;
        private string location;
        public int Id { get => id; set => id = value; }
        public string TableNumber { get => tableNumber; set => tableNumber = value; }
        public string Type { get => type; set => type = value; }
        public string State { get => state; set => state = value; }
        public string Location { get => location; set => location = value; }

        public Table(int id, string tableNumber, string type, string state)
        {
            this.id = id;
            this.tableNumber = tableNumber;
            this.type = type;
            this.state = state;
        }

        public Table(int id, string tableNumber, string type, string state, string location) : this(id, tableNumber, type, state)
        {
            this.location = location;
        }

        public Table()
        {
        }
    }
}
