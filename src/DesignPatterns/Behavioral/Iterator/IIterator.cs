namespace free.src.DesignPatterns.Behavioral.Iterator;

public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        T Current(); 
    }
