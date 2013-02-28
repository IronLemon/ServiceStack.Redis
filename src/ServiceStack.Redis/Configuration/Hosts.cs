using System.Collections.Generic;
using System.Configuration;

namespace ServiceStack.Redis.Configuration
{
	public class Hosts : ConfigurationElementCollection
	{
		protected override ConfigurationElement CreateNewElement()
		{
			return new Host();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((Host)element).FullAddress;
		}

		public Host this[int index]
		{
			get { return (Host)BaseGet(index); }
			set
			{
				if (BaseGet(index) != null)
					BaseRemoveAt(index);
				BaseAdd(index, value);
			}
		}

		public new Host this[string name]
		{
			get { return (Host)BaseGet(name); }
		}

		public IEnumerable<string> AllHosts
		{
			get
			{
				foreach (Host host in this)
				{
					yield return host.FullAddress;
				}
			}
		}
	}
}
