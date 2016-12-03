using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;
using SpriteLibrary;
namespace MMManager.Controls
{
    /// <summary>
    /// Sprite Button to replace MMManagerTTTButton
    /// 
    /// Trying to encapsulate some of the overhead to simplify..
    /// </summary>
    class SpriteButton 
    {
        private MediaPlayer mp;
        
        public Boolean customEnable { get; set; } = true;
        public Boolean allowClick { get; set; } = true;

        public SpriteButton()
        {
            //base.SpriteAdjustedPoint()
        }
    }
}
