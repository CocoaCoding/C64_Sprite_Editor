using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace C64_Sprite_Editor.ViewComponents
{
    /// <summary>
    /// A TileControl represents a Bit of the Sprite Matrix
    /// </summary>
    public partial class TileControl : UserControl
    {
        private bool _isOn = false;
        public bool IsOn
        {
            get { return _isOn; }
            set
            {
                _isOn = value;
                this.SetIsOnColor();
            }
        }

        private SolidColorBrush onBrush = new SolidColorBrush(Colors.Black);
        private SolidColorBrush offBrush = new SolidColorBrush(Colors.White);

        public TileControl()
        {
            InitializeComponent();
        }

        private void OnDockPanelMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.IsOn = !this.IsOn;
        }

        private void SetIsOnColor()
        {
            if (_isOn == true)
            {
                this.ValuePanel.Background = this.onBrush;
            }
            else
            {
                this.ValuePanel.Background = this.offBrush;
            }
        }
    }
}
