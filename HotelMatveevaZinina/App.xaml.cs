using HotelMatveevaZinina.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelMatveevaZinina
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        static ZininaMatveevaHotelEntities context = new ZininaMatveevaHotelEntities();
        public static ZininaMatveevaHotelEntities GetContext()
        {
            if (context != null)
            {
                return context;
            }
            else
            {
                context = new ZininaMatveevaHotelEntities();
                return context;
            }
        }
    }
}