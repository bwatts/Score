using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score
{
	public class DiatonicNoteSet : IEnumerable<Note>
	{
		public DiatonicNoteSet(Note root, Scale scale)
		{
			Contract.Requires(root != null);
			Contract.Requires(scale != null);

			var notes = scale.GetNotes(root).ToList();

			if(notes.Count != 8 || root != notes[0] || root != notes[7])
			{
				throw new ArgumentException(Resources.DiatonicNoteSetRequirements, "scale");
			}

			Root = root;
			Second = notes[1];
			Third = notes[2];
			Fourth = notes[3];
			Fifth = notes[4];
			Sixth = notes[5];
			Seventh = notes[6];
		}

		public IEnumerator<Note> GetEnumerator()
		{
			yield return Root;
			yield return Second;
			yield return Third;
			yield return Fourth;
			yield return Fifth;
			yield return Sixth;
			yield return Seventh;
			yield return Root;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public Note Root { get; private set; }

		public Note Second { get; private set; }

		public Note Third { get; private set; }

		public Note Fourth { get; private set; }

		public Note Fifth { get; private set; }

		public Note Sixth { get; private set; }

		public Note Seventh { get; private set; }

		public Note GetNote(ScaleDegree degree)
		{
			switch(degree)
			{
				case ScaleDegree.Number1:
					return Root;
				case ScaleDegree.Number2:
					return Second;
				case ScaleDegree.Number3:
					return Third;
				case ScaleDegree.Number4:
					return Fourth;
				case ScaleDegree.Number5:
					return Fifth;
				case ScaleDegree.Number6:
					return Sixth;
				case ScaleDegree.Number7:
					return Seventh;
				default:
					throw new NotSupportedException("Unsupported scale degree: " + degree.ToString());
			}
		}
	}
}