//
// Main.cs
//
// Copyright (C) 2008 Eric Butler
//
// Authors:
//   Eric Butler <eric@extremeboredom.net>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Diagnostics;
using System.Threading;
using System.IO;

using Hyena;

using Synapse.ServiceStack;
using Synapse.Core;
using Synapse.UI.Services;
using Synapse.Xmpp;
using Synapse.Xmpp.Services;

using Qyoto;
using QtWebKit;

using Synapse.QtClient.Windows;

namespace Synapse.QtClient
{
	using System.Collections.Generic;
	
	public class Client : Synapse.ServiceStack.Client
	{
		public static void Main (string[] args)
		{
			new QtClient.Client(args);
		}

		QApplication m_App;
		ResourceFileEngineHandler m_ResourceFileEngineHandler;
		AvatarFileEngineHandler m_AvatarFileEngineHandler;
		
		public Client (string[] args)
		{	
			Log.Information ("Starting Synapse");
			PlatformHacks.SetProcessName("synapse");
			GLib.Global.ProgramName = "Synapse";
			Gtk.Application.Init();

			NDesk.DBus.BusG.Init();
			
			m_App = new QApplication(args);
			m_App.ApplicationName = "Synapse";
			m_App.ApplicationVersion = "0.1";
			
			InitQtWebKit.InitSmoke();

			m_ResourceFileEngineHandler = new ResourceFileEngineHandler();
			m_AvatarFileEngineHandler = new AvatarFileEngineHandler();
			
			Application.Initialize(this);

			if (Application.Debugging) {			
				QtTraceListener listener = new QtTraceListener();
				listener.TraceOutputOptions = TraceOptions.Callstack;
				Debug.Listeners.Add(listener);
				Debug.Listeners.Add(new ConsoleTraceListener());
				Debug.WriteLine("Debug Mode On");
			}
			
			AppDomain.CurrentDomain.UnhandledException += HandleUnhandledException;
			
			// XXX: I dont like all of these being here.
			ServiceManager.RegisterService<Synapse.Xmpp.Services.AccountService>();
			ServiceManager.RegisterService<Synapse.Xmpp.Services.ShoutService>();
			ServiceManager.RegisterService<GuiService>();
			ServiceManager.RegisterService<ActionService>();
			
			QWebSettings.GlobalSettings().SetAttribute(QWebSettings.WebAttribute.DeveloperExtrasEnabled, true);
			
			if (Application.CommandLine.Contains ("uninstalled"))
				ConversationWidget.ThemesDirectory = Path.Combine(Environment.CurrentDirectory, "themes");
			else
				ConversationWidget.ThemesDirectory = Path.Combine(Paths.InstalledApplicationData, "themes");
			
			Application.Run();
				
			Application.Client.Invoke(delegate {
				/* Create the UI */
				Gui.MainWindow = new MainWindow();
				Gui.DebugWindow = new DebugWindow();
				Gui.PreferencesWindow = new PreferencesWindow();
				Gui.TrayIcon = new TrayIcon();
				Gui.TabbedChatsWindow = new TabbedChatsWindow();
				
				OnStarted();

				Gui.TrayIcon.Show();

				Gui.MainWindow.Show();
			});

			QApplication.Exec();
		}

		void HandleUnhandledException(object sender, UnhandledExceptionEventArgs args)
		{
			Console.Error.WriteLine("UNHANDLED EXCEPTION: " + args.ExceptionObject);

			string desktopPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
			string crashFileName = Path.Combine(desktopPath, String.Format("synapse-crash-{0}.log", DateTime.Now.ToFileTime()));
			string crashLog = args.ExceptionObject.ToString();
			Util.WriteToFile(crashFileName, crashLog);

			ShowErrorWindow("Oh no! An unhandled error has occured and Synapse must close.", (Exception)args.ExceptionObject);
			
			Environment.Exit(-1);
		}

		public QApplication QApp {
			get {
				return m_App;
			}
		}
		
		public override string ClientId {
			get { return "qtclient"; }
		}

		public override uint RunIdle (IdleHandler handler)
		{
			if (Thread.CurrentThread.ManagedThreadId != 1) {
				QCoreApplication.Invoke(delegate {
					handler();
				});
			} else {
				handler();
			}
			return 0;
		}

		public override uint RunTimeout (uint milliseconds, Synapse.ServiceStack.TimeoutHandler handler)
		{
			throw new System.NotImplementedException ();
		}

		public override bool IdleTimeoutRemove (uint id)
		{
			throw new System.NotImplementedException ();
		}

		public override object CreateImage (string fileName)
		{
			return (object) new QPixmap(fileName);
		}

		public override object CreateImage (byte[] data)
		{
			throw new NotImplementedException();
		}

		public override object CreateAction (string id, string label, string icon, object parent)
		{
			if (id == null) {
				QAction action = new QAction(null);
				action.SetSeparator(true);
				return action;
			} else {
				QAction action = new QAction(Gui.LoadIcon(icon, 16), label, (QObject)parent);
				QObject.Connect(action, Qt.SIGNAL("triggered(bool)"), delegate (bool chkd) {
					ServiceManager.Get<ActionService>().TriggerAction(id, action);
				});
				return action;
			}
		}

		public override void ShowErrorWindow (string errorTitle, Exception error)
		{
			this.InvokeAndBlock(delegate {
				ErrorDialog dialog = new ErrorDialog(errorTitle, error);
				dialog.Show();
				dialog.Run();
			});
		}
			
		public override void Dispose ()
		{
			Gui.TrayIcon.Dispose();
			QCoreApplication.Quit();
		}
	}
}
