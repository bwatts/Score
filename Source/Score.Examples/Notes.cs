using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak.Xunit;
using FluentAssertions;

namespace Score.Examples
{
	public class Notes : Example
	{
		[Scenario]
		public void C()
		{
			When(Note.C)
			.Then(_ => _.PitchClass.Should().Be(0))
			.Then(_ => _.Name.Should().Be("C"))
			.Then(_ => _.Flat.Should().Be(Note.B))
			.Then(_ => _.Sharp.Should().Be(Note.D.Flat));
		}

		[Scenario]
		public void CSharp()
		{
			When(Note.C.Sharp)
			.Then(_ => _.PitchClass.Should().Be(1))
			.Then(_ => _.Name.Should().Be("C#/Db"));
		}

		[Scenario]
		public void D()
		{
			When(Note.D)
			.Then(_ => _.PitchClass.Should().Be(2))
			.Then(_ => _.Name.Should().Be("D"))
			.Then(_ => _.Flat.Should().Be(Note.C.Sharp))
			.Then(_ => _.Sharp.Should().Be(Note.E.Flat));
		}

		[Scenario]
		public void DSharp()
		{
			When(Note.D.Sharp)
			.Then(_ => _.PitchClass.Should().Be(3))
			.Then(_ => _.Name.Should().Be("D#/Eb"));
		}

		[Scenario]
		public void E()
		{
			When(Note.E)
			.Then(_ => _.PitchClass.Should().Be(4))
			.Then(_ => _.Name.Should().Be("E"))
			.Then(_ => _.Flat.Should().Be(Note.D.Sharp))
			.Then(_ => _.Sharp.Should().Be(Note.F));
		}

		[Scenario]
		public void F()
		{
			When(Note.F)
			.Then(_ => _.PitchClass.Should().Be(5))
			.Then(_ => _.Name.Should().Be("F"))
			.Then(_ => _.Flat.Should().Be(Note.E))
			.Then(_ => _.Sharp.Should().Be(Note.G.Flat));
		}

		[Scenario]
		public void FSharp()
		{
			When(Note.F.Sharp)
			.Then(_ => _.PitchClass.Should().Be(6))
			.Then(_ => _.Name.Should().Be("F#/Gb"));
		}

		[Scenario]
		public void G()
		{
			When(Note.G)
			.Then(_ => _.PitchClass.Should().Be(7))
			.Then(_ => _.Name.Should().Be("G"))
			.Then(_ => _.Flat.Should().Be(Note.F.Sharp))
			.Then(_ => _.Sharp.Should().Be(Note.A.Flat));
		}

		[Scenario]
		public void GSharp()
		{
			When(Note.G.Sharp)
			.Then(_ => _.PitchClass.Should().Be(8))
			.Then(_ => _.Name.Should().Be("G#/Ab"));
		}

		[Scenario]
		public void A()
		{
			When(Note.A)
			.Then(_ => _.PitchClass.Should().Be(9))
			.Then(_ => _.Name.Should().Be("A"))
			.Then(_ => _.Flat.Should().Be(Note.G.Sharp))
			.Then(_ => _.Sharp.Should().Be(Note.B.Flat));
		}

		[Scenario]
		public void ASharp()
		{
			When(Note.A.Sharp)
			.Then(_ => _.PitchClass.Should().Be(10))
			.Then(_ => _.Name.Should().Be("A#/Bb"));
		}

		[Scenario]
		public void B()
		{
			When(Note.B)
			.Then(_ => _.PitchClass.Should().Be(11))
			.Then(_ => _.Name.Should().Be("B"))
			.Then(_ => _.Flat.Should().Be(Note.A.Sharp))
			.Then(_ => _.Sharp.Should().Be(Note.C));
		}

		[Scenario]
		public void GetAll()
		{
			When(Note.All)
			.Then(_ => _.Count.Should().Be(Note.Count))
			.Then(_ => _[0].Should().Be(Note.C))
			.Then(_ => _[1].Should().Be(Note.C.Sharp))
			.Then(_ => _[2].Should().Be(Note.D))
			.Then(_ => _[3].Should().Be(Note.D.Sharp))
			.Then(_ => _[4].Should().Be(Note.E))
			.Then(_ => _[5].Should().Be(Note.F))
			.Then(_ => _[6].Should().Be(Note.F.Sharp))
			.Then(_ => _[7].Should().Be(Note.G))
			.Then(_ => _[8].Should().Be(Note.G.Sharp))
			.Then(_ => _[9].Should().Be(Note.A))
			.Then(_ => _[10].Should().Be(Note.A.Sharp))
			.Then(_ => _[11].Should().Be(Note.B));
		}
	}
}