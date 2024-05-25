class Solution(object):
    def distanceTraveled(self, mainTank, additionalTank):
        """
        :type mainTank: int
        :type additionalTank: int
        :rtype: int
        """
        distance = 0
        
        while mainTank > 0:
            if mainTank >= 5:
                # Travel 50 km for every 5 liters consumed
                distance += 50
                mainTank -= 5
                
                # Transfer 1 liter from additionalTank to mainTank if possible
                if additionalTank > 0:
                    mainTank += 1
                    additionalTank -= 1
            else:
                # Travel the remaining distance with the fuel left in mainTank
                distance += mainTank * 10
                break
        
        return distance