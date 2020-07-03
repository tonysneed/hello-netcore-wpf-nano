# Hello .NET Core with WPF in Docker on Nano Server

Demo of running a .NET Core console app with WPF in Docker on Nano Server

## Console App Using WPF on .NET Core 3.1

1. Create a WPF Library for .NET Core.
2. Convert to a console app.
   - Edit .csproj file to add `<OutputType>Exe</OutputType>`
3. Add `Program` class with static `Main` method.
4. Import `System.Windows.Media.Media3D` namespace, use 3D geometry.

## Dockerized App on Windows Nano Server

1. Use `tonysneed/dotnet-runtime-windowsdesktop:3.1-nanoserver-1909` for base image
   - Nano Server with Windows Desktop runtime installed.
