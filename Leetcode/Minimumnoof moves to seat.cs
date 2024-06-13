public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        // Create two priority queues (min-heaps)
        PriorityQueue<int, int> seatQueue = new PriorityQueue<int, int>();
        PriorityQueue<int, int> studentQueue = new PriorityQueue<int, int>();

        // Add all seats and students to their respective queues
        foreach (var seat in seats) {
            seatQueue.Enqueue(seat, seat);
        }

        foreach (var student in students) {
            studentQueue.Enqueue(student, student);
        }

        int totalMoves = 0;

        // Process until queues are empty
        while (seatQueue.Count > 0 && studentQueue.Count > 0) {
            int currentSeat = seatQueue.Dequeue();
            int currentStudent = studentQueue.Dequeue();

            // Calculate moves needed for current student to sit at the current seat
            totalMoves += Math.Abs(currentSeat - currentStudent);
        }

        return totalMoves;
    }
}
