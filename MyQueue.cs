    using System;
    using System.Collections.Generic;
    public class MyQueue {
        private Stack<int> _mainStack = new Stack<int>();    
        private Stack<int> _auxiliaryStack = new Stack<int>();    

        public MyQueue() {
            
        }
            
        public void Push(int x) {
            _mainStack.Push(x);
        }
        
        public int Pop() {
            if(_auxiliaryStack.Count == 0){
                while(_mainStack.Count!=0)
                {
                    _auxiliaryStack.Push(_mainStack.Pop());
                }
            }
            return _auxiliaryStack.Pop();
        }
        
        public int Peek() {
            if(_auxiliaryStack.Count == 0){
                while(_mainStack.Count!=0)
                {
                    _auxiliaryStack.Push(_mainStack.Pop());
                }
            }
            return _auxiliaryStack.Peek();            
        }
        
        public bool Empty() {
            return _mainStack.Count == 0 && _auxiliaryStack.Count == 0;
        }
    }

    /**
    * Your MyQueue object will be instantiated and called as such:
    * MyQueue obj = new MyQueue();
    * obj.Push(x);
    * int param_2 = obj.Pop();
    * int param_3 = obj.Peek();
    * bool param_4 = obj.Empty();
    */