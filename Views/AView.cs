using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVPExtension;
using $rootnamespace$.Presenters;

namespace $rootnamespace$.Views
{
    internal abstract partial class A$fileinputname$View : UserControl
    {
        protected readonly I$fileinputname$Presenter _$fileinputname$Presenter;
       
        public A$fileinputname$View(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _$fileinputname$Presenter = serviceProvider.CreatePresenter<I$fileinputname$Presenter, A$fileinputname$View>(this);
        }
    }
}
