class MyCalendarTwo:

    def __init__(self):
        self.bookings = []
        self.doubleBookings = []

    def book(self, start: int, end: int) -> bool:
        for s, e in self.doubleBookings:
            if start < e and end > s:
                return False

        for s, e in self.bookings:
            if start < e and end > s:
                self.doubleBookings.append((max(start, s), min(end, e)))
        
        self.bookings.append((start, end))
        return True