﻿/*
    Copyright (C) 2014-2015 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Diagnostics;
using dnSpy.Contracts.Menus;
using dnSpy.Shared.UI.Menus;
using ICSharpCode.ILSpy;

namespace dnSpy.Commands {
	static class AboutHelpers {
		public const string BASE_URL = @"https://github.com/0xd4d/dnSpy/";

		public static void OpenWebPage(string url) {
			try {
				Process.Start(url);
			}
			catch {
				MainWindow.Instance.ShowMessageBox("Could not start browser");
			}
		}
	}

	[ExportMenuItem(OwnerGuid = MenuConstants.APP_MENU_HELP_GUID, Header = "_Latest Release", Group = MenuConstants.GROUP_APP_MENU_HELP_LINKS, Order = 0)]
	sealed class OpenReleasesUrlCommand : MenuItemBase {
		public override void Execute(IMenuItemContext context) {
			AboutHelpers.OpenWebPage(AboutHelpers.BASE_URL + @"releases");
		}
	}

	[ExportMenuItem(OwnerGuid = MenuConstants.APP_MENU_HELP_GUID, Header = "Latest _Build", Group = MenuConstants.GROUP_APP_MENU_HELP_LINKS, Order = 10)]
	sealed class OpenLatestBuildUrlCommand : MenuItemBase {
		public override void Execute(IMenuItemContext context) {
			AboutHelpers.OpenWebPage("https://ci.appveyor.com/project/0xd4d/dnspy/build/artifacts");
		}
	}

	[ExportMenuItem(OwnerGuid = MenuConstants.APP_MENU_HELP_GUID, Header = "_Issues", Group = MenuConstants.GROUP_APP_MENU_HELP_LINKS, Order = 20)]
	sealed class OpenIssuesUrlCommand : MenuItemBase {
		public override void Execute(IMenuItemContext context) {
			AboutHelpers.OpenWebPage(AboutHelpers.BASE_URL + @"issues");
		}
	}

	[ExportMenuItem(OwnerGuid = MenuConstants.APP_MENU_HELP_GUID, Header = "_Source Code", Group = MenuConstants.GROUP_APP_MENU_HELP_LINKS, Order = 30)]
	sealed class OpenSourceCodeUrlCommand : MenuItemBase {
		public override void Execute(IMenuItemContext context) {
			AboutHelpers.OpenWebPage(AboutHelpers.BASE_URL);
		}
	}
}
