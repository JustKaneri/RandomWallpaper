using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper.Model
{
    [Serializable]
    public class ApplicationSettings 
    {
        /// <summary>
        /// Цвет рамки приложения
        /// </summary>
        public Color BorderCollor { get; set; } = Color.FromArgb(80, 53, 96);

        /// <summary>
        /// Цвет фона кнопок
        /// </summary>
        public Color BackgroundCollorButton { get; set; } = Color.FromArgb(80, 53, 96);

        /// <summary>
        /// Цвет текста кнопок
        /// </summary>
        public Color FontColorButton { get; set; } = Color.White;

        /// <summary>
        /// Показывать или нет оповещения
        /// </summary>
        public bool IsShowAllert { get; set; } = true;

        /// <summary>
        /// Время изменения обоев минуты
        /// </summary>
        public int PeriodСhange { get; set; } = 5;

        /// <summary>
        /// Менять ли обои автоматически
        /// </summary>
        public bool IsChange { get; set; } = false;

        /// <summary>
        /// Автозапуск приложения
        /// </summary>
        public bool IsAutoLoader { get; set; } = false;

        public void Reset()
        {
            BorderCollor  = Color.FromArgb(80, 53, 96);
            BackgroundCollorButton  = Color.FromArgb(80, 53, 96);
            FontColorButton = Color.White;
            IsShowAllert  = true;
            PeriodСhange  = 5;
            IsChange = false;
            IsAutoLoader  = false;
    }
    }
}
