using System;

namespace UlmoLibrary
{
	public abstract class ConnManager : IConnectible
	{
		public ConnManager ()
		{
		}

		public abstract String getValues();

		public abstract String getUUID();

		public abstract void startScan();

		public abstract void stopScan();
	}
}

