﻿using System;
namespace persontask
{
    internal class Student : Person
    {
        private int _point;


        public Student(int point, string name, int age) : base(name, age)
        {
            Point = point;
        }
        public int Point
        {
            get { return _point; }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    _point = value;
                    return;

                }
                Console.WriteLine("yanlisdir");
            }
        }


        public void Info()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"surname: {Surname}\n" +
                $"Age: {Age}\n" +
                $"Point: {Point}");
        }
    }

    }
