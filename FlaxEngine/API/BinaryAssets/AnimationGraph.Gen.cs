// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// The Animation Graph is used to evaluate a final pose for the animated model for the current frame.
    /// </summary>
    public sealed partial class AnimationGraph : BinaryAsset
    {
        /// <summary>
        /// Creates new <see cref="AnimationGraph"/> object.
        /// </summary>
        private AnimationGraph() : base()
        {
        }

        /// <summary>
        /// Gets the base model asset used for the animation preview and the skeleton layout source.
        /// </summary>
        [UnmanagedCall]
        public SkinnedModel BaseModel
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetBaseModel(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Tries to load the animation graph surface from the asset.
        /// </summary>
        /// <returns>Loaded surface bytes or null if cannot load it or it's missing.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public byte[] LoadSurface()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_LoadSurface(unmanagedPtr);
#endif
        }

        /// <summary>
        /// Updates the animation graph surface (save new one, discard cached data, reload asset).
        /// </summary>
        /// <param name="data">Surface data.</param>
        /// <returns>True if cannot save it, otherwise false.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public bool SaveSurface(byte[] data)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_SaveSurface(unmanagedPtr, data);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SkinnedModel Internal_GetBaseModel(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] Internal_LoadSurface(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_SaveSurface(IntPtr obj, byte[] data);
#endif

        #endregion
    }
}
