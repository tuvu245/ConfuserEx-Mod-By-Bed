using System.Reflection;

[assembly: AssemblyProduct("Beds Protector")]
[assembly: AssemblyCompany("Bed")]
[assembly: AssemblyCopyright("Copyright (C) K019")]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]
#else

[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyVersion("1.1.0")]
[assembly: AssemblyFileVersion("1.1.0")]
[assembly: AssemblyInformationalVersion("v1.1 | Public Version")]