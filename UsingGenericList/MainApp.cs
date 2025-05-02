using System;
using System.Collections.Generic;

namespace UsingGenericList
{
    class MainApp
    {         
        static void listPrint(List<int> lst)
        {
            foreach (int element in lst)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            // Generic 사용해서 List 생성
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            listPrint(list);

            // .RemoveAt는 List의 해당 Index를 지우는 함수이다.
            list.RemoveAt(0);
            listPrint(list);

            // .Insert(index, item) 원하는 인덱스에 원하는 값 삽입.
            list.Insert(0, 0);
            listPrint(list);
        }
    }
}
