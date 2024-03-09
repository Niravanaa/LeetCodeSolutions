class MyStack {

    private Queue<Integer> queue1;
    private Queue<Integer> queue2;
    private int topElement;

    public MyStack() {
        queue1 = new LinkedList<>();
        queue2 = new LinkedList<>();
    }

    public void push(int x) {
        // Add the new element to queue1
        queue1.offer(x);
        // Set the top element to the newly pushed element
        topElement = x;
    }

    public int pop() {
        // Move all elements from queue1 to queue2 except the last element
        while (queue1.size() > 1) {
            topElement = queue1.poll();
            queue2.offer(topElement);
        }
        // Retrieve the last element from queue1 (which is the top of the stack)
        int popped = queue1.poll();
        // Swap the references of queue1 and queue2
        Queue<Integer> temp = queue1;
        queue1 = queue2;
        queue2 = temp;
        return popped;
    }

    public int top() {
        // The top element of the stack is stored in topElement variable
        return topElement;
    }

    public boolean empty() {
        // If both queues are empty, then the stack is empty
        return queue1.isEmpty() && queue2.isEmpty();
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.push(x);
 * int param_2 = obj.pop();
 * int param_3 = obj.top();
 * boolean param_4 = obj.empty();
 */