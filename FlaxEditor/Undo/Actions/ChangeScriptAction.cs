// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using System;
using FlaxEditor.Modules;
using FlaxEngine;

namespace FlaxEditor.Actions
{
    /// <summary>
    /// Change <see cref="Script"/> order or enable/disable undo action.
    /// </summary>
    /// <seealso cref="FlaxEditor.IUndoAction" />
    /// <seealso cref="FlaxEditor.ISceneEditAction" />
    public class ChangeScriptAction : IUndoAction, ISceneEditAction
    {
        private Guid _scriptId;
        private bool _enableA;
        private int _orderA;
        private bool _enableB;
        private int _orderB;

        private ChangeScriptAction(Script script, bool enable, int order)
        {
            _scriptId = script.ID;
            _enableA = script.Enabled;
            _orderA = script.OrderInParent;
            _enableB = enable;
            _orderB = order;
        }

        /// <summary>
        /// Creates new undo action that changes script order in parent actor scripts collection.
        /// </summary>
        /// <param name="script">The script to reorder.</param>
        /// <param name="newOrder">New index.</param>
        /// <returns>The action (not performed yet).</returns>
        public static ChangeScriptAction ChangeOrder(Script script, int newOrder)
        {
            return new ChangeScriptAction(script, script.Enabled, newOrder);
        }

        /// <summary>
        /// Creates new undo action that enables/disables script.
        /// </summary>
        /// <param name="script">The script to enable or disable.</param>
        /// <param name="newEnaled">New enable state.</param>
        /// <returns>The action (not performed yet).</returns>
        public static ChangeScriptAction ChangeEnabled(Script script, bool newEnaled)
        {
            return new ChangeScriptAction(script, newEnaled, script.OrderInParent);
        }

        /// <inheritdoc />
        public string ActionString => "Edit script";

        /// <inheritdoc />
        public void Do()
        {
            var script = FlaxEngine.Object.Find<Script>(ref _scriptId);
            if (script == null)
                return;
            script.Enabled = _enableB;
            script.OrderInParent = _orderB;
        }

        /// <inheritdoc />
        public void Undo()
        {
            var script = FlaxEngine.Object.Find<Script>(ref _scriptId);
            if (script == null)
                return;
            script.Enabled = _enableA;
            script.OrderInParent = _orderA;
        }

        /// <inheritdoc />
        public void MarkSceneEdited(SceneModule sceneModule)
        {
            var script = FlaxEngine.Object.Find<Script>(ref _scriptId);
            if (script != null)
                sceneModule.MarkSceneEdited(script.Scene);
        }
    }
}
