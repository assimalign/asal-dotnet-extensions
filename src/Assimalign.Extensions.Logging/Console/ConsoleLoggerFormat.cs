namespace Assimalign.Extensions.Logging.Console
{
    /// <summary>
    /// Format of <see cref="ConsoleLogger" /> messages.
    /// </summary>
    [System.ObsoleteAttribute("ConsoleLoggerFormat has been deprecated.")]
    public enum ConsoleLoggerFormat
    {
        /// <summary>
        /// Produces messages in the default console format.
        /// </summary>
        Default,
        /// <summary>
        /// Produces messages in a format suitable for console output to the systemd journal.
        /// </summary>
        Systemd,
    }
}
