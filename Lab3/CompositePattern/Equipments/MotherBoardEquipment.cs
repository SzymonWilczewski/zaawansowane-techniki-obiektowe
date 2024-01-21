using System.Collections.Generic;

namespace CompositePattern.Equipments
{
    class MotherBoardEquipment : Equipment
    {
        protected List<Equipment> equipments = new List<Equipment>();

        private readonly decimal price;
        private readonly decimal discount;
        private readonly int power;

        public MotherBoardEquipment(decimal price, decimal discount, int power)
        {
            this.price = price;
            this.discount = discount;
            this.power = power;
        }

        public override void Add(Equipment component) => equipments.Add(component);
        public override void Remove(Equipment component) => equipments.Remove(component);

        public override decimal NetPrice()
        {
            decimal result = price;
            equipments.ForEach(x => result += x.NetPrice());
            return result;
        }

        public override decimal DiscountPrice()
        {
            decimal result = price * (1 - discount);
            equipments.ForEach(x => result += x.DiscountPrice());
            return result;
        }

        public override int Power()
        {
            int result = power;
            equipments.ForEach(x => result += x.Power());
            return result;
        }
    }
}
