class Solution(object):
    def findRelativeRanks(self, score):
        # Create a copy of the original list using list constructor
        modified_nums = list(score)

        # Find the indices of the three highest integers
        highest_indices = sorted(range(len(score)), key=lambda i: score[i], reverse=True)[:3]

        # Replace the three highest integers with strings
        medal_names = ["Gold Medal", "Silver Medal", "Bronze Medal"]
        for i, index in enumerate(highest_indices):
            modified_nums[index] = medal_names[i]

        # Sort the remaining values in descending order
        remaining_values = sorted((index, value) for index, value in enumerate(score) if index not in highest_indices)
        remaining_values = [(index, value) for index, value in remaining_values]
        remaining_values.sort(key=lambda x: x[1], reverse=True)

        # Replace the remaining values with incremented numbers in descending order
        for i, (index, _) in enumerate(remaining_values):
            modified_nums[index] = str(i + len(highest_indices) + 1)

        # Return the modified list
        return modified_nums
