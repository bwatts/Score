using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Cloak.Xunit
{
	public abstract class Example
	{
		protected ScenarioBuilder.WhenBuilder<TContext> Given<TContext>(TContext context)
		{
			return ScenarioBuilder.Given(context);
		}

		public ScenarioBuilder.ThenBuilder<TContext> When<TContext>(TContext context)
		{
			return ScenarioBuilder.When(context);
		}
	}
}