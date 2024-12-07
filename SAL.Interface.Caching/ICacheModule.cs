using System;

namespace SAL.Interface.Caching
{
	public interface ICacheModule
	{
		/// <summary>Module name</summary>
		String Name { get; }

		/// <summary>Получить объект из кеша</summary>
		/// <typeparam name="T">Тип объекта получаемого из кеша</typeparam>
		/// <param name="key">Ключ по которому получить объект</param>
		/// <returns>Полученный объект из кеша</returns>
		T Get<T>(String key) where T : class;

		/// <summary>Получить объект из кеша и записать в кеш, если объекта нет</summary>
		/// <typeparam name="T">Тип объекта получаемого из кеша</typeparam>
		/// <param name="key">Ключ по которому получить объект</param>
		/// <param name="fallback">Функция обратного вызова получения данных, если элемента в кеше нет или он равен null</param>
		/// <param name="slidingExpiration">Плавающий временной интервал жизни объекта в кеше</param>
		/// <param name="absoluteExpiration">Фиксированная дата и время жизни объекта в кеше</param>
		/// <returns>Полученный объект из кеша</returns>
		T Get<T>(String key, Func<T> fallback, TimeSpan? slidingExpiration, DateTimeOffset? absoluteExpiration) where T : class;

		/// <summary>Положить объект в кеш</summary>
		/// <typeparam name="T">Тип объекта кидаемого в кеш</typeparam>
		/// <param name="key">Ключ, по которому записать объект в кеш</param>
		/// <param name="value">Данные для добавления в кеш</param>
		/// <param name="slidingExpiration">Плавающий временной интервал жизни объекта в кеше</param>
		/// <param name="absoluteExpiration">Фиксированная дата и время жизни объекта в кеше</param>
		void Add<T>(String key, T value, TimeSpan? slidingExpiration, DateTimeOffset? absoluteExpiration);

		/// <summary>Удалить объект из кеша по ключу</summary>
		/// <param name="key">Ключ по которому произвести удаление</param>
		void Remove(String key);
	}
}