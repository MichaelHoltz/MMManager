using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MMManager
{
    class MMManagerTTTButton :Button
    {
        public Boolean customEnable { get; set; } = true;
        public Boolean allowClick { get; set; } = true;
        protected override void OnClick(EventArgs e)
        {
            if(customEnable && allowClick)
                base.OnClick(e);
        }
    }
}
