using System;

namespace Eventlify.Application.Models
{
    public class DomainEvent
    {
        /// <summary>
        /// When was the event created. UTC.
        /// </summary>
        public DateTime TimeStamp { get; }
        /// <summary>
        /// Names of an event.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Service which requested the event to be pushed.
        /// </summary>
        public string Service { get; }
        /// <summary>
        /// Domain from which the event originates.
        /// </summary>
        public string Domain { get; }
        /// <summary>
        /// Expiry time in seconds.
        /// </summary>
        public long ExpiryTime { get; }

        public DomainEvent(string name, string service, string domain, long expiryTime)
            : this(DateTime.UtcNow, name, service, domain, expiryTime) { }

        public DomainEvent(DateTime timeStamp, string name, string service, string domain, long expiryTime)
        {
            TimeStamp = timeStamp;
            Name = name;
            Service = service;
            Domain = domain;
            ExpiryTime = expiryTime;
        }
    }
}
