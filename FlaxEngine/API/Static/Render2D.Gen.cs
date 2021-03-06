// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// The interface to render fast two dimensional graphics.
    /// </summary>
    public static partial class Render2D
    {
        /// <summary>
        /// Gets or sets the active rendering features flags.
        /// </summary>
        [UnmanagedCall]
        public static RenderingFeatures Features
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFeatures(); }
            set { Internal_SetFeatures(value); }
#endif
        }

        /// <summary>
        /// Pushes 2D transformation matrix on the stack.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void PushTransform(Matrix3x3 transform)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_PushTransform(ref transform);
#endif
        }

        /// <summary>
        /// Pops transformation matrix from the stack.
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void PopTransform()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_PopTransform();
#endif
        }

        /// <summary>
        /// Pushes clipping rectangle mask.
        /// </summary>
        /// <param name="clipRect">The axis aligned clipping mask rectangle.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void PushClip(Rectangle clipRect)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_PushClip(ref clipRect);
#endif
        }

        /// <summary>
        /// Pops clipping rectangle mask.
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void PopClip()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_PopClip();
#endif
        }

        /// <summary>
        /// Draws a text with formatting.
        /// </summary>
        /// <param name="font">The font to use.</param>
        /// <param name="text">The text to render.</param>
        /// <param name="color">The text color.</param>
        /// <param name="layout">The text layout properties.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawText(Font font, string text, Color color, ref TextLayoutOptions layout)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawText1(FlaxEngine.Object.GetUnmanagedPtr(font), text, ref color, ref layout);
#endif
        }

        /// <summary>
        /// Draws a text with formatting using a custom material shader. Given material must have GUI domain and a public parameter named Font (texture parameter used for a font atlas sampling).
        /// </summary>
        /// <param name="font">The font to use.</param>
        /// <param name="customMaterial">The custom material for font characters rendering. It must contain texture parameter named Font used to sample font texture.</param>
        /// <param name="text">The text to render.</param>
        /// <param name="color">The text color.</param>
        /// <param name="layout">The text layout properties.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawText(Font font, MaterialBase customMaterial, string text, Color color, ref TextLayoutOptions layout)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawText2(FlaxEngine.Object.GetUnmanagedPtr(font), FlaxEngine.Object.GetUnmanagedPtr(customMaterial), text, ref color, ref layout);
#endif
        }

        /// <summary>
        /// Draws a text.
        /// </summary>
        /// <param name="font">The font to use.</param>
        /// <param name="text">The text to render.</param>
        /// <param name="color">The text color.</param>
        /// <param name="location">The text location.</param>
        /// <param name="customMaterial">The custom material for font characters rendering. It must contain texture parameter named Font used to sample font texture.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawText(Font font, string text, Color color, Vector2 location, MaterialBase customMaterial = null)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawText3(FlaxEngine.Object.GetUnmanagedPtr(font), text, ref color, ref location, FlaxEngine.Object.GetUnmanagedPtr(customMaterial));
#endif
        }

        /// <summary>
        /// Draws a text.
        /// </summary>
        /// <param name="font">The font to use.</param>
        /// <param name="text">The text to render.</param>
        /// <param name="textRange">The text range to render.</param>
        /// <param name="color">The text color.</param>
        /// <param name="location">The text location.</param>
        /// <param name="customMaterial">The custom material for font characters rendering. It must contain texture parameter named Font used to sample font texture.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawText(Font font, string text, ref GUI.TextRange textRange, Color color, Vector2 location, MaterialBase customMaterial = null)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawText4(FlaxEngine.Object.GetUnmanagedPtr(font), text, ref textRange, ref color, ref location, FlaxEngine.Object.GetUnmanagedPtr(customMaterial));
#endif
        }

        /// <summary>
        /// Fills a rectangle area.
        /// </summary>
        /// <param name="rect">The rectangle to fill.</param>
        /// <param name="color">The color to use.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void FillRectangle(Rectangle rect, Color color)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_FillRectangle1(ref rect, ref color);
