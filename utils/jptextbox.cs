using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utils
{
    public partial class jptextbox : TextBox
    {
        public jptextbox()
        {
            InitializeComponent();
        }

        // validate property
        public Boolean validate
        {
            set;
            get;
        }

        public jptextbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
