namespace ServiceStack.Redis.Configuration
{
	public interface ICommonSettings
	{
		int MaxWritePoolSize { get; }
		int MaxReadPoolSize { get; }
		bool AutoStart { get; }
		int InitialDb { get; }
		int PoolTimeOutSeconds { get; }
		int PoolSizeMultiplier { get; }
	}
}
