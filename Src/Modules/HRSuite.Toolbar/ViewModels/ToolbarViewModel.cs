using System;

using HRSuite.Infrastructure;

namespace HRSuite.Toolbar
{
    public class ToolbarViewModel : ViewModelBase, IToolbarViewModel
    {
        public ToolbarViewModel(IToolbarView view)
            : base(view)
        {

        }
    }
}
