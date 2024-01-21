namespace CompositePattern.Equipments
{
    class Cpu : Equipment
    {
        private readonly decimal price;
        private readonly decimal discount;
        private readonly int power;

        public Cpu(decimal price, decimal discount, int power)
        {
            this.price = price;
            this.discount = discount;
            this.power = power;
        }

        public override decimal NetPrice() => price;
        public override bool IsComposite() => false;
        public override decimal DiscountPrice() => price * (1 - discount);
        public override int Power() => power;
    }
}
