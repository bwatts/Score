using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloak.Xunit
{
	public sealed class ScenarioBuilder
	{
		public static WhenBuilder<TContext> Given<TContext>(TContext context)
		{
			return new WhenBuilder<TContext>(context);
		}

		public static ScenarioBuilder.ThenBuilder<TContext> When<TContext>(TContext context)
		{
			return new ScenarioBuilder.ThenBuilder<TContext>(context);
		}

		public sealed class WhenBuilder<TContext>
		{
			private readonly TContext _context;

			public WhenBuilder(TContext context)
			{
				_context = context;
			}

			public ThenBuilder<TNewContext> When<TNewContext>(Func<TContext, TNewContext> act)
			{
				var newContext = act(_context);

				return new ThenBuilder<TNewContext>(newContext);
			}
		}

		public sealed class ThenBuilder<TContext>
		{
			private readonly TContext _context;

			public ThenBuilder(TContext context)
			{
				_context = context;
			}

			public ThenBuilder<TContext> Then(Action<TContext> assert)
			{
				assert(_context);

				return this;
			}
		}
	}
}