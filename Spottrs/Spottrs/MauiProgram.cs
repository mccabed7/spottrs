﻿using Microsoft.Maui.LifecycleEvents;

namespace Spottrs;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        #if WINDOWS
                builder.ConfigureLifecycleEvents(events =>
                {
                    events.AddWindows(windowsLifecycleBuilder =>
                    {
                        windowsLifecycleBuilder.OnWindowCreated(window =>
                        {
                            window.ExtendsContentIntoTitleBar = true;
                            var handle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                            var id = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(handle);
                            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(id);
                            switch (appWindow.Presenter)
                            {
                                case Microsoft.UI.Windowing.OverlappedPresenter overlappedPresenter:
                                    overlappedPresenter.SetBorderAndTitleBar(false, false);
                                    overlappedPresenter.Maximize();
                                    break;
                            }
                        });
                    });
                });
        #endif

        return builder.Build();
	}
}
