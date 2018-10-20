using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
	//数组实现循环队列
	class CircularQueue<T>
	{
		//数组和数组大小
		private T[] items;
		private int n = 0;

		//队首和队尾
		private int head = 0;
		private int tail = 0;
		
		public CircularQueue(int n)
		{
			items = new T[n];
			this.n = n;
		}

		//入队
		public bool Enqueue(T value)
		{

			//若队满
			if((tail + 1) % n == head)
			{
				return false;
			}
			items[tail] = value;
			tail = (tail + 1) % n;
			return true;
			
		}

		//出队
		public T Dequeue()
		{
			//若队空
			if (head == tail) return default(T);

			T res = items[head];
			head = (head + 1) % n;
			return res;
		}

	}
}
