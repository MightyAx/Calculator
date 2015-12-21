using System;

namespace Calculator
{
	public class Operand
	{
		private bool _isResultSet = false;
		private uint _result;

		public Operand()
		{
		}

		public Operand(uint result)
		{
			SetResult (result);
		}

		public uint GetResult() {
			if (_isResultSet) {
				return _result;
			}
			throw new ArgumentNullException ("Result Not Set");
		}

		public void SetResult(uint result)
		{
			_result = result;
			_isResultSet = true;

		}
	}
}

