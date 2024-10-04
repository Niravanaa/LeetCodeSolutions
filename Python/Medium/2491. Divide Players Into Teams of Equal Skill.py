class Solution:
    def dividePlayers(self, skill: List[int]) -> int:
        skill.sort()  # Sort the skill array in ascending order
        n = len(skill)
        total_skill = skill[0] + skill[-1]  # Expected total skill for each team
        chemistry_sum = 0

        # Form pairs from the sorted list
        for i in range(n // 2):
            if skill[i] + skill[n - 1 - i] != total_skill:
                return -1  # Return -1 if any pair doesn't match the total skill
            chemistry_sum += skill[i] * skill[n - 1 - i]  # Add the chemistry of the current team

        return chemistry_sum