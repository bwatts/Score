using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak.Xunit;
using FluentAssertions;

namespace Score.Examples
{
	public class Modes : Example
	{
		[Scenario(Skip = "Calculation is not in place")]
		public void Ionian()
		{
			When(Mode.Ionian.GetNotes(new Key(Note.C, KeyScale.Major)).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.C))
			.Then(_ => _[1].Should().Be(Note.D))
			.Then(_ => _[2].Should().Be(Note.E))
			.Then(_ => _[3].Should().Be(Note.F))
			.Then(_ => _[4].Should().Be(Note.G))
			.Then(_ => _[5].Should().Be(Note.A))
			.Then(_ => _[6].Should().Be(Note.B))
			.Then(_ => _[7].Should().Be(Note.C));
		}

		[Scenario(Skip = "Calculation is not in place")]
		public void Dorian()
		{
			When(Mode.Dorian.GetNotes(new Key(Note.D, KeyScale.Major)).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.D))
			.Then(_ => _[1].Should().Be(Note.E))
			.Then(_ => _[2].Should().Be(Note.F))
			.Then(_ => _[3].Should().Be(Note.G))
			.Then(_ => _[4].Should().Be(Note.A))
			.Then(_ => _[5].Should().Be(Note.B))
			.Then(_ => _[6].Should().Be(Note.C))
			.Then(_ => _[7].Should().Be(Note.D));
		}

		[Scenario(Skip = "Calculation is not in place")]
		public void Phrygian()
		{
			When(Mode.Phrygian.GetNotes(new Key(Note.E, KeyScale.Major)).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.E))
			.Then(_ => _[1].Should().Be(Note.F))
			.Then(_ => _[2].Should().Be(Note.G))
			.Then(_ => _[3].Should().Be(Note.A))
			.Then(_ => _[4].Should().Be(Note.B))
			.Then(_ => _[5].Should().Be(Note.C))
			.Then(_ => _[6].Should().Be(Note.D))
			.Then(_ => _[7].Should().Be(Note.E));
		}

		[Scenario(Skip = "Calculation is not in place")]
		public void Lydian()
		{
			When(Mode.Lydian.GetNotes(new Key(Note.F, KeyScale.Major)).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.F))
			.Then(_ => _[1].Should().Be(Note.G))
			.Then(_ => _[2].Should().Be(Note.A))
			.Then(_ => _[3].Should().Be(Note.B))
			.Then(_ => _[4].Should().Be(Note.C))
			.Then(_ => _[5].Should().Be(Note.D))
			.Then(_ => _[6].Should().Be(Note.E))
			.Then(_ => _[7].Should().Be(Note.F));
		}

		[Scenario(Skip = "Calculation is not in place")]
		public void Mixolydian()
		{
			When(Mode.Mixolydian.GetNotes(new Key(Note.G, KeyScale.Major)).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.G))
			.Then(_ => _[1].Should().Be(Note.A))
			.Then(_ => _[2].Should().Be(Note.B))
			.Then(_ => _[3].Should().Be(Note.C))
			.Then(_ => _[4].Should().Be(Note.D))
			.Then(_ => _[5].Should().Be(Note.E))
			.Then(_ => _[6].Should().Be(Note.F))
			.Then(_ => _[7].Should().Be(Note.G));
		}

		[Scenario(Skip = "Calculation is not in place")]
		public void Aeolian()
		{
			When(Mode.Aeolian.GetNotes(new Key(Note.A, KeyScale.Major)).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.A))
			.Then(_ => _[1].Should().Be(Note.B))
			.Then(_ => _[2].Should().Be(Note.C))
			.Then(_ => _[3].Should().Be(Note.D))
			.Then(_ => _[4].Should().Be(Note.E))
			.Then(_ => _[5].Should().Be(Note.F))
			.Then(_ => _[6].Should().Be(Note.G))
			.Then(_ => _[7].Should().Be(Note.A));
		}

		[Scenario(Skip = "Calculation is not in place")]
		public void Locrian()
		{
			When(Mode.Locrian.GetNotes(new Key(Note.B, KeyScale.Major)).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.B))
			.Then(_ => _[1].Should().Be(Note.C))
			.Then(_ => _[2].Should().Be(Note.D))
			.Then(_ => _[3].Should().Be(Note.E))
			.Then(_ => _[4].Should().Be(Note.F))
			.Then(_ => _[5].Should().Be(Note.G))
			.Then(_ => _[6].Should().Be(Note.A))
			.Then(_ => _[7].Should().Be(Note.B));
		}
	}
}