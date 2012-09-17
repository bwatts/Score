using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score
{
	[ContractClass(typeof(ScaleContract))]
	public abstract class Scale
	{
		public static readonly Scale Major = new MajorScale();
		public static readonly Scale Minor = new MinorScale();

		public IEnumerable<Note> GetNotes(Note root)
		{
			Contract.Requires(root != null);

			var currentNote = root;

			foreach(var interval in GetIntervals(root))
			{
				yield return currentNote;

				currentNote += interval;
			}

			yield return root;
		}

		protected abstract IEnumerable<Interval> GetIntervals(Note root);

		private sealed class MajorScale : Scale
		{
			protected override IEnumerable<Interval> GetIntervals(Note root)
			{
				return new[]
				{
					Interval.WholeStep,
					Interval.WholeStep,
					Interval.HalfStep,
					Interval.WholeStep,
					Interval.WholeStep,
					Interval.WholeStep,
					Interval.HalfStep
				};
			}
		}

		private sealed class MinorScale : Scale
		{
			protected override IEnumerable<Interval> GetIntervals(Note root)
			{
				return new[]
				{
					Interval.WholeStep,
					Interval.HalfStep,
					Interval.WholeStep,
					Interval.WholeStep,
					Interval.HalfStep,
					Interval.WholeStep,
					Interval.WholeStep
				};
			}
		}

		[ContractClassFor(typeof(Scale))]
		internal abstract class ScaleContract : Scale
		{
			protected override IEnumerable<Interval> GetIntervals(Note root)
			{
				Contract.Ensures(Contract.Result<IEnumerable<Interval>>() != null);

				return null;
			}
		}
	}
}