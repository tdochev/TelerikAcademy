﻿namespace BitArray64
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong number)
        {
            this.Bits = number;
        }

        public ulong Bits { get; set; }

        public int this[int position]
        {
            get
            {
                this.CheckPostion(position);
                return (int)(this.Bits >> position) & 1;
            }

            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid bit value.");
                }

                this.CheckPostion(position);
                if (((int)(this.Bits >> position) & 1) != value)
                {
                    this.Bits ^= 1ul << position;
                }
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return this.Bits.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj as BitArray64 != null)
            {
                var objAsBitArray64 = obj as BitArray64;
                if (objAsBitArray64.Bits == this.Bits)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        private void CheckPostion(int position)
        {
            if (position < 0 || position > 64)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}