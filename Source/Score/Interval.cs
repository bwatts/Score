using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak;

namespace Score
{
	public struct Interval : IEquatable<Interval>, IComparable<Interval>
	{
		public static bool operator ==(Interval first, Interval second)
		{
			return first.Equals(second);
		}

		public static bool operator !=(Interval first, Interval second)
		{
			return !(first == second);
		}

		public static Interval operator +(Interval first, Interval second)
		{
			return new Interval(first.HalfSteps + second.HalfSteps);
		}

		public static Interval operator -(Interval first, Interval second)
		{
			return new Interval(first.HalfSteps - second.HalfSteps);
		}

		// http://en.wikipedia.org/wiki/Interval_%28music%29#Main_intervals

		public static readonly Interval Unison = FromHalfSteps(0);

		public static readonly Interval HalfStep = FromHalfSteps(1);

		public static readonly Interval WholeStep = FromWholeSteps(1);

		public static readonly Interval MinorSecond = FromHalfSteps(1);

		public static readonly Interval MajorSecond = FromHalfSteps(2);

		public static readonly Interval MinorThird = FromHalfSteps(3);

		public static readonly Interval MajorThird = FromHalfSteps(4);

		public static readonly Interval PerfectFourth = FromHalfSteps(5);

		public static readonly Interval AugmentedFourth = FromHalfSteps(6);

		public static readonly Interval DiminishedFifth = FromHalfSteps(6);

		public static readonly Interval PerfectFifth = FromHalfSteps(7);

		public static readonly Interval MinorSixth = FromHalfSteps(8);

		public static readonly Interval MajorSixth = FromHalfSteps(9);

		public static readonly Interval MinorSeventh = FromHalfSteps(10);

		public static readonly Interval MajorSeventh = FromHalfSteps(11);

		public static readonly Interval Octave = FromHalfSteps(12);

		public static Interval FromHalfSteps(int halfSteps)
		{
			return new Interval(halfSteps);
		}

		public static Interval FromWholeSteps(int wholeSteps)
		{
			return new Interval(wholeSteps * 2);
		}

		public static Interval FromSteps(int wholeSteps, int halfSteps)
		{
			return FromWholeSteps(wholeSteps) + FromHalfSteps(halfSteps);
		}

		private Interval(int halfSteps) : this()
		{
			HalfSteps = halfSteps;
			WholeSteps = halfSteps / 2d;
		}

		#region IEquatable

		public override bool Equals(object obj)
		{
			return obj is Interval && Equals((Interval) obj);
		}

		public override int GetHashCode()
		{
			return HalfSteps.GetHashCode();
		}

		public override string ToString()
		{
			return HalfSteps == 1
				? Resources.IntervalSingular
				: Resources.IntervalPlural.FormatInvariant(HalfSteps);
		}

		public bool Equals(Interval other)
		{
			return HalfSteps == other.HalfSteps;
		}
		#endregion

		#region IComparable

		public int CompareTo(Interval other)
		{
			return HalfSteps.CompareTo(other.HalfSteps);
		}
		#endregion

		public int HalfSteps { get; private set; }

		public double WholeSteps { get; private set; }
	}
}