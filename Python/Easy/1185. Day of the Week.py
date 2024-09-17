import datetime

class Solution:
    def dayOfTheWeek(self, day: int, month: int, year: int) -> str:
        date = datetime.date(year, month, day)

        weekdays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"]
        
        day_of_week = date.weekday()

        return weekdays[day_of_week]        