using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak.Xunit;
using FluentAssertions;

namespace Score.Examples
{
	public class IntervalComparisons : Example
	{
		[Scenario]
		public void Equal()
		{
			When(Interval.HalfStep.CompareTo(Interval.HalfStep)).Then(_ => _.Should().Be(0));
		}

		[Scenario]
		public void GreaterThan()
		{
			When(Interval.WholeStep.CompareTo(Interval.HalfStep)).Then(_ => _.Should().Be(1));
		}

		[Scenario]
		public void LessThan()
		{
			When(Interval.HalfStep.CompareTo(Interval.WholeStep)).Then(_ => _.Should().Be(-1));
		}
	}
}