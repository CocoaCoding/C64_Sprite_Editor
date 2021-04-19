using System.Windows.Controls;

namespace C64_Sprite_Editor.ViewComponents
{
    /// <summary>
    /// A group of 8 TileControls representing a Byte of the Sprite Matrix
    /// </summary>
    public partial class TileGroupControl : UserControl
    {
        public TileGroupControl()
        {
            InitializeComponent();
        }

        public void SetByte(int value)
        {
            this.tile0.IsOn = (value & 128) == 128;
            this.tile1.IsOn = (value & 64) == 64;
            this.tile2.IsOn = (value & 32) == 32;
            this.tile3.IsOn = (value & 16) == 16;
            this.tile4.IsOn = (value & 8) == 8;
            this.tile5.IsOn = (value & 4) == 4;
            this.tile6.IsOn = (value & 2) == 2;
            this.tile7.IsOn = (value & 1) == 1;
        }

        public int GetByte()
        {
            int value = 0;
            if (this.tile0.IsOn)
            {
                value += 128;
            }

            if (this.tile1.IsOn)
            {
                value += 64;
            }

            if (this.tile2.IsOn)
            {
                value += 32;
            }

            if (this.tile3.IsOn)
            {
                value += 16;
            }

            if (this.tile4.IsOn)
            {
                value += 8;
            }

            if (this.tile5.IsOn)
            {
                value += 4;
            }

            if (this.tile6.IsOn)
            {
                value += 2;
            }

            if (this.tile7.IsOn)
            {
                value += 1;
            }

            return value;
        }
    }




}
