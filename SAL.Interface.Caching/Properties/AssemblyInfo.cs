using System.Reflection;
using System.Runtime.InteropServices;

[assembly: Guid("c10f2c0a-f027-4ba7-9cf4-aa21c96120ad")]
[assembly: System.CLSCompliant(true)]

#if NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://github.com/DKorablin/SAL.Interface.Caching")]
#else

[assembly: AssemblyDescription("Base SAL interfaces for caching plugins")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2016-2024")]
#endif