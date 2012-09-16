using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak.Xunit;
using FluentAssertions;

namespace Score.Examples
{
	public class NoteMath : Example
	{
		[Scenario]
		public void AddOctave()
		{
			When(Note.C + Interval.Octave).Then(_ => _.Should().Be(Note.C));
		}

		[Scenario]
		public void AddHalfStep()
		{
			When(Note.C + Interval.HalfStep).Then(_ => _.Should().Be(Note.C.Sharp));
		}

		[Scenario]
		public void AddAcrossPitchClassBoundary()
		{
			When(Note.B + Interval.HalfStep).Then(_ => _.Should().Be(Note.C));
		}

		[Scenario]
		public void SubtractOctave()
		{
			When(Note.C - Interval.Octave).Then(_ => _.Should().Be(Note.C));
		}

		[Scenario]
		public void SubtractHalfStep()
		{
			When(Note.C - Interval.HalfStep).Then(_ => _.Should().Be(Note.B));
		}

		[Scenario]
		public void SubtractAcrossPitchClassBoundary()
		{
			When(Note.C - Interval.HalfStep).Then(_ => _.Should().Be(Note.B));
		}
	}
}