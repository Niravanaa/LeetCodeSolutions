class MyCalendar:

    def __init__(self):
        self.bookings = []

    def book(self, start: int, end: int) -> bool:
        for booked_start, booked_end in self.bookings:
            if start < booked_end and end > booked_start:
                return False
        
        self.bookings.append((start, end))

        return True