using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: Guid("c10f2c0a-f027-4ba7-9cf4-aa21c96120ad")]
[assembly: System.CLSCompliant(true)]

#if NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://github.com/DKorablin/SAL.Interface.Caching")]
#else

[assembly: AssemblyTitle("Interface.Caching")]
[assembly: AssemblyDescription("Base SAL interfaces for caching plugins")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Danila Korablin")]
[assembly: AssemblyProduct("Interface.Caching")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2016")]
#endif