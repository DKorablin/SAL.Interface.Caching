using System;
using System.Collections.Generic;
using SAL.Flatbed;

namespace SAL.Interface.Caching
{
	/// <summary>Плагин с возможностью кеширования</summary>
	public interface ICachePlugin : IPlugin, IEnumerable<ICacheModule>
	{
		/// <summary>Количество созданных модулей</summary>
		Int32 Count { get; }

		/// <summary>Получить модуль для кеширования по наименованию</summary>
		/// <param name="name">Наименование модуля</param>
		/// <returns>Интерфейс модуля. Если модуль не найден, то он будет создан</returns>
		ICacheModule this[String name] { get; }

		/// <summary>Удалить модуль</summary>
		/// <param name="name">Наименованиие модуля для удаления</param>
		/// <returns>Модуль успешно удалён из кеша</returns>
		Boolean Remove(String name);
	}
}