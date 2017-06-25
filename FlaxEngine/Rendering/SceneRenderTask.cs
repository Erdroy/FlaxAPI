﻿////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

namespace FlaxEngine.Rendering
{
    /// <summary>
    /// Render task which draws scene actors into the output buffer.
    /// </summary>
    /// <seealso cref="FlaxEngine.Rendering.RenderTask" />
    public class SceneRenderTask : RenderTask
    {
        // TODO: override 'void DrawActors(GPUContext* context, RenderView& view)'

        internal SceneRenderTask()
        {
        }

        internal override void Internal_Render(GPUContext context)
        {
            context.Clear(Output, Color.Pink);
        }
    }
}
