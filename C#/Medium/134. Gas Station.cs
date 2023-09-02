public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalGas = 0;
        int totalCost = 0;
        int currentGas = 0;
        int startStation = 0;

        for (int i = 0; i < gas.Length; i++) {
            totalGas += gas[i];
            totalCost += cost[i];
            currentGas += gas[i] - cost[i];

            if (currentGas < 0) {
                startStation = i + 1;
                currentGas = 0;
            }
        }

        if (totalGas < totalCost) {
            return -1;
        }

        return startStation;
    }
}
