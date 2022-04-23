using System;
using System.IO;

namespace SerializationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ListNode first = new ListNode();
            ListNode second = new ListNode();
            ListNode third = new ListNode();
            ListNode fourth = new ListNode();
            ListNode fifth = new ListNode();

            first.Next = second;
            second.Next = third;
            third.Next = fourth;
            fourth.Next = fifth;

            fifth.Prev = fourth;
            fourth.Prev = third;
            third.Prev = second;
            second.Prev = first;

            second.Rand = second;
            third.Rand = fifth;
            fourth.Rand = first;

            first.Data = "first";
            second.Data = "second";
            third.Data = "third";
            fourth.Data = "fourth";
            fifth.Data = "fifth";

            ListRand list1 = new ListRand();
            list1.Head = first;
            list1.Tail = fifth;
            list1.Count = 5;

            using (FileStream s = new FileStream("list1.txt", FileMode.OpenOrCreate))
            {
                list1.Serialize(s);
                Console.WriteLine("Serialized");
            }

            ListRand list2 = new ListRand();
            using (FileStream s = new FileStream("list1.txt", FileMode.OpenOrCreate))
            {
                list2.Deserialize(s);
                Console.WriteLine("Deserialized");
            }
            using (FileStream s = new FileStream("list2.txt", FileMode.OpenOrCreate))
            {
                list2.Serialize(s);
                Console.WriteLine("Serialized");
            }
            Console.WriteLine("Head.Data = " + list2.Head.Data);
            Console.WriteLine("Tail.Data = " + list2.Tail.Data);
        }
    }

    public class ListNode
    {
        public ListNode Prev;
        public ListNode Rand;
        public ListNode Next;
        public string Data;

        public void Serialize(StreamWriter sw)
        {

            sw.Write("\n(" +
            "\nprev:");
            if (Prev != null)
                sw.Write(Prev.Data);
            sw.Write("\nnext:");
            if (Next != null)
                sw.Write(Next.Data);
            sw.Write("\nrand:");
            if (Rand != null)
                sw.Write(Rand.Data);
            sw.Write("\ndata:" + Data +
            "\n)");

        }

        public static ListNode Deserialize(StreamReader sr, out string rand)
        {
            rand = null;
            string line = sr.ReadLine();
            if (line == "(")
            {
                var listNode = new ListNode();
                line = sr.ReadLine();
                while (line != ")")
                {
                    if (line.Contains("data:"))
                        listNode.Data = line.Substring(line.IndexOf(":") + 1);

                    if (line.Contains("rand:"))
                        line.Substring(line.IndexOf(":") + 1);

                    line = sr.ReadLine();
                }
                return listNode;
            }
            return null;
        }
    }

    public class ListRand
    {
        public ListNode Head;
        public ListNode Tail;
        public int Count;

        public void Serialize(FileStream s)
        {
            ListNode current = Head;
            using (StreamWriter sw = new StreamWriter(s))
            {
                sw.Write("{" +
                "\ncount:" + Count +
                "\n[");

                while (current != Tail)
                {
                    current.Serialize(sw);
                    current = current.Next;
                }
                current.Serialize(sw);
                sw.Write("\n]\n}");
            }
        }

        public ListRand Deserialize(FileStream s)
        {
            using (var sr = new StreamReader(s))
            {
                string line = sr.ReadLine();
                int headPosition = 0;

                if (line == "{")
                {
                    line = sr.ReadLine();
                    if (line.Contains("count:"))
                        Count = Convert.ToInt32(line.Substring(line.IndexOf(":") + 1));

                    line = sr.ReadLine();
                    if (line == "[")
                    {
                        ListNode current = null;
                        int position = 0;
                        string[] randDatas = new string[Count];
                        while (true)
                        {
                            ListNode previous = current;
                            current = ListNode.Deserialize(sr, out string rand);
                            if (current == null)
                            {
                                Tail = previous;
                                break;
                            }

                            current.Prev = previous;

                            if (previous == null)
                                previous = current; // 

                            previous.Next = current;

                            if (position == headPosition)
                                Head = current;

                            randDatas[position] = rand;
                            position++;
                        }

                        position = 0;
                        current = Head;

                        foreach (string randData in randDatas)
                        {
                            if (randData != null)
                            {
                                ListNode check = Head;
                                while (check != null)
                                {
                                    if (check.Data == randData)
                                        current.Rand = check;
                                    check = check.Next;
                                }
                            }
                            current = current.Next;
                        }
                    }
                }
            }
            return this;
        }
    }
}