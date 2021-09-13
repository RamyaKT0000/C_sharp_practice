using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    enum vehicleType
    {
        twoWheeler, fourWheeler
    }

    class parking
    {
        private vehicleType type;
        private int capacity, count, price, amount;

        public parking(vehicleType type, int count)
        {
            this.type = type;
            this.count = count;

            if (type == vehicleType.twoWheeler)
            {
                capacity = count>150?150:count;
                this.count = count > 150 ? 150 : count;
                price = 20;
            }

            else if (type == vehicleType.fourWheeler)
            {
                capacity = 40;
                price = 40;
            }

            this.amount = this.count * this.price;
        }
        
        public void getType()
        {
            Console.Write($"Type is: {this.type.ToString()}, capacity= {this.capacity}, ");
            Console.WriteLine($"Count is: {this.count}, Amount = {this.amount}, price= {this.price}");
        }

        public void addVehicle(int count)
        {
            int availableCount = this.capacity - this.count;
            if(count>availableCount)
            {
                Console.WriteLine($"You cannot add more than {availableCount} ");
            }
            else
            {
                this.count += count;
                Console.WriteLine($"{count} vehciles added succesfully");
            }
        }
    }

    class Program33
    {
        static void Main(string[] args)
        {
            parking tw = new parking(vehicleType.twoWheeler, 50);
            parking fw = new parking(vehicleType.fourWheeler, 12);

            tw.getType();
            fw.getType();

            tw.addVehicle(2);
            fw.addVehicle(4);
        }
    }
}
