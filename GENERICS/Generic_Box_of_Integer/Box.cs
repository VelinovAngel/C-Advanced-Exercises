﻿using System;
namespace Generic_Box_of_Integer
{
    public class Box<T>
    {
        T value;


        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{this.value.GetType()}: {value}";
        }
    }
}
