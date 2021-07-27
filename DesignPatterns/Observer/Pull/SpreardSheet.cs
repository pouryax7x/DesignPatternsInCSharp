using System;

namespace DesignPatterns.Observer.Pull
{
    public class SpreardSheet : Observer
    {
        private DataSource dataSource;

        public SpreardSheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Spreard Sheet Updated" + dataSource.Value);
        }
    }
}