using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

		public static readonly Interval Zero = new Interval();

		// http://en.wikipedia.org/wiki/Interval_%28music%29#Main_intervals

		public static readonly Interval Unison = new Interval();
		public static readonly Interval HalfStep = new Interval(halfSteps: 1);
		public static readonly Interval WholeStep = new Interval(wholeSteps: 1);
		public static readonly Interval MinorSecond = new Interval(halfSteps: 1);
		public static readonly Interval MajorSecond = new Interval(halfSteps: 2);
		public static readonly Interval MinorThird = new Interval(halfSteps: 3);
		public static readonly Interval MajorThird = new Interval(halfSteps: 4);
		public static readonly Interval PerfectFourth = new Interval(halfSteps: 5);
		public static readonly Interval AugmentedFourth = new Interval(halfSteps: 6);
		public static readonly Interval DiminishedFifth = new Interval(halfSteps: 6);
		public static readonly Interval PerfectFifth = new Interval(halfSteps: 7);
		public static readonly Interval MinorSixth = new Interval(halfSteps: 8);
		public static readonly Interval MajorSixth = new Interval(halfSteps: 9);
		public static readonly Interval MinorSeventh = new Interval(halfSteps: 10);
		public static readonly Interval MajorSeventh = new Interval(halfSteps: 11);
		public static readonly Interval Octave = new Interval(halfSteps: 12);

		public Interval(int halfSteps = 0, int wholeSteps = 0) : this()
		{
			Contract.Requires(halfSteps >= 0);

			HalfSteps = halfSteps + wholeSteps * 2;
			WholeSteps = HalfSteps / 2d;
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