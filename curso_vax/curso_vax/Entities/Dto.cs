using System;
using System.Collections.Generic;
using System.Text;

namespace curso_vax.Entities
{
    public abstract class Dto : IDisposable
    {
        bool _isDisposable = true;
        public void Dispose()
        {
            if (!_isDisposable)
            {
                _isDisposable = true;
                GC.SuppressFinalize(this);
            }
        }
    }
}
