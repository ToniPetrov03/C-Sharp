using System;
using System.Collections.Generic;

namespace _08.MaximalSum
{
    class NashMaximalSum
    {
        static void Main(string[] args)
        {
            // nash code
            NashInt nashoA = NashParse(Console.ReadLine());
            NashInt nashoB = NashParse(Console.ReadLine());
            NashInt nashoC = NashParse(Console.ReadLine());
            NashInt nashoD = NashParse(Console.ReadLine());
            NashInt nashoE = NashParse(Console.ReadLine());

            NashInt NashSmallest = NashInt.NashoMaxValue;

            NashInt nashoAbc = NashoLCM(nashoA, NashoLCM(nashoB, nashoC));
            NashInt nashoAbd = NashoLCM(nashoA, NashoLCM(nashoB, nashoD));
            NashInt nashoAbe = NashoLCM(nashoA, NashoLCM(nashoB, nashoE));
            NashInt nashoAcd = NashoLCM(nashoA, NashoLCM(nashoC, nashoD));
            NashInt nashoAce = NashoLCM(nashoA, NashoLCM(nashoC, nashoE));
            NashInt nashoAde = NashoLCM(nashoA, NashoLCM(nashoD, nashoE));
            NashInt nashoBcd = NashoLCM(nashoB, NashoLCM(nashoC, nashoD));
            NashInt nashoBce = NashoLCM(nashoB, NashoLCM(nashoC, nashoE));
            NashInt nashoBde = NashoLCM(nashoB, NashoLCM(nashoD, nashoE));
            NashInt nashoCde = NashoLCM(nashoC, NashoLCM(nashoD, nashoE));

            if (nashoAbc < NashSmallest)
                NashSmallest = nashoAbc;

            if (nashoAbd < NashSmallest)
                NashSmallest = nashoAbd;

            if (nashoAbe < NashSmallest)
                NashSmallest = nashoAbe;

            if (nashoAcd < NashSmallest)
                NashSmallest = nashoAcd;

            if (nashoAce < NashSmallest)
                NashSmallest = nashoAce;

            if (nashoAde < NashSmallest)
                NashSmallest = nashoAde;

            if (nashoBcd < NashSmallest)
                NashSmallest = nashoBcd;

            if (nashoBce < NashSmallest)
                NashSmallest = nashoBce;

            if (nashoBde < NashSmallest)
                NashSmallest = nashoBde;

            if (nashoCde < NashSmallest)
                NashSmallest = nashoCde;

            Console.WriteLine(NashSmallest);
        }

        private static NashInt NashParse(string nashoA)
        {
            NashInt nashNumber = 0;
            NashInt nashMultiple = 1;

            for (NashInt nashoI = 0; nashoI < nashoA.Length; nashoI++)
            {
                NashInt nashDigit = nashoA[nashoA.Length - 1 - nashoI] - '0';
                nashNumber += nashDigit * nashMultiple;
                nashMultiple *= 10;
            }
            return nashNumber;
        }
        

        private static int NashoLCM(NashInt a, NashInt b)
        {
            NashInt num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (NashInt i = 1; i < num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num1 * num2;
        }

        public class NashInt : CustomValueType<NashInt, Int32>
        {
            private NashInt(NashInt value) : base(value) { }
            public const Int32 NashoMaxValue = 2147483647;
            public static implicit operator NashInt(int value) { return new NashInt(value); }
            public static implicit operator int(NashInt custom) { return custom._value; }
        }

        public class CustomValueType<TCustom, TValue>
        {
            protected readonly TValue _value;

            public CustomValueType(TValue value)
            {
                _value = value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }

            public static bool operator <(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
            {
                return Comparer<TValue>.Default.Compare(a._value, b._value) < 0;
            }

            public static bool operator >(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
            {
                return !(a < b);
            }

            public static bool operator <=(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
            {
                return (a < b) || (a == b);
            }

            public static bool operator >=(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
            {
                return (a > b) || (a == b);
            }

            public static bool operator ==(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
            {
                return a.Equals((object)b);
            }

            public static bool operator !=(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
            {
                return !(a == b);
            }

            public static TCustom operator +(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
            {
                return (dynamic)a._value + b._value;
            }

            public static TCustom operator -(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
            {
                return ((dynamic)a._value - b._value);
            }

            protected bool Equals(CustomValueType<TCustom, TValue> other)
            {
                return EqualityComparer<TValue>.Default.Equals(_value, other._value);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((CustomValueType<TCustom, TValue>)obj);
            }

            public override int GetHashCode()
            {
                return EqualityComparer<TValue>.Default.GetHashCode(_value);
            }
        }

    }
}
