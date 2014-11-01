using System;
using System.Windows.Forms;

namespace AIMIS
{
	public class threading
	{
		public gbVariables gbvars;
		public tkui mainUI;

		public void ShowUI ()
		{
			frmControl form = new frmControl();
			form.MainUIclass = mainUI;
			form.gbvars = gbvars;

			Application.Run (form);
		}
	}
}

