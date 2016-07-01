using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgo_round_helper
{
    class Weapon
    {
        private String Name;
        private String Type;
        private int Cost;

        public Weapon(String name, String type, int cost)
        {
            Name = name;
            Type = type;
            Cost = cost;
        }

        public String getName() { return Name; }
        public String getType() { return Type; }
        public int getCost() { return Cost; }

        public void setName(String newName) { Name = newName; }
        public void setType(String newType) { Type = newType; }
        public void setCost(int newCost) { Cost = newCost; }
    }
}
