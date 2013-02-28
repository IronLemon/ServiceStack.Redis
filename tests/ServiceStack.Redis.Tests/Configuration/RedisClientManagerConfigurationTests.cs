using NUnit.Framework;
using ServiceStack.Redis.Configuration;

namespace ServiceStack.Redis.Tests.Configuration
{
	[TestFixture]
	public class RedisClientManagerConfigurationTests
	{
		private ICommonSettings CommonSettings
		{
			get
			{
				return RedisClientManagerConfiguration.Instance.CommonSettings;
			}
		}

		[Test]
		public void Should_Initialize_MaxWritePoolSize()
		{
			Assert.AreEqual(100, CommonSettings.MaxWritePoolSize);
		}

		[Test]
		public void Should_Initialize_MaxReadPoolSize()
		{
			Assert.AreEqual(500, CommonSettings.MaxReadPoolSize);
		}

		[Test]
		public void Should_Initialize_AutoStart()
		{
			Assert.IsTrue(CommonSettings.AutoStart);
		}

		[Test]
		public void Should_Initialize_InitialDb()
		{
			Assert.AreEqual(1, CommonSettings.InitialDb);
		}

		[Test]
		public void Should_Initialize_PoolTimeOutSeconds()
		{
			Assert.AreEqual(30, CommonSettings.PoolTimeOutSeconds);
		}

		[Test]
		public void Should_Initialize_PoolSizeMultiplier()
		{
			Assert.AreEqual(5, CommonSettings.PoolSizeMultiplier);
		}

		[Test]
		public void Should_Initialize_ReadWriteHosts()
		{
			string[] actualReadWriteHosts = RedisClientManagerConfiguration.Instance.ReadWriteHosts;

			Assert.AreEqual(2, actualReadWriteHosts.Length);
			Assert.AreEqual("127.0.0.1:6379", actualReadWriteHosts[0]);
			Assert.AreEqual("127.0.0.1", actualReadWriteHosts[1]);
		}

		[Test]
		public void Should_Initialize_ReadOnlyHosts()
		{
			string[] actualReadOnlyHosts = RedisClientManagerConfiguration.Instance.ReadOnlyHosts;

			Assert.AreEqual(2, actualReadOnlyHosts.Length);
			Assert.AreEqual("localhost", actualReadOnlyHosts[0]);
			Assert.AreEqual("127.0.0.1:6379", actualReadOnlyHosts[1]);
		}
	}
}
