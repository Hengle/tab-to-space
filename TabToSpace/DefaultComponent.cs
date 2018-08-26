using HongliangSoft.Utilities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TabToSpace
{
	public partial class DefaultComponent : Component
	{
		public DefaultComponent()
		{
			InitializeComponent();

			tabToSpace.Click += OnClickTabToSpace;
			quit.Click += OnClickQuit;

			var keyHook = new KeyboardHook();
			keyHook.KeyboardHooked += new KeyboardHookedEventHandler( OnHookedKeyboard );
		}

		private void OnHookedKeyboard( object sender, KeyboardHookedEventArgs e )
		{
			if ( e.AltDown && e.KeyCode == Keys.F5 )
			{
				OnClickTabToSpace( sender, e );
			}
		}

		private void OnClickTabToSpace( object sender, EventArgs e )
		{
			var text = Clipboard.GetText();
			var result = TabToSpaceConvertor.Process( text, 4 );
			Clipboard.SetText( result );
		}

		private void OnClickQuit( object sender, EventArgs e )
		{
			Application.Exit();
		}

		private void OnClickNotifyIcon( object sender, EventArgs e )
		{
			OnClickTabToSpace( sender, e );
		}
	}
}
