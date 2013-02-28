using System.Configuration;

namespace ServiceStack.Redis.Configuration
{
	public class Host : ConfigurationElement
	{
		private const string AddressConfigKey = "address";
		private const string PortConfigKey = "port";

		private const string FullAddressFormat = "{0}:{1}";

		[ConfigurationProperty(AddressConfigKey, IsRequired = true)]
		public string Address
		{
			get { return (string)this[AddressConfigKey]; }
		}

		[ConfigurationProperty(PortConfigKey)]
		public string Port
		{
			get { return (string)this[PortConfigKey]; }
		}

		public string FullAddress
		{
			get
			{
				return string.IsNullOrEmpty(Port) ? Address : string.Format(FullAddressFormat, Address, Port);
			}
		}
	}
}
