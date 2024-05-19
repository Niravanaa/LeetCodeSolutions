class Solution {
    public int minNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience) {
        int result = 0;

        for (int i = 0; i < energy.length; i++) {
            // Check energy requirement
            if (initialEnergy <= energy[i]) {
                // Calculate the additional hours needed to increase energy
                result += (energy[i] - initialEnergy + 1);
                initialEnergy = energy[i] + 1;  // Ensure initialEnergy is enough for the next battle
            }
            initialEnergy -= energy[i];

            // Check experience requirement
            if (initialExperience <= experience[i]) {
                // Calculate the additional hours needed to increase experience
                result += (experience[i] - initialExperience + 1);
                initialExperience = experience[i] + 1;  // Ensure initialExperience is enough for the next battle
            }
            initialExperience += experience[i];
        }

        return result;
    }
}
