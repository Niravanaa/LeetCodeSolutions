public class ParkingSystem {
    Dictionary<int, int> parkingSystem;
    Dictionary<int, int> trackingSystem;

    public ParkingSystem(int big, int medium, int small) {
        parkingSystem = new Dictionary<int, int>();

        trackingSystem = new Dictionary<int, int>();

        parkingSystem.Add(1, big);

        parkingSystem.Add(2, medium);

        parkingSystem.Add(3, small);

        trackingSystem.Add(1, 0);
        
        trackingSystem.Add(2, 0);

        trackingSystem.Add(3, 0);
    }
    
    public bool AddCar(int carType) {
        if (trackingSystem[carType] == parkingSystem[carType])
        {
            return false;
        }

        else
        {
            trackingSystem[carType]++;

            return true;
        }
    }
}