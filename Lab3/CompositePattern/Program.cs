using CompositePattern.Equipments;

namespace CompositePattern
{
    public class Program
    {
        static void Main()
        {
            Client client = new Client();

            ChasisEquipment chasis = new ChasisEquipment(250, 0.08m, 0);
            FloppyDisk floppyDisk1 = new FloppyDisk(500, 0.15m, 10);
            FloppyDisk floppyDisk2 = new FloppyDisk(300, 0.10m, 3);
            chasis.Add(floppyDisk1);
            chasis.Add(floppyDisk2);

            MotherBoardEquipment motherboard = new MotherBoardEquipment(600, 0.20m, 50);
            Cpu cpu = new Cpu(900, 0.25m, 95);
            motherboard.Add(cpu);

            chasis.Add(motherboard);

            client.PrintBill(chasis);
        }
    }
}
