using System;
using System.Collections.Generic;
using SAL.Flatbed;

namespace SAL.Interface.Caching
{
	/// <summary>Plugin with public caching capability</summary>
	public interface ICachePlugin : IPlugin, IEnumerable<ICacheModule>
	{
		/// <summary>Number of modules created</summary>
		Int32 Count { get; }

		/// <summary>Get module for caching by name</summary>
		/// <param name="name">The module name</param>
		/// <returns>Module interface. If the module is not found, it should be created.</returns>
		ICacheModule this[String name] { get; }

		/// <summary>Remove module</summary>
		/// <param name="name">Name of the module to remove</param>
		/// <returns>The module has been successfully removed from the cache.</returns>
		Boolean Remove(String name);
	}
}