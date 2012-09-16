using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak.Xunit;
using FluentAssertions;

namespace Score.Examples
{
	public class IntervalPresets : Example
	{
		[Scenario]
		public void GetUnison()
		{
			When(Interval.Unison).Then(_ => _.HalfSteps.Should().Be(0));
		}

		[Scenario]
		public void GetHalfStep()
		{
			When(Interval.HalfStep).Then(_ => _.HalfSteps.Should().Be(1));
		}

		[Scenario]
		public void GetWholeStep()
		{
			When(Interval.WholeStep).Then(_ => _.WholeSteps.Should().BeInRange(1, 1));
		}

		[Scenario]
		public void GetMinorSecond()
		{
			When(Interval.MinorSecond).Then(_ => _.HalfSteps.Should().Be(1));
		}

		[Scenario]
		public void GetMajorSecond()
		{
			When(Interval.MajorSecond).Then(_ => _.HalfSteps.Should().Be(2));
		}

		[Scenario]
		public void GetMinorThird()
		{
			When(Interval.MinorThird).Then(_ => _.HalfSteps.Should().Be(3));
		}

		[Scenario]
		public void GetMajorThird()
		{
			When(Interval.MajorThird).Then(_ => _.HalfSteps.Should().Be(4));
		}

		[Scenario]
		public void GetPerfectFourth()
		{
			When(Interval.PerfectFourth).Then(_ => _.HalfSteps.Should().Be(5));
		}

		[Scenario]
		public void GetAugmentedFourth()
		{
			When(Interval.AugmentedFourth).Then(_ => _.HalfSteps.Should().Be(6));
		}

		[Scenario]
		public void GetDiminishedFifth()
		{
			When(Interval.DiminishedFifth).Then(_ => _.HalfSteps.Should().Be(6));
		}

		[Scenario]
		public void GetPerfectFifth()
		{
			When(Interval.PerfectFifth).Then(_ => _.HalfSteps.Should().Be(7));
		}

		[Scenario]
		public void GetMinorSixth()
		{
			When(Interval.MinorSixth).Then(_ => _.HalfSteps.Should().Be(8));
		}

		[Scenario]
		public void GetMajorSixth()
		{
			When(Interval.MajorSixth).Then(_ => _.HalfSteps.Should().Be(9));
		}

		[Scenario]
		public void GetMinorSeventh()
		{
			When(Interval.MinorSeventh).Then(_ => _.HalfSteps.Should().Be(10));
		}

		[Scenario]
		public void GetMajorSeventh()
		{
			When(Interval.MajorSeventh).Then(_ => _.HalfSteps.Should().Be(11));
		}

		[Scenario]
		public void GetOctave()
		{
			When(Interval.Octave).Then(_ => _.HalfSteps.Should().Be(12));
		}
	}
}