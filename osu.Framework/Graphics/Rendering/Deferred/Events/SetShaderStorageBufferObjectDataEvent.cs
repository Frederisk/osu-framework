// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Graphics.Rendering.Deferred.Allocation;

namespace osu.Framework.Graphics.Rendering.Deferred.Events
{
    internal readonly record struct SetShaderStorageBufferObjectDataEvent(RenderEventType Type, ResourceReference Buffer, int Index, MemoryReference Memory) : IRenderEvent
    {
        public static SetShaderStorageBufferObjectDataEvent Create<T>(DeferredRenderer renderer, IDeferredShaderStorageBufferObject buffer, int index, T data)
            where T : unmanaged, IEquatable<T>
            => new SetShaderStorageBufferObjectDataEvent(RenderEventType.SetShaderStorageBufferObjectData, renderer.Context.Reference(buffer), index, renderer.Context.AllocateObject(data));
    }
}
