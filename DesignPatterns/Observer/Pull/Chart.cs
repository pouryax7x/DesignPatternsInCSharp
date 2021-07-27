using System;

namespace DesignPatterns.Observer.Pull
{
    public class Chart : Observer
    {
        private DataSource dataSource;

        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Chart Updated" + dataSource.Value);
        }
    }
}