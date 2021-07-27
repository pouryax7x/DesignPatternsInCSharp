using System;

namespace DesignPatterns.Decorator
{
    public class EncyptedCloudStream : Stream
    {
        private Stream stream;

        public EncyptedCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        public new void Write(string data)
        {
            var encrypted = Encrypt(data);
            stream.Write(encrypted);
        }
        private string Encrypt(string data)
        {
            return "!@#!$!@#$%#$%#$%#@$#$";
        }
    }
}