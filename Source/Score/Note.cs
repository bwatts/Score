using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloak;

namespace Score
{
	public sealed class Note
	{
		public const int Count = 12;

		static Note()
		{
			SetSharps();

			SetFlats();

			SetAll();

			//SetMajorKeys();

			//SetMinorKeys();
		}

		public static readonly Note C = new Note(0, "C");
		public static readonly Note D = new Note(2, "D");
		public static readonly Note E = new Note(4, "E");
		public static readonly Note F = new Note(5, "F");
		public static readonly Note G = new Note(7, "G");
		public static readonly Note A = new Note(9, "A");
		public static readonly Note B = new Note(11, "B");

		public static ReadOnlyCollection<Note> All { get; private set; }

		public static Note FromPitchClass(int pitchClass)
		{
			Contract.Requires(pitchClass >= 0 && pitchClass < Count);

			return All[pitchClass];
		}

		private static void SetSharps()
		{
			C.Sharp = new Note(1, C, D);
			D.Sharp = new Note(3, D, E);
			E.Sharp = F;
			F.Sharp = new Note(6, F, G);
			G.Sharp = new Note(8, G, A);
			A.Sharp = new Note(10, A, B);
			B.Sharp = C;
		}

		private static void SetFlats()
		{
			C.Flat = B;
			D.Flat = C.Sharp;
			E.Flat = D.Sharp;
			F.Flat = E;
			G.Flat = F.Sharp;
			A.Flat = G.Sharp;
			B.Flat = A.Sharp;
		}

		private static void SetAll()
		{
			All = new List<Note> { C, C.Sharp, D, D.Sharp, E, F, F.Sharp, G, G.Sharp, A, A.Sharp, B }.AsReadOnly();
		}

		//private static void SetMajorKeys()
		//{
		//	C.MajorKey = new Key(Note.C, KeyScale.Major);
		//	D.MajorKey = new Key(Note.D, KeyScale.Major);
		//	E.MajorKey = new Key(Note.E, KeyScale.Major);
		//	F.MajorKey = new Key(Note.F, KeyScale.Major);
		//	G.MajorKey = new Key(Note.G, KeyScale.Major);
		//	A.MajorKey = new Key(Note.A, KeyScale.Major);
		//	B.MajorKey = new Key(Note.B, KeyScale.Major);

		//	C.Sharp.MajorKey = new Key(Note.C.Sharp, KeyScale.Major);
		//	D.Sharp.MajorKey = new Key(Note.D.Sharp, KeyScale.Major);
		//	F.Sharp.MajorKey = new Key(Note.F.Sharp, KeyScale.Major);
		//	G.Sharp.MajorKey = new Key(Note.G.Sharp, KeyScale.Major);
		//	A.Sharp.MajorKey = new Key(Note.A.Sharp, KeyScale.Major);
		//}

		//private static void SetMinorKeys()
		//{
		//	C.MinorKey = new Key(Note.C, KeyScale.Minor);
		//	D.MinorKey = new Key(Note.D, KeyScale.Minor);
		//	E.MinorKey = new Key(Note.E, KeyScale.Minor);
		//	F.MinorKey = new Key(Note.F, KeyScale.Minor);
		//	G.MinorKey = new Key(Note.G, KeyScale.Minor);
		//	A.MinorKey = new Key(Note.A, KeyScale.Minor);
		//	B.MinorKey = new Key(Note.B, KeyScale.Minor);

		//	C.Sharp.MinorKey = new Key(Note.C.Sharp, KeyScale.Minor);
		//	D.Sharp.MinorKey = new Key(Note.D.Sharp, KeyScale.Minor);
		//	F.Sharp.MinorKey = new Key(Note.F.Sharp, KeyScale.Minor);
		//	G.Sharp.MinorKey = new Key(Note.G.Sharp, KeyScale.Minor);
		//	A.Sharp.MinorKey = new Key(Note.A.Sharp, KeyScale.Minor);
		//}

		public static Note operator +(Note note, Interval interval)
		{
			var incrementedPitchClass = note.PitchClass + interval.HalfSteps;

			return FromPitchClass(incrementedPitchClass % Count);
		}

		public static Note operator -(Note note, Interval interval)
		{
			var decrementedPitchClass = (note.PitchClass - interval.HalfSteps) % Count;

			if(decrementedPitchClass < 0)
			{
				decrementedPitchClass += Count;
			}

			return FromPitchClass(decrementedPitchClass);
		}

		private Note(int pitchClass, string name)
		{
			PitchClass = pitchClass;
			Name = name;
		}

		private Note(int pitchClass, Note flat, Note sharp)
		{
			PitchClass = pitchClass;
			Flat = flat;
			Sharp = sharp;

			Name = Resources.DualNoteName.FormatInvariant(flat, sharp);
		}

		public int PitchClass { get; private set; }

		public string Name { get; private set; }

		public Note Flat { get; private set; }

		public Note Sharp { get; private set; }

		//public Key MajorKey { get; private set; }

		//public Key MinorKey { get; private set; }

		public override string ToString()
		{
			return Name;
		}
	}
}