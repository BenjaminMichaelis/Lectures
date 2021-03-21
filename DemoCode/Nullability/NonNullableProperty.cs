using System;
using System.Collections.Generic;
using System.Text;

namespace Nullability
{
    public class NonNullableProperty
    {
        public NonNullableProperty(string text)
        {
            Text = Text;
        }

        public string? _text;

        public string Text
        {
            get => _text!;
            set => this._text = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
