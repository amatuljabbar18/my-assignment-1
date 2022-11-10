
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    namespace Assignment4
    {
        internal class StackException
        {
            public void Elements()
            {
                try
                {
                    Stack st = new Stack(6);
                    Console.WriteLine("---Stack Elements are-----");
                    st.Push(4);
                    st.Push(5);
                    st.Push(6);
                    st.Push(7);
                    st.Push(8);
                    st.Push(10);
                st.Display();
                    Console.WriteLine("------- Removed Eements are ------");
                    st.Pop();
                    st.Pop();
                st.Display();
                 
                    Console.WriteLine("------After Pop Method------");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            public static void Main()
            {
                StackException stackException = new StackException();
                stackException.Elements();
            }



        }
    }

