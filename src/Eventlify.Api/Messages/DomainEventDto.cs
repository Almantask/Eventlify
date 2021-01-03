using System;

namespace Eventlify.Api.Messages
{
    public class DomainEventDto
    {
        /// <summary>
        /// When was the event created. UTC.
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// Names of an event.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Service which requested the event to be pushed.
        /// </summary>
        public string Service { get; set; }
        /// <summary>
        /// Domain from which the event originates.
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// Expiry time in seconds.
        /// </summary>
        public long ExpiryTime { get; set; }
    }
}
