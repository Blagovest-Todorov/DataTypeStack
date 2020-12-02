using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _22.OopStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //what is Stack --special type collection -Pallet -> Last In first Out / Lifo conception ;
            //elements added on the top must be removed first;
            //the Proceed of adding an element to the top is called push Operation /
            // the Procees of removing an element of the top is called  pop  Operation
            //Stack collection :
            //Declaration of teh stack : Stack Data type;
            //Stack st = new Stack(); //Declaring a object of type Stack;
            // adding new elements to the stack 

            // st.push(Element); addint an element to the top
            //st.Pop(); // removing an elemetn from the top;
            //Console.WriteLine(st.Count);
            // St.Contains(element); returns true if the element exitst int0 the  Stack,
            // false it the element does not exit

            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4); //the last element pushed on the Top is diplayed first; LIFO method; Last in First  out

            st.Pop(); //remove the TopMost element-the last element 

            foreach (Object element  in st)
            {
                Console.WriteLine(element);
            }


            Console.WriteLine("Does the Stack contains elements : " + st.Contains(3)); 
            //checks if stack st contains element with value 3
            Console.WriteLine("the number of the element of teh Stack is : " + st.Count);
        } //the Stack Object collection  is based on the concept first in Last out ;
        //as a Pallet -You put the last item on top, You get first the last-on top element;
        //adding an element to the top is called -push operation, the removing operation is called  Pop;
    }
}
