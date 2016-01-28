using System.Collections.Generic;
using System.Windows.Forms;

namespace Mool
{
	public class Page : Form
	{
		private Dictionary<string, object> _ScreenParameter;

		public Page()
		{
			_ScreenParameter = new Dictionary<string, object>();
		}

		public void SetParameter(string key, object value)
		{
			if(!_ScreenParameter.ContainsKey(key))
			{
				_ScreenParameter.Add(key, value);
			}
		}

		protected T GetParameter<T>(string key)
		{
			object value = null;

			if(_ScreenParameter.ContainsKey(key))
			{
				value = _ScreenParameter[key];
			}

			return (T)value;
		}
	}
}