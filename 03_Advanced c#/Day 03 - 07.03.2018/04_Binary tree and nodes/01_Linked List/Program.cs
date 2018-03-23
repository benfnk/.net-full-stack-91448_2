//A linked list is a chain of structure or records called nodes.Each node has at least two members, one ofwhich points to the next item or node in the list! These are defined as Single Linked Lists because they only point to the next item, and not the previous. Those that do point to both are called Doubly Linked Lists.


using System;

namespace linked_list
{
    class node
    {
        public string name;
        public int id;
        public int ennr;
        public node next;

        public node()
        {
            id = 0;
            ennr = 0;
            name = "";
            next = null;
        }
        public node(node n)
        {
            this.id = n.id;
            this.name = n.name;
            this.ennr = n.ennr;
            this.next = null;
        }
        public node(string name1, int id1, int ennr1)
        {
            name = name1;
            id = id1;
            ennr = ennr1;
            next = null;
        }
    }
    class linked_list
    {
        node head, curr, temp;

        public linked_list()
        {
            head = curr = temp = null;
        }
        public void insertnode(node n)
        {
            if (head == null)
            {
                head = curr = temp = new node(n);
            }
            else
            {
                temp = curr;
                curr = new node(n);
                temp.next = curr;
            }
        }
        public void showdata()
        {
            node a = head;
            while (a != null)
            {
                Console.WriteLine("studnet name:{0}\tid:{1}\t\tEN:{2}", a.name, a.id, a.ennr);
                a = a.next;
            }
        }
        public void deletefirt()
        {
            head = head.next;
        }
        public void deleteall()
        {
            head = null;
        }
        public void insertbefore(int key, node n)
        {
            node run = head;
            node back = head;
            while (run != null)
            {
                if (run.id == key)
                {
                    back.next = new node(n);
                    back.next.next = run;
                }
                back = run;
                run = run.next;
            }
        }
        public void inserthead(node n)
        {
            node a = new node(n);
            a.next = head;
            head = a;

        }
        public void insertlast(node n)
        {
            curr.next = new node(n);
        }

        public void deletemid(int key)
        {
            node temp1 = head;
            node temp2 = head;
            node a = head;
            while (a != null)
            {
                if (a.id == key)
                {
                    temp1.next = temp2;
                    // temp2 = a;
                    break;
                }
                temp1 = a;
                a = a.next;
                temp2 = a.next;
                if (head.id == key)
                {
                    head = head.next;
                }


                else if (head == null)
                {
                    Console.WriteLine("the list is null");
                }

            }
        }
        public void search(int id1)
        {
            bool found = false;
            node a = head;
            while (a != null)
            {
                if (a.id == id1)
                {
                    Console.WriteLine("studnet name:{0}\tid:{1}\t\tEN:{2}", a.name, a.id, a.ennr);
                    found = true;
                    break;

                }
                a = a.next;
            }
            if (found == false)
            {
                Console.WriteLine("Id was not found");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            linked_list a = new linked_list();
            string End;
            Console.WriteLine("THE LINKED LIST WORK");
            Console.WriteLine("----------------------------------------");
            string z, h;
            int x, y;

            a.insertnode(new node("human", 120, 020321));
            a.insertnode(new node("person", 43, 4321));
            a.insertnode(new node("test", 83, 66321));
            a.insertnode(new node("click", 1423, 02321));
            a.insertnode(new node("book", 16, 5461));
            a.insertnode(new node("even", 23, 4));
            a.showdata();

            do
            {

                try
                {
                    do
                    {
                        Console.WriteLine("DO YOU WANT ADD NODE");
                        Console.WriteLine("----------------------------------------");
                        //Console.WriteLine("Do you want add node press y to add");
                        Console.WriteLine("\nto add at first press 1\nto add at last press 2\nto add at mid press 3");
                        string ss = Console.ReadLine();
                        if (ss == "3")
                        {
                            Console.WriteLine("ADD NODE AT BEFORE");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Enter the name of student");
                            z = Console.ReadLine();

                            Console.WriteLine("Enter the Enrollment no of student");
                            y = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("int the id of student should put at");
                            x = Convert.ToInt32(Console.ReadLine());
                            int key;
                            Console.WriteLine("node should be placed before");
                            key = Convert.ToInt32(Console.ReadLine());
                            a.insertbefore(key, new node(z, x, y));
                            a.showdata();

                        }
                        else if (ss == "1")
                        {
                            Console.WriteLine("ADD NODE AT HEAD");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Enter the name of student");
                            z = Console.ReadLine();

                            Console.WriteLine("Enter the Enrollment no of student");
                            y = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the id of student");
                            x = Convert.ToInt32(Console.ReadLine());
                            a.inserthead(new node(z, x, y));
                            a.showdata();
                        }
                        else if (ss == "2")
                        {
                            Console.WriteLine("ADD NODE AT LAST");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Enter the name of student");
                            z = Console.ReadLine();

                            Console.WriteLine("Enter the Enrollment no of student");
                            y = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the id of student");
                            x = Convert.ToInt32(Console.ReadLine());
                            a.insertlast(new node(z, x, y));
                            a.showdata();
                        }

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Enter 0 to end");
                        h = Console.ReadLine();
                        Console.WriteLine("----------------------------------------");
                    }
                    while (h != "0");


                    int ff;
                    do
                    {
                        Console.WriteLine("DO YOU WANT DELTE NODE");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("press 1 delete first node\npress 2 to delete all nodes\npress 3 to delte mid node");
                        ff = Convert.ToInt32(Console.ReadLine());
                        switch (ff)
                        {
                            case 1:
                                Console.WriteLine("DELETE FIRST NODE");
                                Console.WriteLine("----------------------------------------");
                                a.deletefirt();
                                a.showdata();
                                break;
                            case 2:
                                Console.WriteLine("DELETE ALL NODE");
                                Console.WriteLine("----------------------------------------");
                                a.deleteall();
                                a.showdata();
                                break;
                            case 3:
                                Console.WriteLine("DELETE MID NODE");
                                Console.WriteLine("----------------------------------------");
                                Console.WriteLine("Enter the id of student to delete record");
                                int hh = Convert.ToInt32(Console.ReadLine());
                                a.deletemid(hh);
                                a.showdata();
                                break;

                            default: Console.WriteLine("wrong input"); break;
                        }
                        // a.showdata();
                        Console.WriteLine("----------------------------------------");
                        Console.Write("TO END PRESS 0:");

                        ff = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------------------------------------");

                    } while (ff != 0);
                }
                catch (Exception HH)
                {
                    Console.WriteLine(HH.Message);
                }
                Console.WriteLine("DO YOU WANT SEARCH STUDENT");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Enter the id of student to serch record");
                int id = Convert.ToInt32(Console.ReadLine());
                a.search(id);
                Console.Write("TO END PRESS 0:");
                End = Console.ReadLine(); Console.Clear();
            } while (End != "0");
        }
    }
}
