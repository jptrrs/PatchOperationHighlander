using System.Collections.Generic;
using System.Xml;

namespace PatchOperation
{
    public class FindModByID : Verse.PatchOperation
    {
        List<string> mods = null;

		bool all = false;

		Verse.PatchOperation match = null;

		Verse.PatchOperation nomatch = null;

        protected override bool ApplyWorker(XmlDocument xml)
        {
			
			if (Highlander.IsActiveByID(mods, all))
			{
				if (match != null)
				{
					return match.Apply(xml);
				}
			}
			else if (nomatch != null)
			{
				return nomatch.Apply(xml);
			}

			return true;
        }
    }
}