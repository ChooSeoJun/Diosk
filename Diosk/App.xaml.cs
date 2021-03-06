﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Diosk.Model;

namespace Diosk
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public static SeatDataSource seatDataSource = new SeatDataSource();

        public static Menu menu = new Menu();

        public static TotalData totalData = new TotalData();

        public static Chatting chatting = new Chatting();

        public App()
        {
            App.seatDataSource.dataLoad();
        }
    }
}
