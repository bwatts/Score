﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak.Xunit;
using FluentAssertions;

namespace Score.Examples
{
	public class MajorScales : Example
	{
		[Scenario]
		public void C()
		{
			When(Scale.Major.GetNotes(Note.C).ToList())
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

		[Scenario]
		public void D()
		{
			When(Scale.Major.GetNotes(Note.D).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.D))
			.Then(_ => _[1].Should().Be(Note.E))
			.Then(_ => _[2].Should().Be(Note.F.Sharp))
			.Then(_ => _[3].Should().Be(Note.G))
			.Then(_ => _[4].Should().Be(Note.A))
			.Then(_ => _[5].Should().Be(Note.B))
			.Then(_ => _[6].Should().Be(Note.C.Sharp))
			.Then(_ => _[7].Should().Be(Note.D));
		}

		[Scenario]
		public void E()
		{
			When(Scale.Major.GetNotes(Note.E).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.E))
			.Then(_ => _[1].Should().Be(Note.F.Sharp))
			.Then(_ => _[2].Should().Be(Note.G.Sharp))
			.Then(_ => _[3].Should().Be(Note.A))
			.Then(_ => _[4].Should().Be(Note.B))
			.Then(_ => _[5].Should().Be(Note.C.Sharp))
			.Then(_ => _[6].Should().Be(Note.D.Sharp))
			.Then(_ => _[7].Should().Be(Note.E));
		}

		[Scenario]
		public void F()
		{
			When(Scale.Major.GetNotes(Note.F).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.F))
			.Then(_ => _[1].Should().Be(Note.G))
			.Then(_ => _[2].Should().Be(Note.A))
			.Then(_ => _[3].Should().Be(Note.B.Flat))
			.Then(_ => _[4].Should().Be(Note.C))
			.Then(_ => _[5].Should().Be(Note.D))
			.Then(_ => _[6].Should().Be(Note.E))
			.Then(_ => _[7].Should().Be(Note.F));
		}

		[Scenario]
		public void G()
		{
			When(Scale.Major.GetNotes(Note.G).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.G))
			.Then(_ => _[1].Should().Be(Note.A))
			.Then(_ => _[2].Should().Be(Note.B))
			.Then(_ => _[3].Should().Be(Note.C))
			.Then(_ => _[4].Should().Be(Note.D))
			.Then(_ => _[5].Should().Be(Note.E))
			.Then(_ => _[6].Should().Be(Note.F.Sharp))
			.Then(_ => _[7].Should().Be(Note.G));
		}

		[Scenario]
		public void A()
		{
			When(Scale.Major.GetNotes(Note.A).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.A))
			.Then(_ => _[1].Should().Be(Note.B))
			.Then(_ => _[2].Should().Be(Note.C.Sharp))
			.Then(_ => _[3].Should().Be(Note.D))
			.Then(_ => _[4].Should().Be(Note.E))
			.Then(_ => _[5].Should().Be(Note.F.Sharp))
			.Then(_ => _[6].Should().Be(Note.G.Sharp))
			.Then(_ => _[7].Should().Be(Note.A));
		}

		[Scenario]
		public void B()
		{
			When(Scale.Major.GetNotes(Note.B).ToList())
			.Then(_ => _.Count.Should().Be(8))
			.Then(_ => _[0].Should().Be(Note.B))
			.Then(_ => _[1].Should().Be(Note.C.Sharp))
			.Then(_ => _[2].Should().Be(Note.D.Sharp))
			.Then(_ => _[3].Should().Be(Note.E))
			.Then(_ => _[4].Should().Be(Note.F.Sharp))
			.Then(_ => _[5].Should().Be(Note.G.Sharp))
			.Then(_ => _[6].Should().Be(Note.A.Sharp))
			.Then(_ => _[7].Should().Be(Note.B));
		}
	}
}