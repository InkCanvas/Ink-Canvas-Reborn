﻿using Dubi906w.InkCanvasReborn.Helpers;
using System;
using System.Linq;
using System.Threading;

namespace Dubi906w.InkCanvasReborn {

    internal class Program {
        public static Mutex Mutex = new Mutex(true, "Dubi906w.InkCanvasReborn.Lock");
        public static string[] Args;
        public static App Application;

        [STAThread]
        private static void Main(string[] args) {
            // 设置命令行参数
            Args = args;

            //判断是否需要显示控制台窗口
            if (!args.Contains("--console")) ConsoleHelper.HideConsoleWindow();
            else ConsoleHelper.ShowConsoleWindow();

            ConsoleHelper.ConsoleWrite_InkCanvasRebornASCIIText();
            ConsoleHelper.ConsoleWrite_Copyright();

            // 启动 App
            Application = new App();
            Application.InitializeComponent();
            Application.Run();
        }
    }
}