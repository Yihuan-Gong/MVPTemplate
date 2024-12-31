using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using $rootnamespace$.Views;

namespace $rootnamespace$.Presenters
{
    internal class $fileinputname$Presenter : I$fileinputname$Presenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly A$fileinputname$View _$fileinputname$View;

        public $fileinputname$Presenter(IServiceProvider serviceProvider, A$fileinputname$View $fileinputname$View)
        {
            _serviceProvider = serviceProvider;
            _$fileinputname$View = $fileinputname$View;
        }

    }
}
