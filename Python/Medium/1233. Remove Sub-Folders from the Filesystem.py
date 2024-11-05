class Solution:
    def removeSubfolders(self, folder: List[str]) -> List[str]:
        # Step 1: Sort the folder paths
        folder.sort()
        
        # This will hold the result folders after removing subfolders
        result = []
        
        # Step 2: Iterate through sorted folder paths
        for current_folder in folder:
            # If result is empty or current folder is not a subfolder of the last added folder
            if not result or not current_folder.startswith(result[-1] + '/'):
                result.append(current_folder)  # Add the current folder to the result

        return result