// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// Scene animation timeline for animating objects and playing cut-scenes.
    /// </summary>
    public sealed partial class SceneAnimation : BinaryAsset
    {
        /// <summary>
        /// Creates new <see cref="SceneAnimation"/> object.
        /// </summary>
        private SceneAnimation() : base()
        {
        }

        /// <summary>
        /// Gets the frames amount per second of the timeline animation.
        /// </summary>
        [UnmanagedCall]
        public float FramesPerSecond
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFramesPerSecond(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets the animation duration (in frames).
        /// </summary>
        [UnmanagedCall]
        public int DurationFrames
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDurationFrames(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets the animation duration (in seconds).
        /// </summary>
        [UnmanagedCall]
        public float Duration
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDuration(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Loads the scene animation timeline data from the asset.
        /// </summary>
        /// <returns>Loaded timeline bytes or null if cannot load it.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public byte[] LoadTimeline()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_LoadTimeline(unmanagedPtr);
#endif
        }

        /// <summary>
        /// Saves the scene animation timeline data. Timeline is saved to the asset and then asset is reloaded.
        /// </summary>
        /// <remarks>
        /// The cannot be used by virtual assets.
        /// </remarks>
        /// <param name="data">The timeline data.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void SaveTimeline(byte[] data)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_SaveTimeline(unmanagedPtr, data);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetFramesPerSecond(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetDurationFrames(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetDuration(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] Internal_LoadTimeline(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SaveTimeline(IntPtr obj, byte[] data);
#endif

        #endregion
    }
}
