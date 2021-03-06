// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.

using System.ComponentModel;
using FlaxEditor.CustomEditors;
using FlaxEditor.States;
using FlaxEngine;
using FlaxEngine.GUI;
using FlaxEngine.Json;

namespace FlaxEditor.Windows
{
    /// <summary>
    /// Window used to show and edit current graphics rendering settings via <see cref="GraphicsSettings"/>.
    /// </summary>
    /// <seealso cref="FlaxEditor.Windows.EditorWindow" />
    public class GraphicsQualityWindow : EditorWindow
    {
        private static string _optionsName = "GraphicsQualityWindow";
        private ViewModel _viewModel;
        private string _cachedOptions;

        private class ViewModel
        {
            [DefaultValue(true)]
            [EditorOrder(0), EditorDisplay("Rendering"), Tooltip("If checked, the initial values will be from project Graphics Settings, otherwise will be adjusted locally (and stored in project cache).")]
            public bool UseProjectDefaults { get; set; } = true;

            [DefaultValue(false)]
            [EditorOrder(0), EditorDisplay("Rendering", "Use V-Sync"), Tooltip("Enables rendering synchronization with the refresh rate of the display device to avoid \"tearing\" artifacts.")]
            public bool UseVSync
            {
                get => GraphicsSettings.UseVSync;
                set => GraphicsSettings.UseVSync = value;
            }

            [DefaultValue(Quality.Medium)]
            [EditorOrder(1000), EditorDisplay("Quality", "AA Quality"), Tooltip("Anti Aliasing quality.")]
            public Quality AAQuality
            {
                get => GraphicsSettings.AAQuality;
                set => GraphicsSettings.AAQuality = value;
            }

            [DefaultValue(Quality.Medium)]
            [EditorOrder(1100), EditorDisplay("Quality", "SSR Quality"), Tooltip("Screen Space Reflections quality.")]
            public Quality SSRQuality
            {
                get => GraphicsSettings.SSRQuality;
                set => GraphicsSettings.SSRQuality = value;
            }

            [EditorOrder(1200), EditorDisplay("Quality", "SSAO Quality"), Tooltip("Screen Space Ambient Occlusion quality setting.")]
            public Quality SSAOQuality
            {
                get => GraphicsSettings.SSAOQuality;
                set => GraphicsSettings.SSAOQuality = value;
            }

            [DefaultValue(Quality.High)]
            [EditorOrder(1250), EditorDisplay("Quality", "Volumetric Fog Quality"), Tooltip("Volumetric Fog quality setting.")]
            public Quality VolumetricFogQuality
            {
                get => GraphicsSettings.VolumetricFogQuality;
                set => GraphicsSettings.VolumetricFogQuality = value;
            }

            [DefaultValue(Quality.Medium)]
            [EditorOrder(1300), EditorDisplay("Quality", "Shadows Quality"), Tooltip("The shadows quality.")]
            public Quality ShadowsQuality
            {
                get => GraphicsSettings.ShadowsQuality;
                set => GraphicsSettings.ShadowsQuality = value;
            }

            [DefaultValue(Quality.Medium)]
            [EditorOrder(1310), EditorDisplay("Quality", "Shadow Maps Quality"), Tooltip("The shadow maps quality (textures resolution).")]
            public Quality ShadowMapsQuality
            {
                get => GraphicsSettings.ShadowMapsQuality;
                set => GraphicsSettings.ShadowMapsQuality = value;
            }

            [DefaultValue(false)]
            [EditorOrder(1320), EditorDisplay("Quality", "Allow CSM Blending"), Tooltip("Enables cascades splits blending for directional light shadows.")]
            public bool AllowCSMBlending
            {
                get => GraphicsSettings.AllowCSMBlending;
                set => GraphicsSettings.AllowCSMBlending = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesWindow"/> class.
        /// </summary>
        /// <param name="editor">The editor.</param>
        public GraphicsQualityWindow(Editor editor)
        : base(editor, true, ScrollBars.Vertical)
        {
            Title = "Graphics Quality";

            var presenter = new CustomEditorPresenter(null);
            presenter.Panel.Parent = this;
            presenter.Select(_viewModel = new ViewModel());
        }

        private void OnPlayingStateGameSettingsApplying()
        {
            _cachedOptions = _viewModel.UseProjectDefaults ? null : JsonSerializer.Serialize(_viewModel);
        }

        private void OnPlayingStateGameSettingsApplied()
        {
            if (_cachedOptions != null)
            {
                JsonSerializer.Deserialize(_viewModel, _cachedOptions);
                _cachedOptions = null;
            }
        }

        /// <inheritdoc />
        public override void OnInit()
        {
            if (Editor.ProjectCache.TryGetCustomData(_optionsName, out var options) && !string.IsNullOrEmpty(options))
            {
                // Load cached settings
                JsonSerializer.Deserialize(_viewModel, options);
            }

            var playingState = Editor.StateMachine.PlayingState;
            playingState.GameSettingsApplying += OnPlayingStateGameSettingsApplying;
            playingState.GameSettingsApplied += OnPlayingStateGameSettingsApplied;
        }

        /// <inheritdoc />
        public override void OnExit()
        {
            var playingState = Editor.StateMachine.PlayingState;
            playingState.GameSettingsApplying -= OnPlayingStateGameSettingsApplying;
            playingState.GameSettingsApplied -= OnPlayingStateGameSettingsApplied;

            string data;
            if (_viewModel.UseProjectDefaults)
            {
                // Clear cached settings
                data = string.Empty;
            }
            else
            {
                // Store cached settings
                data = JsonSerializer.Serialize(_viewModel);
            }
            Editor.ProjectCache.SetCustomData(_optionsName, data);
        }
    }
}
