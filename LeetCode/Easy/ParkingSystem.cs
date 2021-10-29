namespace CodingAlgorithms.LeetCode.Easy
{
    /*
        Design a parking system for a parking lot. The parking lot has three kinds of parking spaces: big, medium, and small, with a fixed number of slots for each size.

        Implement the ParkingSystem class:

        ParkingSystem(int big, int medium, int small) 
            - Initializes object of the ParkingSystem class. 
            - The number of slots for each parking space are given as part of the constructor.
        bool addCar(int carType) 
            - Checks whether there is a parking space of carType for the car that wants to get into the parking lot. 
            - carType can be of three kinds: big, medium, or small, which are represented by 1, 2, and 3 respectively. 
            - A car can only park in a parking space of its carType. If there is no space available, return false, else park the car in that size space and return true.    
    */
    public class ParkingSystem
    {
        private int big;
        private int medium;
        private int small;

        public ParkingSystem(int b, int m, int s)
        {
            big = b;
            medium = m;
            small = s;
        }

        // Big=1, Meidum=2, Small=1
        public bool AddCar(int carType)
        {
            switch(carType)
            {
                case 1:
                    if(big>0)
                    {
                        big--;
                        return true;
                    }
                    return false;
                case 2:
                    if(medium>0)
                    {
                        medium--;
                        return true;
                    }
                    return false;
                case 3:
                    if(small>0)
                    {
                        small--;
                        return true;
                    }
                    return false;
            }
            return false;
        }
    }
}