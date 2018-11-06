namespace CreationalDesignPatterns.Entities.FactoryMethod.Logger
{
    using System;
    using System.IO;
    using System.Configuration;

    public class LoggerFactory
	{
		public bool FileLoggingEnabled
		{
			get
			{
				try
				{	
					string fileLoggingValue = Environment.GetEnvironmentVariable("FileLogging");

					return fileLoggingValue.Equals("ON", StringComparison.OrdinalIgnoreCase);
				}
				catch (IOException)
				{
					return false;
				}
			}
		}

		// Factory Method
		public  ILogger Logger
		{
			get
			{
				if (FileLoggingEnabled)
				{
					return new FileLogger();
				}
				else
				{
					return new ConsoleLogger();
				}
			}
		}
	}

}