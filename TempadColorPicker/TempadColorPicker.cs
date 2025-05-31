namespace TempadColorPicker
{
    public partial class TempadColorPicker : Form
    {
        public TempadColorPicker()
        {
            InitializeComponent();
            this.Text = "Tempad Color Picker";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;

                    int red = selectedColor.R;
                    int green = selectedColor.G;
                    int blue = selectedColor.B;

                    int colorInt = (red << 16) | (green << 8) | blue;

                    lblRGB.Text = $"RGB: {red}, {green}, {blue}";
                    lblHex.Text = $"Hex: #{red:X2}{green:X2}{blue:X2}";
                    lblInt.Text = $"Integer: {colorInt}";
                    IntValuText.Text = $"Copy ToConfig: {colorInt}";
                    ColorPrev.BackColor = selectedColor;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
