using System.Configuration;
using System.Linq;

namespace ServiceStack.Redis.Configuration
{
	public class RedisClientManagerConfiguration : ConfigurationSection, IRedisClientManagerConfiguration
	{
		private static object _locker = new object();

		private const string ConfigurationSectionKey = "serviceStack.redis";
		private const string CommonSettingsConfigKey = "commonSettings";
		private const string ReadWriteHostsConfigKey = "readWriteHosts";
		private const string ReadOnlyHostsConfigKey = "readOnlyHosts";

		private static volatile RedisClientManagerConfiguration _instance;

		private RedisClientManagerConfiguration() { }

		public static IRedisClientManagerConfiguration Instance
		{
			get {
				if (_instance == null)
					lock (_locker)
					{
						if (_instance == null)
						{
							_instance = (RedisClientManagerConfiguration)ConfigurationManager.GetSection(ConfigurationSectionKey);		
						}
					}
				return _instance;
			}
		}

		[ConfigurationProperty(CommonSettingsConfigKey)]
		public CommonSettings CommonSettings
		{
			get { return (CommonSettings)this[CommonSettingsConfigKey]; }
		}

		[ConfigurationProperty(ReadWriteHostsConfigKey)]
		public Hosts ReadWriteHosts
		{
			get { return (Hosts)this[ReadWriteHostsConfigKey]; }
		}

		[ConfigurationProperty(ReadOnlyHostsConfigKey)]
		public Hosts ReadOnlyHosts
		{
			get { return (Hosts)this[ReadOnlyHostsConfigKey]; }
		}

		#region IRedisClientManagerConfiguration Members

		ICommonSettings IRedisClientManagerConfiguration.CommonSettings {
			get
			{
				return CommonSettings;
			}
		}

		string[] IRedisClientManagerConfiguration.ReadWriteHosts
		{
			get
			{
				return ReadWriteHosts.AllHosts.ToArray();
			}
		}
		string[] IRedisClientManagerConfiguration.ReadOnlyHosts
		{
			get
			{
				return ReadOnlyHosts.AllHosts.ToArray();
			}
		}

		#endregion
	}
}
