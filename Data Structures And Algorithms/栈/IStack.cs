//自定义栈需要实现的接口
namespace 栈 {
    public interface IStack<T> {
        int GetLength();//获取栈的长度
        int Count { get; }//获取栈的元素个数
        bool IsEmpty();//判空栈
        void Clear();//清空栈
        void Push( T  item);//入栈
        T Pop();//出栈,删除栈顶元素
        T Peek();//读取栈顶元素,不删除

    }
}