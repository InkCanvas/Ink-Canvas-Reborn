﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Dubi906w.InkCanvasReborn.Services {

    public class EdgeGesturesBlockerService {

        private Window egbWin = new Window();

        private ILoggerFactory loggerFactory = App.AppHost.Services.GetService<ILoggerFactory>();
        private ILogger logger;

        public void InitEdgeGesturesBlockerService() {

            // create window
            egbWin.AllowsTransparency = true;
            egbWin.ResizeMode = ResizeMode.NoResize;
            egbWin.WindowStyle = WindowStyle.None;
            egbWin.Topmost = true;
            egbWin.Width = 2;
            egbWin.Height = 2;
            egbWin.Background = Brushes.Red;
            egbWin.Left = 0;
            egbWin.Top = 0;
            egbWin.Show();

            // create logger
            logger = loggerFactory.CreateLogger<EdgeGesturesBlockerService>();
            logger.Log(LogLevel.Information,"EdgeGesturesBlockerService Created.");

            WeakReferenceMessenger.Default.Register<EnableEdgeGesturesBlockerMessage>(this, (r, m) => {
                Helpers.EdgeGesturesUtil.DisableEdgeGestures(new WindowInteropHelper(egbWin).Handle,true);
                logger.Log(LogLevel.Information,"EnableEdgeGesturesBlockerMessage Received.");
            });
            WeakReferenceMessenger.Default.Register<DisableEdgeGesturesBlockerMessage>(this, (r, m) => {
                Helpers.EdgeGesturesUtil.DisableEdgeGestures(new WindowInteropHelper(egbWin).Handle,false);
                logger.Log(LogLevel.Information,"DisableEdgeGesturesBlockerMessage Received.");

            });
        }
    }

    public class DisableEdgeGesturesBlockerMessage {}
    public class EnableEdgeGesturesBlockerMessage {}
}
