using CustomUIDll;
using RandomWallpaper.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWallpaper.Controller.Settings
{
    public class UIController
    {
        private readonly ApplicationSettings _settings;
        private readonly Form _form;

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
    }
}
