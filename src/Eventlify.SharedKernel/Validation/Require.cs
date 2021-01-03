using System;

namespace Eventlify.SharedKernel.Validation
{
    public static class Require
    {
        public static void NotNull<T>(T o, string name) where T: class
        {
            if (o == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void NotNull<T>(T o) where T: class
        {
            if (o == null)
            {
                throw new ArgumentNullException(typeof(T).Name);
            }
        }
    }
}
