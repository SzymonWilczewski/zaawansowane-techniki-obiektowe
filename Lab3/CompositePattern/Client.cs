using CompositePattern.Equipments;
using System;

namespace CompositePattern
{
    class Client
    {
        public void PrintBill(Equipment equipment)
        {
            Console.WriteLine($"Bill:\n\tNet Price: {equipment.NetPrice()}\n\tDiscount Price: {equipment.DiscountPrice()}\n\tPower: {equipment.Power()}");
        }
    }
}
