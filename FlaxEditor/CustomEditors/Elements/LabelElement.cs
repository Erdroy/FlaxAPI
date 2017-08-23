////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

using FlaxEngine.GUI;

namespace FlaxEditor.CustomEditors.Elements
{
    /// <summary>
    /// The label element.
    /// </summary>
    /// <seealso cref="FlaxEditor.CustomEditors.LayoutElement" />
    public class LabelElement : LayoutElement
    {
        /// <summary>
        /// The label.
        /// </summary>
        public readonly Label Label;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxElement"/> class.
        /// </summary>
        public LabelElement()
        {
            Label = new Label(false, 0, 0, 100, 18);
            // TODO: auto height for label
        }

        /// <inheritdoc />
        public override Control Control => Label;
    }
}