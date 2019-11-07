using System;
using System.Collections.Generic;
using System.Text;
using Engage.A;

namespace Engage.front
{
    partial class Parser
    {
		public static EngSpec ParseEngSpec(string code)
		{
			EngageMetaParser parser = new EngageMetaParser ();
			return parser.parseGrammar (code);
		}
    }
}
