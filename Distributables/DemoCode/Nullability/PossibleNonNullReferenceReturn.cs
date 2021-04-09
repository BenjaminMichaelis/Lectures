using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullability
{
    class PossibleNullReferenceReturn
    {
        protected string? _text;
        public string Text
        {
            get
            {
                // this._text could change in runtime on multi-threading
                if (string.IsNullOrEmpty(this._text))
                {
                    return string.Empty;
                }
                else
                {
                    // Throws warning CS8603 - Possible null reference return
                    return this._text;
                }
            }

            set
            {
                if (this._text != value)
                {
                    this._text = value;
                }
            }
        }
    }
}
