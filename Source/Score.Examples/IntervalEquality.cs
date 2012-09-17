using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak.Xunit;
using FluentAssertions;

namespace Score.Examples
{
	public class IntervalEquality : Example
	{
		[Scenario]
		public void Equal()
		{
			When(Interval.HalfStep.Equals(Interval.HalfStep)).Then(_ => _.Should().BeTrue());
		}

		[Scenario]
		public void NotEqual()
		{
			When(Interval.HalfStep.Equals(Interval.WholeStep)).Then(_ => _.Should().BeFalse());
		}

		[Scenario]
		public void EqualOperator()
		{
			When(Interval.HalfStep == new Interval(halfSteps: 1)).Then(_ => _.Should().BeTrue());
		}

		[Scenario]
		public void NotEqualOperator()
		{
			When(Interval.HalfStep != Interval.WholeStep).Then(_ => _.Should().BeTrue());
		}

		[Scenario]
		public void EqualAsObjects()
		{
			Given((object) Interval.HalfStep)
			.When(_ => _.Equals(Interval.HalfStep))
			.Then(_ => _.Should().BeTrue());
		}

		[Scenario]
		public void NotEqualToNonInterval()
		{
			When(Interval.HalfStep.Equals(new object())).Then(_ => _.Should().BeFalse());
		}
	}
}