using CustomUIDll;
using RandomWallpaper.Extension;
using RandomWallpaper.Model;
using System.Drawing;
using System.Windows.Forms;

namespace RandomWallpaper.Controller.Settings
{
    public class UIController
    {
        private readonly ApplicationSettings _settings;
        private readonly Form _form;


        public static readonly Color defaultFont = Color.FromArgb(80, 53, 96);

        public UIController(ApplicationSettings settings,Form form)
        {
            _settings = settings;
            _form = form;
        }

        public void UpdateColorTheme()
        {
            _form.Opacity = 0.9;
            _form.Opacity = 1;

            foreach (Control item in _form.Controls)
            {
                if (item is Button)
                {
                    if ((item as Button).Tag != null)
                        continue;

                    
                    (item as Button).BackColor = ColorTranslator.FromHtml(_settings.BackgroundCollorButton);
                    (item as Button).ForeColor = ColorTranslator.FromHtml(_settings.FontColorButton);
                }

                if (item is ControlBox)
                {
                    (item as ControlBox).BorderColor = ColorTranslator.FromHtml(_settings.BorderCollor);
                }
            }
        }

        public void SetColorFont(Color color)
        {
            _settings.FontColorButton = color.ToHex();
        }

        public void SetColorBorder(Color color) 
        {
            _settings.BorderCollor = color.ToHex();
        }

        public void SetColorButton(Color color)
        {
            _settings.BackgroundCollorButton = color.ToHex();
        }

        public void SetColors(Color fontColor)
        {
            SetColorFont(fontColor);
        }

        public void SetColors(Color fontColor, Color borderColor)
        {
            SetColorFont(fontColor);
            SetColorBorder(borderColor);
        }

        public void SetColors(Color fontColor , Color borderColor, Color colorButton)
        {
            SetColorFont(fontColor);
            SetColorBorder(borderColor);
            SetColorButton(colorButton);
        }

        public void SetDefaultColor()
        {
            
           _settings.BorderCollor = Color.FromArgb(80, 53, 96).ToHex();
           _settings.BackgroundCollorButton = Color.FromArgb(80, 53, 96).ToHex();
           _settings.FontColorButton = Color.White.ToHex();
        }
    }
}