#endif
        }

        /// <summary>
        /// Fills a rectangle area.
        /// </summary>
        /// <param name="rect">The rectangle to fill.</param>
        /// <param name="color1">The color to use for upper left vertex.</param>
        /// <param name="color2">The color to use for upper right vertex.</param>
        /// <param name="color3">The color to use for bottom right vertex.</param>
        /// <param name="color4">The color to use for bottom left vertex.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void FillRectangle(Rectangle rect, Color color1, Color color2, Color color3, Color color4)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_FillRectangle2(ref rect, ref color1, ref color2, ref color3, ref color4);
#endif
        }

        /// <summary>
        /// Draws a rectangle borders.
        /// </summary>
        /// <param name="rect">The rectangle to draw.</param>
        /// <param name="color">The color to use.</param>
        /// <param name="thickness">The lines thickness.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawRectangle(Rectangle rect, Color color, float thickness = 1.0f)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawRectangle1(ref rect, ref color, thickness);
#endif
        }

        /// <summary>
        /// Draws a rectangle borders.
        /// </summary>
        /// <param name="rect">The rectangle to draw.</param>
        /// <param name="color1">The color to use for upper left vertex.</param>
        /// <param name="color2">The color to use for upper right vertex.</param>
        /// <param name="color3">The color to use for bottom right vertex.</param>
        /// <param name="color4">The color to use for bottom left vertex.</param>
        /// <param name="thickness">The lines thickness.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawRectangle(Rectangle rect, Color color1, Color color2, Color color3, Color color4, float thickness = 1.0f)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawRectangle2(ref rect, ref color1, ref color2, ref color3, ref color4, thickness);
#endif
        }

        /// <summary>
        /// Draws a texture.
        /// </summary>
        /// <param name="t">The GPU texture to draw.</param>
        /// <param name="rect">The rectangle to draw.</param>
        /// <param name="color">The color to use.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawTexture(GPUTexture t, Rectangle rect, Color color)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawTexture0(FlaxEngine.Object.GetUnmanagedPtr(t), ref rect, ref color);
#endif
        }

        /// <summary>
        /// Draws a texture.
        /// </summary>
        /// <param name="t">The texture to draw.</param>
        /// <param name="rect">The rectangle to draw.</param>
        /// <param name="color">The color to use.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawTexture(Texture t, Rectangle rect, Color color)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawTexture1(FlaxEngine.Object.GetUnmanagedPtr(t), ref rect, ref color);
#endif
        }

        /// <summary>
        /// Draws a texture,
        /// </summary>
        /// <param name="t">The texture to draw.</param>
        /// <param name="rect">The rectangle to draw.</param>
        /// <param name="color">The color to use.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawTexture(SpriteAtlas t, Rectangle rect, Color color)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawTexture2(FlaxEngine.Object.GetUnmanagedPtr(t), ref rect, ref color);
#endif
        }

        /// <summary>
        /// Draws a texture (uses point sampler).
        /// </summary>
        /// <param name="t">The texture to draw.</param>
        /// <param name="rect">The rectangle to draw.</param>
        /// <param name="color">The color to use.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawTexturePoint(Texture t, Rectangle rect, Color color)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawTexture3(FlaxEngine.Object.GetUnmanagedPtr(t), ref rect, ref color);
#endif
        }

        /// <summary>
        /// Draws a texture (uses point sampler).
        /// </summary>
        /// <param name="t">The texture to draw.</param>
        /// <param name="rect">The rectangle to draw.</param>
        /// <param name="color">The color to use.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawTexturePoint(SpriteAtlas t, Rectangle rect, Color color)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawTexture4(FlaxEngine.Object.GetUnmanagedPtr(t), ref rect, ref color);
#endif
        }

        /// <summary>
        /// Draws a line.
        /// </summary>
        /// <param name="p1">The start point.</param>
        /// <param name="p2">The end point.</param>
        /// <param name="color">The color to use.</param>
        /// <param name="thickness">The line thickness.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawLine(Vector2 p1, Vector2 p2, Color color, float thickness = 1.0f)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawLine1(ref p1, ref p2, ref color, thickness);
