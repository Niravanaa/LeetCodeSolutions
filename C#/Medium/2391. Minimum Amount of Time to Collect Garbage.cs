public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        int paperGarbageTruck = 0;
        int paperTravel = 0;

        int glassGarbageTruck = 0;
        int glassTravel = 0;

        int metalGarbageTruck = 0;
        int metalTravel = 0;

        int[] summativeTravel = new int[travel.Length];

        summativeTravel[0] = travel[0];

        for (int i = 1; i < travel.Length; i++)
        {
            summativeTravel[i] = summativeTravel[i - 1] + travel[i];
        }

        for (int i = 0; i < garbage.Length; i++)
        {
            if (garbage[i].Contains('P'))
            {
                paperGarbageTruck += garbage[i].Split('P').Length - 1;

                if (i != 0) paperTravel = summativeTravel[i - 1];
            }

            if (garbage[i].Contains('G'))
            {
                glassGarbageTruck += garbage[i].Split('G').Length - 1;

                if (i != 0) glassTravel = summativeTravel[i - 1];
            }

            if (garbage[i].Contains('M'))
            {
                metalGarbageTruck += garbage[i].Split('M').Length - 1;

                if (i != 0) metalTravel = summativeTravel[i - 1];
            }
        }

        return paperGarbageTruck + glassGarbageTruck + metalGarbageTruck + paperTravel + glassTravel + metalTravel;
    }
}
