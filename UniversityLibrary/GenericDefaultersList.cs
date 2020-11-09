using System;
using System.Collections.Generic;
namespace UniversityLibrary
{
    public class GenericDefaulterList<T> where T : IDefaulters
    {
        private T[] studentDefaulters;
        private int numElements;
        private const int DEFAULTSIZE = 20;
        public GenericDefaulterList()
        {
            studentDefaulters = new T[DEFAULTSIZE];
            numElements = 0;
        }

        public GenericDefaulterList(int size) //overloaded constructor
        {
            studentDefaulters = new T[size];
            numElements = 0;
        }

        public void Add(T item)
        {
            if(numElements < studentDefaulters.Length)
            {
                studentDefaulters[numElements] = item;
                numElements++;
            }else{
                throw new System.Exception("studentDefaulters collection is full...");
            }
        }

    

        public T[] GetDefaulter()
        {
            if(numElements > 0)
            {
                return studentDefaulters;
            }else{
                throw new System.Exception("studentDefaulters collection is empty...");
            }
        }

    }
}