#endif
        }

        /// <summary>
        /// Draws a line.
        /// </summary>
        /// <param name="p1">The start point.</param>
        /// <param name="p2">The end point.</param>
        /// <param name="color1">The line start color.</param>
        /// <param name="color2">The line end color.</param>
        /// <param name="thickness">The line thickness.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawLine(Vector2 p1, Vector2 p2, Color color1, Color color2, float thickness = 1.0f)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawLine2(ref p1, ref p2, ref color1, ref color2, thickness);
#endif
        }

        /// <summary>
        /// Draws a Bezier curve.
        /// </summary>
        /// <param name="p1">The start point.</param>
        /// <param name="p2">The first control point.</param>
        /// <param name="p3">The second control point.</param>
        /// <param name="p4">The end point.</param>
        /// <param name="color">The color to use.</param>
        /// <param name="thickness">The line thickness.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawBezier(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Color color, float thickness = 1.0f)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawBezier(ref p1, ref p2, ref p3, ref p4, ref color, thickness);
#endif
        }

        /// <summary>
        /// Draws the GUI material in the 2D.
        /// </summary>
        /// <param name="material">The material to render. Must be a GUI material type.</param>
        /// <param name="rect">The target rectangle to draw.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawMaterial(MaterialBase material, Rectangle rect)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawMaterial1(FlaxEngine.Object.GetUnmanagedPtr(material), ref rect);
#endif
        }

        /// <summary>
        /// Draws the GUI material.
        /// </summary>
        /// <param name="material">The material to render. Must be a GUI material type.</param>
        /// <param name="rect">The target rectangle to draw.</param>
        /// <param name="color">The color to use.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawMaterial(MaterialBase material, Rectangle rect, Color color)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawMaterial2(FlaxEngine.Object.GetUnmanagedPtr(material), ref rect, ref color);
#endif
        }

        /// <summary>
        /// Draws the Gaussian-blur rectangle in the 2D that blurs the background.
        /// </summary>
        /// <param name="rect">The target rectangle to draw (blurs its background).</param>
        /// <param name="blurStrength">The blur strength defines how blurry the background is. Larger numbers increase blur, resulting in a larger runtime cost on the GPU.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DrawBlur(Rectangle rect, float blurStrength)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawBlur(ref rect, blurStrength);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern RenderingFeatures Internal_GetFeatures();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFeatures(RenderingFeatures val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_PushTransform(ref Matrix3x3 transform);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_PopTransform();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_PushClip(ref Rectangle clipRect);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_PopClip();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawText1(IntPtr font, string text, ref Color color, ref TextLayoutOptions layout);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawText2(IntPtr font, IntPtr customMaterial, string text, ref Color color, ref TextLayoutOptions layout);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawText3(IntPtr font, string text, ref Color color, ref Vector2 location, IntPtr customMaterial);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawText4(IntPtr font, string text, ref GUI.TextRange textRange, ref Color color, ref Vector2 location, IntPtr customMaterial);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_FillRectangle1(ref Rectangle rect, ref Color color);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_FillRectangle2(ref Rectangle rect, ref Color color1, ref Color color2, ref Color color3, ref Color color4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawRectangle1(ref Rectangle rect, ref Color color, float thickness);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawRectangle2(ref Rectangle rect, ref Color color1, ref Color color2, ref Color color3, ref Color color4, float thickness);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawTexture0(IntPtr t, ref Rectangle rect, ref Color color);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawTexture1(IntPtr t, ref Rectangle rect, ref Color color);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawTexture2(IntPtr t, ref Rectangle rect, ref Color color);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawTexture3(IntPtr t, ref Rectangle rect, ref Color color);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawTexture4(IntPtr t, ref Rectangle rect, ref Color color);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawLine1(ref Vector2 p1, ref Vector2 p2, ref Color color, float thickness);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawLine2(ref Vector2 p1, ref Vector2 p2, ref Color color1, ref Color color2, float thickness);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawBezier(ref Vector2 p1, ref Vector2 p2, ref Vector2 p3, ref Vector2 p4, ref Color color, float thickness);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawMaterial1(IntPtr material, ref Rectangle rect);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawMaterial2(IntPtr material, ref Rectangle rect, ref Color color);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawBlur(ref Rectangle rect, float blurStrength);
#endif

        #endregion
    }
}
