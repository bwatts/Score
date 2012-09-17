using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak.Xunit;
using FluentAssertions;

namespace Score.Examples
{
	public class IntervalMath : Example
	{
		[Scenario]
		public void GetHalfStep()
		{
			When(Interval.HalfStep)
			.Then(_ => _.HalfSteps.Should().Be(1))
			.Then(_ => _.WholeSteps.Should().BeInRange(0.5, 0.5));
		}

		[Scenario]
		public void GetWholeStep()
		{
			When(Interval.WholeStep)
			.Then(_ => _.WholeSteps.Should().BeInRange(1, 1))
			.Then(_ => _.HalfSteps.Should().Be(2));
		}

		[Scenario]
		public void FromHalfStep()
		{
			When(new Interval(halfSteps: 1)).Then(_ => _.Should().Be(Interval.HalfStep));
		}

		[Scenario]
		public void FromWholeStep()
		{
			When(new Interval(wholeSteps: 1)).Then(_ => _.Should().Be(Interval.WholeStep));
		}

		[Scenario]
		public void FromSteps()
		{
			When(new Interval(halfSteps: 1, wholeSteps: 1)).Then(_ => _.Should().Be(Interval.HalfStep + Interval.WholeStep));
		}

		[Scenario]
		public void Add()
		{
			When(Interval.HalfStep + Interval.HalfStep).Then(_ => _.Should().Be(Interval.WholeStep));
		}

		[Scenario]
		public void Subtract()
		{
			When(Interval.WholeStep - Interval.HalfStep).Then(_ => _.Should().Be(Interval.HalfStep));
		}

		[Scenario]
		public void Hash()
		{
			When(Interval.HalfStep.GetHashCode()).Then(_ => _.Should().Be(Interval.HalfStep.GetHashCode()));
		}
	}
}