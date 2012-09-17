using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score
{
	public sealed class Mode
	{
		public static readonly Mode Ionian = new Mode(ScaleDegree.Number1, null);
		public static readonly Mode Dorian;
		public static readonly Mode Phrygian;
		public static readonly Mode Lydian;
		public static readonly Mode Mixolydian;
		public static readonly Mode Aeolian = new Mode(ScaleDegree.Number6, Ionian);
		public static readonly Mode Locrian;

		static Mode()
		{
			Dorian = new Mode(ScaleDegree.Number2, Aeolian);
			Phrygian = new Mode(ScaleDegree.Number3, Aeolian);
			Lydian = new Mode(ScaleDegree.Number4, Ionian);
			Mixolydian = new Mode(ScaleDegree.Number5, Ionian);
			Locrian = new Mode(ScaleDegree.Number7, Aeolian);

			Dorian.Sharpen(ScaleDegree.Number6);

			Phrygian.Flatten(ScaleDegree.Number2);

			Lydian.Sharpen(ScaleDegree.Number4);

			Mixolydian.Flatten(ScaleDegree.Number7);

			Aeolian.Flatten(ScaleDegree.Number3);
			Aeolian.Flatten(ScaleDegree.Number6);
			Aeolian.Flatten(ScaleDegree.Number7);

			Locrian.Flatten(ScaleDegree.Number2);
			Locrian.Flatten(ScaleDegree.Number5);
		}

		private readonly NoteQuality[] _noteQualities = new NoteQuality[7];

		private Mode(ScaleDegree scaleDegree, Mode baseMode)
		{
			ScaleDegree = scaleDegree;
			BaseMode = baseMode;

			Scale = baseMode == null ? Scale.Major : new ModeScale(this, baseMode);
		}

		public ScaleDegree ScaleDegree { get; private set; }

		public Mode BaseMode { get; private set; }

		public Scale Scale { get; private set; }

		public DiatonicNoteSet GetNotes(Key key)
		{
			Contract.Requires(key != null);

			return new DiatonicNoteSet(key.GetNote(ScaleDegree), Scale);
		}

		private void Sharpen(ScaleDegree degree)
		{
			SetDegreeQuality(degree, NoteQuality.Sharp);
		}

		private void Flatten(ScaleDegree degree)
		{
			SetDegreeQuality(degree, NoteQuality.Flat);
		}

		private void SetDegreeQuality(ScaleDegree degree, NoteQuality quality)
		{
			_noteQualities[(int) degree] = quality;
		}

		private sealed class ModeScale : Scale
		{
			private readonly Mode _mode;
			private readonly Mode _baseMode;

			internal ModeScale(Mode mode, Mode baseMode)
			{
				_mode = mode;
				_baseMode = baseMode;
			}

			protected override IEnumerable<Interval> GetIntervals(Note root)
			{
				// TODO: Calculate mode intervals

				throw new NotImplementedException();
			}

			private IEnumerable<Note> GetBaseModeNotes(Note root)
			{
				return _baseMode.Scale.GetNotes(root);
			}

			private Note ApplyQuality(Note note, int degreeIndex)
			{
				var quality = _mode._noteQualities[degreeIndex];

				switch(quality)
				{
					case NoteQuality.Natural:
						return note;
					case NoteQuality.Flat:
						return note.Flat;
					case NoteQuality.Sharp:
						return note.Sharp;
					default:
						throw new NotSupportedException("Unsupported note quality: " + quality.ToString());
				}
			}
		}
	}
}