using System;

namespace SAL.Interface.Caching
{
	/// <summary>Cache module interface to use by SAL plugin group instance</summary>
	public interface ICacheModule
	{
		/// <summary>The module name</summary>
		/// <remarks>Should be used to describe cache server used by SAL plugin</remarks>
		String Name { get; }

		/// <summary>Get object from cache</summary>
		/// <typeparam name="T">The type of the object stored in the cache</typeparam>
		/// <param name="key">The key by which to get the object</param>
		/// <returns>Received object from cache</returns>
		T Get<T>(String key) where T : class;

		/// <summary>Get object from cache and write to cache if object is not present</summary>
		/// <typeparam name="T">The type of object retrieved from the cache</typeparam>
		/// <param name="key">The key by which to get or write the object</param>
		/// <param name="fallback">Callback function to retrieve data if the item is not in the cache or is null</param>
		/// <param name="slidingExpiration">Sliding time interval for the life of an object in the cache</param>
		/// <param name="absoluteExpiration">Fixed date and time of life of an object in the cache</param>
		/// <returns>Received object from cache or from the callback function</returns>
		T Get<T>(String key, Func<T> fallback, TimeSpan? slidingExpiration, DateTimeOffset? absoluteExpiration) where T : class;

		/// <summary>Put object in cache</summary>
		/// <typeparam name="T">The type of object thrown into the cache</typeparam>
		/// <param name="key">The key by which to write the object to the cache</param>
		/// <param name="value">Data to add to cache</param>
		/// <param name="slidingExpiration">Sliding time interval for the life of an object in the cache</param>
		/// <param name="absoluteExpiration">Fixed date and time of life of an object in the cache</param>
		void Add<T>(String key, T value, TimeSpan? slidingExpiration, DateTimeOffset? absoluteExpiration);

		/// <summary>Remove an object from cache by key</summary>
		/// <param name="key">The key to perform the deletion</param>
		void Remove(String key);
	}
}