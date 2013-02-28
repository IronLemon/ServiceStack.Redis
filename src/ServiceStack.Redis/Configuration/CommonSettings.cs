using System.Configuration;

namespace ServiceStack.Redis.Configuration
{
	public class CommonSettings : ConfigurationElement, ICommonSettings
	{
		private const string MaxWritePoolSizeConfigKey = "maxWritePoolSize";
		private const string MaxReadPoolSizeConfigKey = "maxReadPoolSize";
		private const string AutoStartConfigKey = "autoStart";
		private const string InitialDbConfigKey = "initialDb";
		private const string PoolTimeOutSecondsConfigKey = "poolTimeOutSeconds";
		private const string PoolSizeMultiplierConfigKey = "poolSizeMultiplier";

		[ConfigurationProperty(MaxWritePoolSizeConfigKey)]
		public int MaxWritePoolSize
		{
			get { return (int)this[MaxWritePoolSizeConfigKey]; }
		}

		[ConfigurationProperty(MaxReadPoolSizeConfigKey)]
		public int MaxReadPoolSize
		{
			get { return (int)this[MaxReadPoolSizeConfigKey]; }
		}

		[ConfigurationProperty(AutoStartConfigKey)]
		public bool AutoStart
		{
			get { return (bool)this[AutoStartConfigKey]; }
		}

		[ConfigurationProperty(InitialDbConfigKey)]
		public int InitialDb
		{
			get { return (int)this[InitialDbConfigKey]; }
		}

		[ConfigurationProperty(PoolTimeOutSecondsConfigKey)]
		public int PoolTimeOutSeconds
		{
			get { return (int)this[PoolTimeOutSecondsConfigKey]; }
		}

		[ConfigurationProperty(PoolSizeMultiplierConfigKey)]
		public int PoolSizeMultiplier
		{
			get { return (int)this[PoolSizeMultiplierConfigKey]; }
		}
	}
}
