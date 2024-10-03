from typing import List
from functools import cache
import math

class Solution:
    def minimumTotalDistance(self, robots: List[int], factories: List[List[int]]) -> int:
        # This function will calculate the minimum total distance for robots to reach factories.
        
        @cache
        def dp(robot_index, factory_index):
            # If all robots are paired, no more distance is needed (base case).
            if robot_index == len(robots):
                return 0
            # If there are no more factories to pair with, return infinity (impossible case).
            if factory_index == len(factories):
                return math.inf
            
            # Start by assuming we won't use the current factory.
            answer = dp(robot_index, factory_index + 1)
            total_distance = 0
            
            # Try to pair the current robot with the current factory.
            for unit in range(factories[factory_index][1]):
                # If we run out of robots to pair, break out of the loop.
                if robot_index + unit == len(robots):
                    break
                
                # Calculate the distance from the current robot to the current factory.
                total_distance += abs(robots[robot_index + unit] - factories[factory_index][0])
                
                # Update the answer to the minimum distance found so far.
                answer = min(answer, total_distance + dp(robot_index + unit + 1, factory_index + 1))
            
            return answer
        
        # Sort robots and factories to make pairing easier.
        robots.sort()
        factories.sort(key=lambda x: x[0])
        
        # Start the pairing process from the first robot and factory.
        ans = dp(0, 0)
        
        # Clear the cache to free up memory after we are done.
        dp.cache_clear()
        
        return ans
