using System.Collections.Generic;
using System.Windows.Controls;

namespace C64_Sprite_Editor.ViewComponents
{
    /// <summary>
    /// A group of 3 TileGroups representing 3 Bytes (one row) of the Sprite Matrix
    /// </summary>
    public partial class TileRowControl : UserControl
    {
        public TileRowControl()
        {
            InitializeComponent();
        }

        public void SetBytes(List<int> values)
        {
            if (values.Count == 3)
            {
                this.group0.SetByte(values[0]);
                this.group1.SetByte(values[1]);
                this.group2.SetByte(values[2]);
            }
        }

        public List<int> GetBytes()
        {
            List<int> values = new List<int>();
            values.Add(this.group0.GetByte());
            values.Add(this.group1.GetByte());
            values.Add(this.group2.GetByte());
            return values;
        }
    }
}
