using System;
using System.Windows.Forms;

namespace TabToSpace
{
	public static class Program
	{
		[STAThread]
		static void Main()
		{
			var com = new DefaultComponent();
			Application.Run();
		}
	}
}
