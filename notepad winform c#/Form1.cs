using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace notepad_winform_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    font_cmb.Items.Add(fa.Name);
                }
            }

            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                if (!color.IsSystemColor)
                {
                    color_cmb.Items.Add(knownColor.ToString());
                }
            }

            /*string s = "A sample string";

SizeF size = e.Graphics.MeasureString(s, new Font("Arial", 24));*/


            var fontSizes = new float[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            size_cmb.Items.Clear();
            foreach (var size in fontSizes)
            {
                size_cmb.Items.Add(size);
            }
            size_cmb.SelectedIndex = 0;
        }

        private void selected_font(object sender, EventArgs e)
        {
            string selectedFontName = font_cmb.SelectedItem.ToString();
            Font currentFont = main_txtbox.Font;
            Font newFont = new Font(selectedFontName, currentFont.Size, currentFont.Style);
            main_txtbox.Font = newFont;
        }

        private void selected_size(object sender, EventArgs e)
        {
            float selectedFontSize = (float)(size_cmb.SelectedItem);
            Font currentFont = main_txtbox.Font;
            Font newFont = new Font(currentFont.FontFamily, selectedFontSize, currentFont.Style);
            main_txtbox.Font = newFont;
        }

        private void selected_color(object sender, EventArgs e)
        {
            string selectedColorName = color_cmb.SelectedItem.ToString();
            Color selectedColor = Color.FromName(selectedColorName);
            main_txtbox.ForeColor = selectedColor;
        }

        private void B_btn_Click(object sender, EventArgs e)
        {
            if (main_txtbox.Font.Style != FontStyle.Bold)
            {
                main_txtbox.Font = new Font(main_txtbox.Font, FontStyle.Bold);
            }
            else
            {
                main_txtbox.Font = new Font(main_txtbox.Font, FontStyle.Regular);
            }
        }

        private void I_btn_Click(object sender, EventArgs e)
        {
            if (main_txtbox.Font.Style != FontStyle.Italic)
            {
                main_txtbox.Font = new Font(main_txtbox.Font, FontStyle.Italic);
            }
            else
            {
                main_txtbox.Font = new Font(main_txtbox.Font, FontStyle.Regular);
            }
        }

        private void U_btn_Click(object sender, EventArgs e)
        {
            if (main_txtbox.Font.Style != FontStyle.Underline)
            {
                main_txtbox.Font = new Font(main_txtbox.Font, FontStyle.Underline);
            }
            else
            {
                main_txtbox.Font = new Font(main_txtbox.Font, FontStyle.Regular);
            }
        }

        private void L_btn_Click(object sender, EventArgs e)
        {
            main_txtbox.SelectionAlignment = (HorizontalAlignment)LeftRightAlignment.Left;
        }

        private void R_btn_Click(object sender, EventArgs e)
        {
            main_txtbox.SelectionAlignment = (HorizontalAlignment)LeftRightAlignment.Right;
        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            main_txtbox.SelectionAlignment = (HorizontalAlignment)HorizontalAlignment.Center;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (save_txtbox.Text != "")
            {
                FileWorks.WriteTextToFile(main_txtbox.Text, save_txtbox.Text);
            }
            save_txtbox.Text = "";
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            if (load_txtbox.Text != "")
            {
                main_txtbox.Text = FileWorks.ReadTextFromFile(load_txtbox.Text);
               
            }
            load_txtbox.Text = "";
        }
    }
}
