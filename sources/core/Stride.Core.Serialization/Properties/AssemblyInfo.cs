// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Runtime.CompilerServices;

#pragma warning disable 436 // Stride.PublicKeys is defined in multiple assemblies

// Make internals Stride.Framework.visible to all Stride.Framework.assemblies
[assembly: InternalsVisibleTo("Stride.Core.Serialization.Serializers" + Stride.PublicKeys.Default)]
