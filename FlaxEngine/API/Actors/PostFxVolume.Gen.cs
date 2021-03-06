// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// A special type of volume that blends custom set of post process settings into the rendering pipeline.
    /// </summary>
    [Serializable]
    public sealed partial class PostFxVolume : Actor
    {
        /// <summary>
        /// Creates new <see cref="PostFxVolume"/> object.
        /// </summary>
        private PostFxVolume() : base()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="PostFxVolume"/> object.
        /// </summary>
        /// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static PostFxVolume New()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Create(typeof(PostFxVolume)) as PostFxVolume;
#endif
        }

        /// <summary>
        /// Gets or sets size of the volume in the local space.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("PostFx Volume"), EditorOrder(50), Tooltip("Volume size")]
        public Vector3 Size
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Vector3 resultAsRef; Internal_GetSize(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetSize(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the order in which multiple volumes are blended together. The volume with the highest priority takes precedence over all other overlapping volumes.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("PostFx Volume"), EditorOrder(60), Tooltip("Volume blending priority. Highest priority takes precedence over all other overlapping volumes.")]
        public int Priority
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetPriority(unmanagedPtr); }
            set { Internal_SetPriority(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the distance inside the volume at which blending with the volume's settings occurs.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("PostFx Volume"), EditorOrder(70), Tooltip("Settings blending fade out radius (inner distance)")]
        public float BlendRadius
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetBlendRadius(unmanagedPtr); }
            set { Internal_SetBlendRadius(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the amount of influence the volume's properties have. 0 is no effect; 1 is full effect.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("PostFx Volume"), EditorOrder(80), Tooltip("Settings blending weight")]
        public float BlendWeight
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetBlendWeight(unmanagedPtr); }
            set { Internal_SetBlendWeight(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the value indicating whether the bounds of the volume are taken into account. If false, the volume affects the entire world, regardless of its bounds. If true, the volume only has an effect within its bounds.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("PostFx Volume"), EditorOrder(90), Tooltip("Determinates whether the bounds of the volume are used when blending.")]
        public bool IsBounded
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetIsBounded(unmanagedPtr); }
            set { Internal_SetIsBounded(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the ambient occlusion effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Ambient Occlusion"), EditorOrder(100), Tooltip("The ambient occlusion effect settings.")]
        public AmbientOcclusionSettings AmbientOcclusion
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { AmbientOcclusionSettings resultAsRef; Internal_GetAmbientOcclusion(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetAmbientOcclusion(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the bloom effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Bloom"), EditorOrder(200), Tooltip("The bloom effect settings.")]
        public BloomSettings Bloom
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { BloomSettings resultAsRef; Internal_GetBloom(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetBloom(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the tone mapping effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Tone Mapping"), EditorOrder(300), Tooltip("The tone mapping effect settings.")]
        public ToneMappingSettings ToneMapping
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { ToneMappingSettings resultAsRef; Internal_GetToneMapping(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetToneMapping(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the color grading effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Color Grading"), EditorOrder(400), Tooltip("The color grading effect settings.")]
        public ColorGradingSettings ColorGrading
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { ColorGradingSettings resultAsRef; Internal_GetColorGrading(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetColorGrading(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the eye adaptation effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Eye Adaptation"), EditorOrder(500), Tooltip("The eye adaptation effect settings.")]
        public EyeAdaptationSettings EyeAdaptation
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { EyeAdaptationSettings resultAsRef; Internal_GetEyeAdaptation(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetEyeAdaptation(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the camera artifacts effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Camera Artifacts"), EditorOrder(600), Tooltip("The camera artifacts effect settings.")]
        public CameraArtifactsSettings CameraArtifacts
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { CameraArtifactsSettings resultAsRef; Internal_GetCameraArtifacts(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetCameraArtifacts(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the lens flares effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Lens Flares"), EditorOrder(700), Tooltip("The lens flares effect settings.")]
        public LensFlaresSettings LensFlares
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { LensFlaresSettings resultAsRef; Internal_GetLensFlares(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetLensFlares(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the depth of field effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Depth Of Field"), EditorOrder(800), Tooltip("The depth of field effect settings.")]
        public DepthOfFieldSettings DepthOfField
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { DepthOfFieldSettings resultAsRef; Internal_GetDepthOfField(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetDepthOfField(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the motion blur effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Motion Blur"), EditorOrder(900), Tooltip("The motion blur effect settings.")]
        public MotionBlurSettings MotionBlur
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { MotionBlurSettings resultAsRef; Internal_GetMotionBlur(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetMotionBlur(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the screen space reflections effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Screen Space Reflections"), EditorOrder(1000), Tooltip("The screen space reflections effect settings.")]
        public ScreenSpaceReflectionsSettings ScreenSpaceReflections
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { ScreenSpaceReflectionsSettings resultAsRef; Internal_GetScreenSpaceReflections(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetScreenSpaceReflections(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the anti-aliasing effect settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Anti Aliasing"), EditorOrder(1100), Tooltip("The anti-aliasing effect settings.")]
        public AntiAliasingSettings AntiAliasing
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { AntiAliasingSettings resultAsRef; Internal_GetAntiAliasing(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetAntiAliasing(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the PostFx materials rendering settings.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("PostFx Materials"), NoAnimate, EditorOrder(1200), Tooltip("The PostFx materials rendering settings.")]
        public PostFxMaterialsSettings PostFxMaterials
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { PostFxMaterialsSettings resultAsRef; Internal_GetPostFxMaterials(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetPostFxMaterials(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets the volume bounding box (oriented).
        /// </summary>
        [UnmanagedCall]
        public OrientedBoundingBox OrientedBox
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { OrientedBoundingBox resultAsRef; Internal_GetOrientedBox(unmanagedPtr, out resultAsRef); return resultAsRef; }
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetSize(IntPtr obj, out Vector3 resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetSize(IntPtr obj, ref Vector3 val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetPriority(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetPriority(IntPtr obj, int val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetBlendRadius(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetBlendRadius(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetBlendWeight(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetBlendWeight(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetIsBounded(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetIsBounded(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetAmbientOcclusion(IntPtr obj, out AmbientOcclusionSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetAmbientOcclusion(IntPtr obj, ref AmbientOcclusionSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetBloom(IntPtr obj, out BloomSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetBloom(IntPtr obj, ref BloomSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetToneMapping(IntPtr obj, out ToneMappingSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetToneMapping(IntPtr obj, ref ToneMappingSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetColorGrading(IntPtr obj, out ColorGradingSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetColorGrading(IntPtr obj, ref ColorGradingSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetEyeAdaptation(IntPtr obj, out EyeAdaptationSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetEyeAdaptation(IntPtr obj, ref EyeAdaptationSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetCameraArtifacts(IntPtr obj, out CameraArtifactsSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetCameraArtifacts(IntPtr obj, ref CameraArtifactsSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetLensFlares(IntPtr obj, out LensFlaresSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetLensFlares(IntPtr obj, ref LensFlaresSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetDepthOfField(IntPtr obj, out DepthOfFieldSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetDepthOfField(IntPtr obj, ref DepthOfFieldSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetMotionBlur(IntPtr obj, out MotionBlurSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetMotionBlur(IntPtr obj, ref MotionBlurSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetScreenSpaceReflections(IntPtr obj, out ScreenSpaceReflectionsSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetScreenSpaceReflections(IntPtr obj, ref ScreenSpaceReflectionsSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetAntiAliasing(IntPtr obj, out AntiAliasingSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetAntiAliasing(IntPtr obj, ref AntiAliasingSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetPostFxMaterials(IntPtr obj, out PostFxMaterialsSettings resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetPostFxMaterials(IntPtr obj, ref PostFxMaterialsSettings val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetOrientedBox(IntPtr obj, out OrientedBoundingBox resultAsRef);
#endif

        #endregion
    }
}
