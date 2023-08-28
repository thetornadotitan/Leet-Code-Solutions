public class MyStack {
    private Queue<int> stack;

    public MyStack() {
        stack = new Queue<int>();
    }
    
    public void Push(int x) {
        int[] temp = new int[stack.Count+1];
        for(int i = 0; i < temp.Length; i++) {
            if (i == 0)
                temp[i] = x;
            else temp[i] = stack.Dequeue();
        }

        for(int i = 0; i < temp.Length; i++) {
            stack.Enqueue(temp[i]);
        }
    }
    
    public int Pop() {
        return stack.Dequeue();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public bool Empty() {
        return stack.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */