using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class LinkList<T> : IListDs<T>
    {
        private Node<T> head;//单链表的头引用
        //头引用的属性
        public Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        //构造器
        public LinkList()
        {
            head = null;
        }

        //求单链表的长度
        public int GetLength()
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                p = p.Next;
                len++;
            }
            return len;
        }

        //清空单链表
        public void Clear()
        {
            head = null;
        }

        //判断是否为空
        public bool IsEmpty()
        {
            return head == null;
        }

        //在单链表的末尾添加新元素
        public void Append(T item)
        {
            Node<T> q = new Node<T>(item);
            Node<T> p = new Node<T>();
            if (head == null)
            {
                head = q;
                return;
            }
            p = head;
            while (p.Next != null)
            {
                p = p.Next;
            }
            p.Next = q;
        }

        //在单链表第i个位置前面插入一个值为item的节点
        public void Insert(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("链表为空或者位置错误");
                return;
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head;
                head = q;
                return;
            }
            Node<T> p = head;
            Node<T> r = new Node<T>();
            int j = 1;
            while (p.Next != null && j < i)
            {
                r = p;
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                Node<T> m = r.Next;
                r.Next = q;
                q.Next = m;
            }
        }
        // 删除第i个位置的节点
        public T Delete(int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("链表为空或者位置错误");
                return default(T);
            }
            Node<T> q = new Node<T>();
            if (i == 1)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }
            Node<T> p = head;
            int j = 1;
            while (p.Next != null && j < i)
            {
                q = p;
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("位置不正确");
                return default(T);
            }
        }

        //获得单链表第i个元素
        public T GetElem(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("链表是空链表");
                return default(T);
            }
            Node<T> p = new Node<T>();
            p = head;
            int j = 1;
            while (p.Next != null && j < i)
            {
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("位置不正确！");
            }
            return default(T);

        }

        //在单链表中查找值为value的节点
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("链表是空链表！");
                return -1;
            }
            Node<T> p = new Node<T>();
            p = head;
            int i = 1;
            while (((p.Next != null) && (!p.Data.Equals(value))))
            {
                p = p.Next;
                i++;
            }
            if (p == null)
            {
                Console.WriteLine("不存在这样的节点。");
                return -1;
            }
            else
            {
                return i;
            }
        }
        // 反转链表
        public void Reverse()
        {
            //链表头节点是空的
            if (IsEmpty() || GetLength() == 1)
            {
                return;
            }
            //新节点
            Node<T> newNode = null;
            //当前节点
            Node<T> current = head;
            while (current != null)
            {
                //设置头节点为当前节点的下一个
                head = current.Next;
                //设置当前节点的下一个为新节点
                current.Next = newNode;
                //设置新节点为当前节点
                newNode = current;
                //设置当前节点为头节点
                current = head;
            }
            //设置头节点为新节点
            head = newNode;
        }
    }
}
