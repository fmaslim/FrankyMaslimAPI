using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrankyMaslimAPI.Models
{
	public enum LoggingType
	{
		Trace,
		Critical,
		Debug,
		Error,
		Information,
		Warning
	}

	public static class LoggingHelper
	{
		public static void LogCustomInfo<T>(this ILogger<T> _log, LoggingType logType, Exception ex = null) where T : class
		{
			string message = $"********** { ex?.Message } **********";
			List<object> parms = new List<object>();
			parms.Add($"Source: { ex.Source }");
			parms.Add($"Target Site: { ex.TargetSite }");
			parms.Add($"Stack Trace: { ex.StackTrace }");
		}

		public static void LogCustomInfo<T>(this ILogger<T> _log, LoggingType logType, string message) where T : class
		{
			message = $"********** { message } **********";
			writeToLog<T>(_log, logType, message);
		}

		private static void writeToLog<T>(ILogger<T> _log, LoggingType logType, Exception ex, object[] parms = null) where T : class
		{
			switch (logType)
			{
				case LoggingType.Critical:
					_log.LogCritical(ex, ex.Message, parms);
					break;
				case LoggingType.Debug:
					_log.LogDebug(ex.Message, parms);
					break;
				case LoggingType.Error:
					_log.LogError(ex, ex.Message, parms);
					break;
				case LoggingType.Trace:
					_log.LogTrace(ex, ex.Message, parms);
					break;
				case LoggingType.Warning:
					_log.LogWarning(ex.Message, parms);
					break;
				default: // Information or anything else
					_log.LogInformation(ex.Message, parms);
					break;
			}
		}

		private static void writeToLog<T>(ILogger<T> _log, LoggingType logType, string message, object[] parms = null) where T : class
		{
			switch (logType)
			{
				case LoggingType.Critical:
					_log.LogCritical(message, parms);
					break;
				case LoggingType.Debug:
					_log.LogDebug(message, parms);
					break;
				case LoggingType.Error:
					_log.LogError(message, parms);
					break;
				case LoggingType.Trace:
					_log.LogTrace(message, parms);
					break;
				case LoggingType.Warning:
					_log.LogWarning(message, parms);
					break;
				default: // Information or anything else
					_log.LogInformation(message, parms);
					break;
			}
		}
	}
}
