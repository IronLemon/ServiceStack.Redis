namespace ServiceStack.Redis.Configuration
{
	public interface IRedisClientManagerConfiguration
	{
		ICommonSettings CommonSettings { get; }
		string[] ReadWriteHosts { get; }
		string[] ReadOnlyHosts { get; }
	}
}
