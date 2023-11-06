public class SeatManager {
    private int nextAvailableSeat;

    private SortedSet<int> availableSeats;

    public SeatManager(int n)
    {
        nextAvailableSeat = 1;

        availableSeats = new SortedSet<int>();

        for (int i = 1; i <= n; i++)
        {
            availableSeats.Add(i);
        }
    }

    public int Reserve()
    {
        if (availableSeats.Count == 0)
        {
            return -1; // No available seats
        }

        int seatToReserve = availableSeats.Min;

        availableSeats.Remove(seatToReserve);
        
        return seatToReserve;
    }

    public void Unreserve(int seatNumber)
    {
        if (seatNumber >= 1)
        {
            availableSeats.Add(seatNumber);
        }
    }
}