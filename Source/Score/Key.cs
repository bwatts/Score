using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score
{
	public sealed class Key : DiatonicNoteSet
	{
		public Key(Note root, KeyScale keyScale) : base(root, GetScale(keyScale))
		{
			KeyScale = keyScale;
		}

		public KeyScale KeyScale { get; private set; }

		private static Scale GetScale(KeyScale keyScale)
		{
			switch(keyScale)
			{
				case KeyScale.Major:
					return Scale.Major;
				case KeyScale.Minor:
					return Scale.Minor;
				default:
					throw new NotSupportedException("Unsupported key scale type: " + keyScale.ToString());
			}
		}
	}
}