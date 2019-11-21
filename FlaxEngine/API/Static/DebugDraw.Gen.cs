// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// The debug shapes rendering service. Not available in build game. For use only in the editor.
    /// </summary>
    public static partial class DebugDraw
    {
        /// <summary>
        /// Draws the line.
        /// </summary>
        /// <param name="start">The start point.</param>
        /// <param name="end">The end point.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawLine(ref start, ref end, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the wireframe box.
        /// </summary>
        /// <param name="box">The box.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawWireBox(BoundingBox box, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawWireBoundingBox(ref box, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the box.
        /// </summary>
        /// <param name="box">The box.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawBox(BoundingBox box, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawBoundingBox(ref box, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the wireframe frustum.
        /// </summary>
        /// <param name="frustum">The frustum.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawWireFrustum(BoundingFrustum frustum, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawWireFrustum(ref frustum, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the wireframe box.
        /// </summary>
        /// <param name="box">The box.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawWireBox(OrientedBoundingBox box, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawWireOrientedBoundingBox(ref box, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the box.
        /// </summary>
        /// <param name="box">The box.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawBox(OrientedBoundingBox box, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawOrientedBoundingBox(ref box, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the wireframe sphere.
        /// </summary>
        /// <param name="position">The center position.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawWireSphere(Vector3 position, float radius, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawWireSphere(ref position, radius, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the sphere.
        /// </summary>
        /// <param name="position">The center position.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawSphere(Vector3 position, float radius, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawSphere(ref position, radius, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the wireframe triangle.
        /// </summary>
        /// <param name="v0">The first triangle vertex.</param>
        /// <param name="v1">The second triangle vertex.</param>
        /// <param name="v2">The third triangle vertex.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawWireTriangle(Vector3 v0, Vector3 v1, Vector3 v2, float radius, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawWireTriangle(ref v0, ref v1, ref v2, radius, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the triangle.
        /// </summary>
        /// <param name="v0">The first triangle vertex.</param>
        /// <param name="v1">The second triangle vertex.</param>
        /// <param name="v2">The third triangle vertex.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawTriangle(Vector3 v0, Vector3 v1, Vector3 v2, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawTriangle(ref v0, ref v1, ref v2, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the triangles.
        /// </summary>
        /// <param name="vertices">The triangle vertices buffer (3 vertices per triangle).</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawTriangles(Vector3[] vertices, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawTriangles1(vertices, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the triangles.
        /// </summary>
        /// <param name="vertices">The triangle vertices buffer.</param>
        /// <param name="indices">The triangle indices buffer (3 indices per triangle).</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawTriangles(Vector3[] vertices, int[] indices, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawTriangles2(vertices, indices, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the circle.
        /// </summary>
        /// <param name="position">The center position.</param>
        /// <param name="normal">The normal vector direction.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawCircle(Vector3 position, Vector3 normal, float radius, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawCircle(ref position, ref normal, radius, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the wireframe tube.
        /// </summary>
        /// <param name="position">The center position.</param>
        /// <param name="orientation">The orientation.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="length">The length.</param>
        /// <param name="color">The color.</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawWireTube(Vector3 position, Quaternion orientation, float radius, float length, Color color, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawWireTube(ref position, ref orientation, radius, length, ref color, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the wireframe arrow.
        /// </summary>
        /// <param name="position">The arrow origin position.</param>
        /// <param name="orientation">The orientation (defines the arrow direction).</param>
        /// <param name="color">The color.</param>
        /// <param name="scale">The arrow scale (used to adjust the arrow size).</param>
        /// <param name="duration">The duration (in seconds). Use 0 to draw it only once.</param>
        /// <param name="depthTest">If set to <c>true</c> depth test will be performed, otherwise depth will be ignored.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawWireArrow(Vector3 position, Quaternion orientation, Color color, float scale = 1.0f, float duration = 0.0f, bool depthTest = true)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawWireArrow(ref position, ref orientation, ref color, scale, duration, depthTest);
#endif
        }

        /// <summary>
        /// Draws the debug shapes to the custom texture using given GPU command context.
        /// </summary>
        /// <param name="task">The calling rendering task.</param>
        /// <param name="selectedActors">The selected actors.</param>
        /// <param name="target">The rendering output surface.</param>
        /// <param name="context">The GPU commands context.</param>
        /// <param name="depthBuffer">The custom depth texture used for depth test. Can be MSAA. Must match target surface size.</param>
        /// <param name="enableDepthTest">True if perform manual depth test with scene depth buffer when rendering the primitives. Uses custom shader and the scene depth buffer.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void Draw(FlaxEngine.RenderTask task, IntPtr[] selectedActors, FlaxEngine.RenderTarget target = null, GPUContext context = null, FlaxEngine.RenderTarget depthBuffer = null, bool enableDepthTest = false)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_Draw(FlaxEngine.Object.GetUnmanagedPtr(task), selectedActors, FlaxEngine.Object.GetUnmanagedPtr(target), FlaxEngine.Object.GetUnmanagedPtr(context), FlaxEngine.Object.GetUnmanagedPtr(depthBuffer), enableDepthTest);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawLine(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawWireBoundingBox(ref BoundingBox box, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawBoundingBox(ref BoundingBox box, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawWireFrustum(ref BoundingFrustum frustum, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawWireOrientedBoundingBox(ref OrientedBoundingBox box, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawOrientedBoundingBox(ref OrientedBoundingBox box, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawWireSphere(ref Vector3 position, float radius, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawSphere(ref Vector3 position, float radius, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawWireTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, float radius, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawTriangles1(Vector3[] vertices, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawTriangles2(Vector3[] vertices, int[] indices, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawCircle(ref Vector3 position, ref Vector3 normal, float radius, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawWireTube(ref Vector3 position, ref Quaternion orientation, float radius, float length, ref Color color, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawWireArrow(ref Vector3 position, ref Quaternion orientation, ref Color color, float scale, float duration, bool depthTest);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Draw(IntPtr task, IntPtr[] selectedActors, IntPtr target, IntPtr context, IntPtr depthBuffer, bool enableDepthTest);
#endif

        #endregion
    }
}
